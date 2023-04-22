using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;
using System;
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
        private GameEnvironment environment;
        private string windowTitle = "Genetic Algorithm Tool";
        private readonly JoypadSpace joypad;
        private readonly GeneticAlgorithm geneticAlgorithm;
        private Species currerntSpecie;
        private readonly int slot = 8;

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
            geneticAlgorithm = new GeneticAlgorithm(100, 6, joypad);
            currerntSpecie = geneticAlgorithm.NextSpecie();
        }

        public override void Restart()
        {
            environment = new GameEnvironment(Emulator, ApiContainer, InputManager.ClickyVirtualPadController);
            environment.SkipStartScreen();
            ApiContainer.SaveState.SaveSlot(slot);
            GenerationResult.Text = geneticAlgorithm.Generation.ToString();
        }

        protected override void UpdateBefore()
        {
            if (currerntSpecie.IsGenDone())
            {
                var frameAction = joypad.GetFrameActionSample();
                currerntSpecie.Genes.Add(frameAction);
            }
        }

        protected override void UpdateAfter()
        {
            var currentFrameAction = currerntSpecie.GetCurrentGen();
            var step = environment.Step(currentFrameAction.Actions);
            currentFrameAction.AdvanceFrame();
            geneticAlgorithm.FitnessFunction(step.Reward, currerntSpecie);
            currerntSpecie.Done = step.Done;
            currerntSpecie.Info = step.Info;

            ConsoleLog.AppendText($"{currerntSpecie}\r\n");
            //ConsoleLog.AppendText(step?.ToString());
            LevelResult.Text = $"You are in World {step?.Info?.World} - {step?.Info?.Level}";
            
            if (step != null && step.Done)
            {
                currerntSpecie.Genes.Remove(currentFrameAction);
                currerntSpecie = geneticAlgorithm.NextSpecie();
                GenerationResult.Text = geneticAlgorithm.Generation.ToString();
                ApiContainer.SaveState.LoadSlot(slot);
            }
        }

        #region Events
        public void OnBotLoad(object sender, EventArgs eventArgs)
        {
            
        }
        #endregion
    }
}
