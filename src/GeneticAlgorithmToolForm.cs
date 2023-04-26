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
    public partial class GeneticAlgorithmToolForm : ToolFormBase, IExternalToolForm
    {
        private GameEnvironment environment;
        private string windowTitle = "Genetic Algorithm Tool";
        private JoypadSpace joypad;
        private GeneticAlgorithm geneticAlgorithm;
        private Species currentSpecie;
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
            geneticAlgorithm = new GeneticAlgorithm(100, 6, 0.3,joypad);
            currentSpecie = geneticAlgorithm.NextSpecie();
        }

        public override void Restart()
        {
            environment = new GameEnvironment(Emulator, ApiContainer, InputManager.ClickyVirtualPadController);
            environment.SkipStartScreen();
            
            MainForm.PauseEmulator();
            GenerationResult.Text = geneticAlgorithm.Generation.ToString();
        }

        protected override void UpdateBefore() => UpdateBeforeFrame();

        protected override void FastUpdateBefore() => UpdateBeforeFrame();
        
        private void UpdateBeforeFrame()
        {
            if (!running)
            {
                return;
            }

            if (geneticAlgorithm.TotalGenerations < geneticAlgorithm.Generation)
            {
                StopBtn.PerformClick();
            }

            if (currentSpecie.IsGenDone())
            {
                var frameAction = joypad.GetFrameActionSample();
                currentSpecie.Genes.Add(frameAction);
            }
        }

        protected override void UpdateAfter() => UpdateFrame();
        protected override void FastUpdateAfter() => UpdateFrame();

        private void UpdateFrame()
        {
            if (!running)
            {
                return;
            }

            var currentFrameAction = currentSpecie.GetCurrentGen();

            var step = environment.Step(currentFrameAction.Actions);
            geneticAlgorithm.FitnessFunction(currentSpecie, step);

            currentFrameAction.AdvanceFrame();
            UpdateUI(step,currentFrameAction);
            currentSpecie.IsSpecieStuck();

            if (currentSpecie.Done)
            {
                currentSpecie.RemoveLastCorruptGenes();
                currentSpecie = geneticAlgorithm.NextSpecie();
                GenerationResult.Text = geneticAlgorithm.Generation.ToString();
                ApiContainer.SaveState.LoadSlot(slot);
            }
        }

        private void UpdateUI(StepResponse step, FrameAction action)
        {
            if (!action.IsFinishAction()) {
                return;
            }
            LevelResult.Text = $"{step.Info.Level}";
            WorldResult.Text = $"{step.Info.World}";
            PositionXResult.Text = $"{action.XPosition}";
            PositionYResult.Text = $"{action.YPosition}";
            BestRewardResult.Text = $"{geneticAlgorithm.BestReward}";

            ConsoleLog.AppendText($"{currentSpecie}  Action: [{string.Join("", action.Actions)}]  Pressed: {action.TotalFrames} frames\r\n");
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
            double mutationRate = (double)MutationRateInput.Value;
            EnableConfigurationControls(false);
            joypad = new JoypadSpace(GameActions.SelectActions(gameActions));
            geneticAlgorithm = new GeneticAlgorithm(generations, population, mutationRate, joypad);
            currentSpecie = geneticAlgorithm.NextSpecie();
            ToggleInitButton(true);
            ConsoleLog.Text = "";
            running = true;
            SetSpeed();
            MainForm.UnpauseEmulator();
            
            ApiContainer.SaveState.SaveSlot(slot);
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            EnableConfigurationControls(true);
            ToggleInitButton(false);
            running = false;
            ApiContainer.SaveState.LoadSlot(slot);
            MainForm.PauseEmulator();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            if (running)
            {
                MainForm.PauseEmulator();
            }
            else
            {
                MainForm.UnpauseEmulator();
            }
            running = !running;
            PauseBtn.Text = running ? "Pause" : "Continue";
        }
        #endregion

        private void EnableConfigurationControls(bool enable)
        {
            PopulationInput.Enabled = enable;
            GenerationInput.Enabled = enable;
            GameActionInput.Enabled = enable;
            MutationRateInput.Enabled = enable;
            SpeedToggle.Enabled = enable;
        }

        private void ToggleInitButton(bool click)
        {
            StartBtn.Enabled = !click;
            StopBtn.Enabled = click;
            PauseBtn.Enabled = click;
            PauseBtn.Text = "Pause";
        }

        private void SetSpeed()
        {
            if (SpeedToggle.Checked)
            {
                MainForm.Unthrottle();
            }
            else
            {
                MainForm.Throttle();
            }
        }

        private void GeneticAlgorithmToolForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            MainForm.Throttle();
        }
    }
}
