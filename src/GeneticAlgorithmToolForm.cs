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

        public override void Restart()
        {
            environment = new GameEnvironment(Emulator, ApiContainer, InputManager.ClickyVirtualPadController);
            environment.SkipStartScreen();
        }

        protected override void UpdateBefore()
        {
            if (frameStack.Count() == 0 || frameStack.Last().IsFinishAction())
            {
                var actions = joypad.GetSample();
                int framesByAction = Utils.RandRange(1, 5, 5);
                frameStack.Add(new FramesStack(framesByAction, actions));
            }
        }

        protected override void UpdateAfter()
        {
            var lastFrameAction = frameStack.Last();
            var step = environment?.Step(lastFrameAction.Actions);
            lastFrameAction.AdvanceFrame();
            ConsoleLog.AppendText(step?.ToString());
            LevelResult.Text = $"You are in World {step?.Info?.World} - {step?.Info?.Level}";
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
