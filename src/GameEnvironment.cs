using BizHawk.Client.Common;
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

        public void SkipStartScreen()
        {
            //Press and release Start button
            FrameAdvance(JoypadSpace.Buttons.Start);

            //Press Start button until the game starts
            while (memoryHandler.Time == 401)
            {
                //Press and release Start button
                FrameAdvance(JoypadSpace.Buttons.Start);

                //run-out the prelevel timer to skip the animation
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
                FrameAdvance(JoypadSpace.Buttons.A);
            }
        }

        public StepResponse Step(JoypadSpace.Buttons action)
        {
            controller.Toggle(buttons[(int)action]);
            if(memoryHandler.IsDying)
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
                XPosition = memoryHandler.XPosition(),
                XPositionOffset = memoryHandler.XPositionOffset,
                XLevelPosition = memoryHandler.XLevelPosition,
                XScreenPosition = memoryHandler.XScreenPosition,
                PlayerPos = memoryHandler.PlayerPos
            };
        }

        private void FrameAdvance(JoypadSpace.Buttons action)
        {
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
            return penalty > 0 ? 0: penalty ;
        }
        private int PositionReward()
        {
            int reward = (int)(memoryHandler.XPosition() - lastPosition);
            lastPosition = memoryHandler.XPosition();
            return (reward < -5 || reward > 5) ? 0 : reward;
        }

        private bool IsDone()
        {
            return memoryHandler.IsDying || memoryHandler.IsDead || memoryHandler.IsStageEnds() || memoryHandler.IsWorldEnds();
        }
    }
}
