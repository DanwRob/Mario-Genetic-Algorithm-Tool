using BizHawk.Client.Common;
using BizHawk.Client.EmuHawk;
using BizHawk.Emulation.Common;
using GeneticAlgorithmTool.Models;
using System;

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
        private JoypadSpace joypad;
        private GeneticAlgorithm geneticAlgorithm;
        private Species currerntSpecie;
        private readonly int slot = 8;
        private bool running = false;
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
            GameActionInput.SelectedIndex = 0;
            joypad = new JoypadSpace(GameActions.RightOnly);
            geneticAlgorithm = new GeneticAlgorithm(100, 6, joypad);
            currerntSpecie = geneticAlgorithm.NextSpecie();
        }

        public override void Restart()
        {
            if (!running)
            {
                MainForm.PauseEmulator();
                return;
            }
            environment = new GameEnvironment(Emulator, ApiContainer, InputManager.ClickyVirtualPadController);
            environment.SkipStartScreen();
            ApiContainer.SaveState.SaveSlot(slot);
            GenerationResult.Text = geneticAlgorithm.Generation.ToString();
        }

        protected override void UpdateBefore()
        {
            if (!running)
            {
                return;
            }

            if (geneticAlgorithm.TotalGenerations < geneticAlgorithm.Generation)
            {
                StopBtn.PerformClick();
            }

            if (currerntSpecie.IsGenDone())
            {
                var frameAction = joypad.GetFrameActionSample();
                currerntSpecie.Genes.Add(frameAction);
            }
        }

        protected override void UpdateAfter()
        {
            if (!running)
            {
                return;
            }

            var currentFrameAction = currerntSpecie.GetCurrentGen();

            var step = environment.Step(currentFrameAction.Actions);
            geneticAlgorithm.FitnessFunction(currerntSpecie, step);

            currentFrameAction.AdvanceFrame();
            UpdateUI(step,currentFrameAction);

            if (step != null && step.Done)
            {
                currerntSpecie.RemoveLastCorruptGenes();
                currerntSpecie = geneticAlgorithm.NextSpecie();
                GenerationResult.Text = geneticAlgorithm.Generation.ToString();
                ApiContainer.SaveState.LoadSlot(slot);
            }
        }

        private void UpdateUI(StepResponse step, FrameAction action)
        {
            LevelResult.Text = $"{step.Info.Level}";
            WorldResult.Text = $"{step.Info.World}";
            PositionXResult.Text = $"{step.Info.XPosition}";
            PositionYResult.Text = $"{step.Info.YPosition}";

            ConsoleLog.AppendText($"{currerntSpecie} Action:{string.Join("", action.Actions)}\r\n");
        }

        #region Events
        public void OnBotLoad(object sender, EventArgs eventArgs)
        {
            
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            int population = (int)PopulationInput.Value;
            int generations = (int)GenerationInput.Value;
            int gameActions = GameActionInput.SelectedIndex;
            EnableConfigurationControls(false);
            joypad = new JoypadSpace(GameActions.SelectActions(gameActions));
            geneticAlgorithm = new GeneticAlgorithm(generations, population, joypad);
            currerntSpecie = geneticAlgorithm.NextSpecie();
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            ConsoleLog.Text = "";
            running = true;
            MainForm.UnpauseEmulator();
            Restart();
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            EnableConfigurationControls(true);
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            running = false;
            ApiContainer.SaveState.LoadSlot(slot);
            MainForm.PauseEmulator();
        }
        #endregion

        private void EnableConfigurationControls(bool enable)
        {
            PopulationInput.Enabled = enable;
            GenerationInput.Enabled = enable;
            GameActionInput.Enabled = enable;
        }
    }
}
