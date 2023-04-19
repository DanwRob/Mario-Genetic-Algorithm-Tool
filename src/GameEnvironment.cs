using BizHawk.Client.Common;
using BizHawk.Emulation.Common;
using System.Collections.Generic;
using System.Linq;

namespace GeneticAlgorithmTool
{
    public class GameEnvironment
    {
        private readonly IEmulator emulator;
        private readonly ApiContainer apiContainer;
        private readonly GameMemoryHandler memoryHandler;
        private readonly ClickyVirtualPadController controller;
        private readonly IList<string> buttons;
        private readonly StepInformation gameInformation = new ();

        private static readonly uint[] s_busyStates = { 0, 1, 2, 3, 4, 5, 7 };

        public GameEnvironment(IEmulator emulator, ApiContainer apiContainer, ClickyVirtualPadController controller)
        {
            this.emulator = emulator;
            this.apiContainer = apiContainer;
            this.controller = controller;
            memoryHandler = new GameMemoryHandler(apiContainer.Memory);
            //memoryHandler.SetGameplayMode(GameMemoryHandler.GameplayMode.Standard);
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
            while (s_busyStates.Contains(memoryHandler.State))
            {
                //run-out the prelevel timer to skip the animation
                memoryHandler.PrelevelTimer();
                FrameAdvance(JoypadSpace.Buttons.A);
            }
        }

        public StepInformation Step(JoypadSpace.Buttons action)
        {
            controller.Toggle(buttons[(int)action]);
            if(memoryHandler.State == 11)
            {
                SkipDead();
            }

            //Skip transition screen
            SkipTrasitionScreen();
            UpdateGameInformation();

            return gameInformation;
        }

        private void UpdateGameInformation()
        {
            gameInformation.Level = memoryHandler.Level;
            gameInformation.World = memoryHandler.World;
            gameInformation.Coins = memoryHandler.Coins;
            gameInformation.Lives = memoryHandler.Lives;
            gameInformation.Score = memoryHandler.Score;
            gameInformation.Time = memoryHandler.Time;
        }
        private void FrameAdvance(JoypadSpace.Buttons action)
        {
            controller.Toggle(buttons[(int)action]);
            emulator.FrameAdvance(controller, false, false);
            controller.Toggle(buttons[(int)action]);
        }
    }

    public class StepInformation
    {
        public uint Level { get; set; }
        public uint World { get; set; }
        public uint Coins { get; set; }
        public uint Score { get; set; }
        public uint Time { get; set; }
        public uint Lives { get; set; }
    }
}
