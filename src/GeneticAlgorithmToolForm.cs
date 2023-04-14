using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Common;
using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace GeneticAlgorithmTool
{
    [ExternalTool("Mario Genetic Algorithm Tool")]
    //[ExternalToolApplicability.RomList(
    //    VSystemID.Raw.NES,
    //    "EA343F4E445A9050D4B4FBAC2C77D0693B1D0922", // U
    //    "AB30029EFEC6CCFC5D65DFDA7FBC6E6489A80805")] // E
    public partial class GeneticAlgorithmToolForm : ToolFormBase, IExternalToolForm, IToolFormAutoConfig
    {
        public static Type Resources => typeof(ToolFormBase).Assembly.GetType("BizHawk.Client.EmuHawk.Properties.Resources");
        private static readonly FilesystemFilterSet BotFilesFSFilterSet = new(new FilesystemFilter("Bot files", new[] { "bot" }));

        private string windowTitle = "Genetic Algorithm Tool";
        private string _prevLevel = "1-1";
        private int? _prevSlot = null;
        private MemoryDomain _currentDomain = default!;
        private bool _bigEndian;
        private int _dataSize;
        private bool _replayMode;
        private bool _isBotting;
        private int _lastFrameAdvanced;
        private long _frames;
        private long _runs;
        private long _generations;
        private bool _oldCountingSetting;
        private bool _doNotUpdateValues;
        private ILogEntryGenerator _logGenerator = default!;
        //public ApiContainer? _maybeAPIContainer { get; set; }
        //private ApiContainer APIs
        //    => _maybeAPIContainer!;

        #region Properties
        private IMovie CurrentMovie => MovieSession.Movie;

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

        //public IList<string> ControllerButtons => Emulator.ControllerDefinition.BoolButtons;
        public IList<string> ControllerButtons => Controller.Definition.BoolButtons;
        #endregion

        protected override string WindowTitle => windowTitle;
        protected override string WindowTitleStatic => windowTitle;

        public GeneticAlgorithmToolForm()
        {
            InitializeComponent();
            //NewMenuItem.Image = GetResourceIcons<Image>("NewFile");
            //OpenMenuItem.Image = GetResourceIcons<Image>("OpenFile");
            //SaveMenuItem.Image = GetResourceIcons<Image>("SaveAs");
            //RecentSubMenu.Image = GetResourceIcons<Image>("Recent");
            //RunBtn.Image = GetResourceIcons<Image>("Play");
            //BotStatusButton.Image = GetResourceIcons<Image>("Placeholder");
            //btnCopyBestInput.Image = GetResourceIcons<Image>("Duplicate");
            //PlayBestButton.Image = GetResourceIcons<Image>("Play");
            //ClearBestButton.Image = GetResourceIcons<Image>("Close");
            //StopBtn.Image = GetResourceIcons<Image>("Stop");
        }

        public static T GetResourceIcons<T>(string iconName)
        {
            FieldInfo fi = Resources.GetField(iconName, BindingFlags.NonPublic | BindingFlags.Static);
            return (T)fi.GetValue(Resources);
        }

        private string ReadLevel()
        {
            //var bytes = ApiContainer.Memory.ReadByteRange(0x075CL, 9);
            //return bytes[8] is 0 or 0xFF
            //    ? _prevLevel // in the main menu
            //    : $"{bytes[3] + 1}-{bytes[0] + 1}";
            return "1";
        }

        public override void Restart()
        {
            _prevLevel = "1-1"; // ReadLevel returns this when in the main menu, need to reset it
            LevelResult.Text = $"You are in World {ReadLevel()}";
            //ApiContainer.EmuClient.StateLoaded += (_, _) => _prevLevel = ReadLevel(); // without this, loading a state would cause UpdateAfter to save a state because the level would be different
        }

        protected override void UpdateAfter()
        {
            var level = ReadLevel();
            if (level == _prevLevel) return; // no change, short-circuit
                                             // else the player has just gone to the next level
            //var nextSlot = ((_prevSlot ?? 0) + 1) % 10;
            //ApiContainer.SaveState.SaveSlot(nextSlot);
            //LevelResult.Text = $"You are in World {level}, load slot {nextSlot} to restart";
            //if (_prevSlot is not null) LevelResult.Text += $" or {_prevSlot} to go back to {_prevLevel}";
            //_prevSlot = nextSlot;
            //_prevLevel = level;
        }

        #region Events
        public void OnBotLoad(object sender, EventArgs eventArgs)
        {
            if (!CurrentMovie.IsActive() && !Tools.IsLoaded<TAStudio>())
            {
                DialogController.ShowMessageBox("In order to proceed to use this tool, TAStudio is required to be opened.");
                this.Close();
                DialogResult = DialogResult.Cancel;
                return;
            }

            Type configType = Config!.GetType();
            // For BizHawk versions > 2.8. (git commit af2d8da36e50a9004d6ecfd456381956b9245d66)
            if (configType.GetProperty("OpposingDirPolicy") != null)
            {
                if (!configType.GetProperty("OpposingDirPolicy").GetValue(Config!).ToString().Contains("Allow"))
                {
                    DialogController.ShowMessageBox("In order to proceed to use this tool, please check if the U+D/L+R controller binds policy is set to 'Allow'.");
                    this.Close();
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            // To be made compatible with BizHawk 2.8.
            else if (configType.GetProperty("AllowUdlr") != null)
            {
                bool allowUldrFlag = (bool)configType.GetProperty("AllowUdlr").GetValue(Config!);
                if (!allowUldrFlag)
                {
                    DialogController.ShowMessageBox("In order to use this tool, 'Allow U+D / L+R' must be checked in the controller menu.");
                    this.Close();
                    DialogResult = DialogResult.Cancel;
                    return;
                }
            }
            // Reject the tool from loading.
            else
            {
                DialogController.ShowMessageBox("Unsupported BizHawk version detected. Please report the issue on TASVideo Forum @ https://tasvideos.org/Forum/Topics/23453");
                this.Close();
                DialogResult = DialogResult.Cancel;
                return;
            }

            if (OSTailoredCode.IsUnixHost)
            {
                ClientSize = new(707, 587);
            }

            //_previousInvisibleEmulation = InvisibleEmulationCheckBox.Checked = Settings.InvisibleEmulation;
            //_previousDisplayMessage = Config.DisplayMessages;
        }
        #endregion
    }
}
