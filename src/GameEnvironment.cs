using BizHawk.Client.Common;
using BizHawk.Emulation.Common;
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
        private StepInformation gameInformation = new ();


        public GameEnvironment(IEmulator emulator, ApiContainer apiContainer, ClickyVirtualPadController controller)
        {
            this.emulator = emulator;
            this.apiContainer = apiContainer;
            this.controller = controller;
            memoryHandler = new GameMemoryHandler(apiContainer.Memory);
            //memoryHandler.SetGameplayMode(GameMemoryHandler.GameplayMode.Standard);
            buttons = emulator.ControllerDefinition.BoolButtons;
        }

        public void SkipStarScreen()
        {
            controller.Toggle(buttons[(int)JoypadSpace.Buttons.Start]);
            memoryHandler.PrelevelTimer();
            //controller.Toggle(buttons[(int)JoypadSpace.Buttons.Start]);
        }

        public StepInformation Step(JoypadSpace.Buttons action)
        {
            controller.Toggle(buttons[(int)action]);
            //controller.Toggle(buttons[(int)action]);
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
