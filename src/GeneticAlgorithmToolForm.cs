using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;
using System.Linq;

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
        private GameEnvironment? environment;
        private string windowTitle = "Genetic Algorithm Tool";
        private string prevLevel = "1-1";
        private int? prevSlot = null;
        private readonly JoypadSpace joypad;
        private readonly List<FramesStack> frameStack;

        #region Properties
        [RequiredService]
        public IEmulator Emulator { get; set; } = default!;
        [RequiredService]
        public IStatable? StableCore { get; set; } = default!;
        [RequiredService]
        public IMemoryDomains? MemoryDomains { get; set; } = default!;

        public ApiContainer ApiContainer { get; set; } = default!;
        #endregion

        protected override string WindowTitle => windowTitle;
        protected override string WindowTitleStatic => windowTitle;

        public GeneticAlgorithmToolForm()
        {
            InitializeComponent();
            joypad = new JoypadSpace(GameActions.RightOnly);
            frameStack = new List<FramesStack>();
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

            environment = new GameEnvironment(Emulator, ApiContainer, InputManager.ClickyVirtualPadController);
            environment.SkipStartScreen();
        }

        protected override void UpdateBefore()
        {
            if (frameStack.Count() == 0 || frameStack.Last().IsFinishAction())
            {
                var actions = joypad.GetSample();
                var random = new Random();
                int framesByAction = random.Next(1, 4) * 5;
                frameStack.Add(new FramesStack(framesByAction, actions));
            }
        }

        protected override void UpdateAfter()
        {
            var level = ReadLevel();
            var lastFrameAction = frameStack.Last();
            var step = environment?.Step(lastFrameAction.Actions);
            lastFrameAction.AdvanceFrame();
            ConsoleLog.AppendText(step?.ToString());


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

    public class FramesStack
    {
        private int frameCount = 1;
        public FramesStack(int totalFrames, IEnumerable<Buttons> actions)
        {
            TotalFrames = totalFrames;
            Actions = actions;
        }

        public void AdvanceFrame() => frameCount++; 

        public bool IsFinishAction() => frameCount >= TotalFrames;

        public int TotalFrames { get; }
        public IEnumerable<Buttons> Actions { get; }

    }
}
