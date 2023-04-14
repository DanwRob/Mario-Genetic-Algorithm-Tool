using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;

namespace GeneticAlgorithmTool
{
    [ExternalTool("Mario Genetic Algorithm Tool")]
    [ExternalToolApplicability.RomList(
        VSystemID.Raw.NES,
        "EA343F4E445A9050D4B4FBAC2C77D0693B1D0922", // U
        "AB30029EFEC6CCFC5D65DFDA7FBC6E6489A80805")] // E
    public partial class GeneticAlgorithmToolForm : ToolFormBase, IExternalToolForm, IToolFormAutoConfig
    {
        public static Type Resources => typeof(ToolFormBase).Assembly.GetType("BizHawk.Client.EmuHawk.Properties.Resources");

        private string windowTitle = "Genetic Algorithm Tool";
        private string prevLevel = "1-1";
        private int? prevSlot = null;

        #region Properties
        [OptionalApi]
        public IEmulationApi? EmulatorApi { get; set; } = default!;
        [RequiredService]
        public IEmulator Emulator { get; set; } = default!;
        [RequiredService]
        public IStatable? StableCore { get; set; } = default!;
        [RequiredService]
        public IMemoryDomains? MemoryDomains { get; set; } = default!;

        public ApiContainer ApiContainer { get; set; } = default!;
        public ClickyVirtualPadController Controller => InputManager.ClickyVirtualPadController;

        public IList<string> ControllerButtons => Emulator.ControllerDefinition.BoolButtons;
        #endregion

        protected override string WindowTitle => windowTitle;
        protected override string WindowTitleStatic => windowTitle;

        public GeneticAlgorithmToolForm()
        {
            InitializeComponent();
        }

        private string ReadLevel()
        {
            var bytes = ApiContainer.Memory.ReadByteRange(0x075CL, 9);
            return bytes[8] is 0 or 0xFF
                ? prevLevel // in the main menu
                : $"{bytes[3] + 1}-{bytes[0] + 1}";
        }

        public override void Restart()
        {
            prevLevel = "1-1"; // ReadLevel returns this when in the main menu, need to reset it
            LevelResult.Text = $"You are in World {ReadLevel()}";
            ApiContainer.EmuClient.StateLoaded += (_, _) => prevLevel = ReadLevel(); // without this, loading a state would cause UpdateAfter to save a state because the level would be different
        }

        protected override void UpdateAfter()
        {
            var level = ReadLevel();
            if (level == prevLevel) return; // no change, short-circuit
                                            // else the player has just gone to the next level
            var nextSlot = ((prevSlot ?? 0) + 1) % 10;
            ApiContainer.SaveState.SaveSlot(nextSlot);
            LevelResult.Text = $"You are in World {level}, load slot {nextSlot} to restart";
            if (prevSlot is not null) LevelResult.Text += $" or {prevSlot} to go back to {prevLevel}";
            prevSlot = nextSlot;
            prevLevel = level;
        }

        #region Events
        public void OnBotLoad(object sender, EventArgs eventArgs)
        {
            
        }
        #endregion
    }
}
