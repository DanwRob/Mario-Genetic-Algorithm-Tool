﻿using BizHawk.Client.Common;
using BizHawk.Emulation.Common;
using GeneticAlgorithmTool.Models;
using System.Collections.Generic;

namespace GeneticAlgorithmTool
{
    public class GameEnvironment
    {
        private readonly IEmulator emulator;
        private readonly ApiContainer apiContainer;
        private readonly GameMemoryHandler memoryHandler;
        private readonly ClickyVirtualPadController controller;
        private readonly IList<string> buttons;
        private uint lastTime = 0;
        private uint lastPosition = 0;

        public GameEnvironment(IEmulator emulator, ApiContainer apiContainer, ClickyVirtualPadController controller)
        {
            this.emulator = emulator;
            this.apiContainer = apiContainer;
            this.controller = controller;
            memoryHandler = new GameMemoryHandler(apiContainer.Memory);
            buttons = emulator.ControllerDefinition.BoolButtons;
        }

        public void StartScreen()
        {
            memoryHandler.Gameplay = GameMemoryHandler.GameplayMode.Standard;
        }

        public void SkipStartScreen()
        {
            //Press and release Start button
            FrameAdvance(Buttons.Start);
            FrameAdvance(Buttons.A);
            //Press Start button until the game starts
            while (memoryHandler.Gameplay == GameMemoryHandler.GameplayMode.Demo || memoryHandler.Time == 401)
            {
                //Press and release Start button
                FrameAdvance(Buttons.Start);
                memoryHandler.WriteStage();

                FrameAdvance(Buttons.A);
                memoryHandler.PrelevelTimer();
            }
        }

        private void SkipDead() => memoryHandler.PlayerDies();

        private void SkipTrasitionScreen()
        {
            while (memoryHandler.IsInTrasition)
            {
                //run-out the prelevel timer to skip the animation
                memoryHandler.PrelevelTimer();
                FrameAdvance(Buttons.A);
            }
        }

        public StepResponse Step(IEnumerable<Buttons> action)
        {

            PressButton(action);

            if (memoryHandler.IsDying)
            {
                SkipDead();
            }

            //Skip transition screen
            SkipTrasitionScreen();

            return new StepResponse
            {
                Reward = GetReward(),
                Done = IsDone(),
                Info = GetGameInformation()
            };
        }

        private void PressButton(IEnumerable<Buttons> actions)
        {
            foreach (Buttons btn in actions)
            {
                if (btn != Buttons.None)
                {
                    controller.Click(buttons[(int)btn]);
                }
            }
        }

        private StepInformation GetGameInformation()
        {
            return new StepInformation
            {
                Level = memoryHandler.Level,
                World = memoryHandler.World,
                Coins = memoryHandler.Coins,
                Lives = memoryHandler.Lives,
                Score = memoryHandler.Score,
                Time = memoryHandler.Time,
                XPosition = memoryHandler.XPosition,
                YPosition = memoryHandler.YPosition
            };
        }

        private void FrameAdvance(Buttons action)
        {
            if (action == Buttons.None) {
                emulator.FrameAdvance(controller, false, false);
                return;
            }
            controller.Toggle(buttons[(int)action]);
            emulator.FrameAdvance(controller, false, false);
            controller.Toggle(buttons[(int)action]);
        }

        private int GetReward() {
            return PositionReward() + DeathPenalty() + TimePenalty();
        }

        private int DeathPenalty()
        {
            if(memoryHandler.IsDying || memoryHandler.IsDead)
            {
                return -25;
            }
            return 0;
        }

        private int TimePenalty()
        {
            int penalty = (int)(memoryHandler.Time - lastTime);
            lastTime = memoryHandler.Time;
            return penalty > 0 ? 0: penalty;
        }
        private int PositionReward()
        {
            int reward = (int)(memoryHandler.XPosition - lastPosition);
            lastPosition = memoryHandler.XPosition;
            return (reward < -5 || reward > 5) ? 0 : reward;
        }

        private bool IsDone()
        {
            return memoryHandler.IsDying || memoryHandler.IsDead || memoryHandler.IsStageEnds() || memoryHandler.IsWorldEnds();
        }
    }
}
