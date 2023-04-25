namespace GeneticAlgorithmTool
{
    partial class GeneticAlgorithmToolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MutationRateInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.GameActionInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerationInput = new System.Windows.Forms.NumericUpDown();
            this.GenerationsInputLabel = new System.Windows.Forms.Label();
            this.PopulationInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.BestRewardResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerationResult = new System.Windows.Forms.Label();
            this.GenerationResultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsoleLog = new System.Windows.Forms.TextBox();
            this.LevelResult = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PositionYResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionXResult = new System.Windows.Forms.Label();
            this.WorldResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedToggle = new GeneticAlgorithmTool.Controls.ToggleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationRateInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SpeedToggle);
            this.groupBox1.Controls.Add(this.MutationRateInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.GameActionInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GenerationInput);
            this.groupBox1.Controls.Add(this.GenerationsInputLabel);
            this.groupBox1.Controls.Add(this.PopulationInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Max Speed";
            // 
            // MutationRateInput
            // 
            this.MutationRateInput.DecimalPlaces = 1;
            this.MutationRateInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MutationRateInput.Location = new System.Drawing.Point(388, 26);
            this.MutationRateInput.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MutationRateInput.Name = "MutationRateInput";
            this.MutationRateInput.Size = new System.Drawing.Size(57, 20);
            this.MutationRateInput.TabIndex = 7;
            this.MutationRateInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mutation Rate:";
            // 
            // GameActionInput
            // 
            this.GameActionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameActionInput.FormattingEnabled = true;
            this.GameActionInput.Items.AddRange(new object[] {
            "Right Only",
            "Simple Movement",
            "Complex Movement"});
            this.GameActionInput.Location = new System.Drawing.Point(74, 70);
            this.GameActionInput.Name = "GameActionInput";
            this.GameActionInput.Size = new System.Drawing.Size(124, 21);
            this.GameActionInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Game Action:";
            // 
            // GenerationInput
            // 
            this.GenerationInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.GenerationInput.Location = new System.Drawing.Point(74, 26);
            this.GenerationInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.GenerationInput.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.GenerationInput.Name = "GenerationInput";
            this.GenerationInput.Size = new System.Drawing.Size(57, 20);
            this.GenerationInput.TabIndex = 3;
            this.GenerationInput.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // GenerationsInputLabel
            // 
            this.GenerationsInputLabel.AutoSize = true;
            this.GenerationsInputLabel.Location = new System.Drawing.Point(4, 29);
            this.GenerationsInputLabel.Name = "GenerationsInputLabel";
            this.GenerationsInputLabel.Size = new System.Drawing.Size(67, 13);
            this.GenerationsInputLabel.TabIndex = 2;
            this.GenerationsInputLabel.Text = "Generations:";
            // 
            // PopulationInput
            // 
            this.PopulationInput.Location = new System.Drawing.Point(223, 26);
            this.PopulationInput.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.PopulationInput.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PopulationInput.Name = "PopulationInput";
            this.PopulationInput.Size = new System.Drawing.Size(57, 20);
            this.PopulationInput.TabIndex = 1;
            this.PopulationInput.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Population:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PauseBtn);
            this.groupBox2.Controls.Add(this.StopBtn);
            this.groupBox2.Controls.Add(this.StartBtn);
            this.groupBox2.Controls.Add(this.BestRewardResult);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GenerationResult);
            this.groupBox2.Controls.Add(this.GenerationResultLabel);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(14, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // PauseBtn
            // 
            this.PauseBtn.Enabled = false;
            this.PauseBtn.Location = new System.Drawing.Point(301, 19);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(75, 23);
            this.PauseBtn.TabIndex = 9;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(220, 19);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(382, 19);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // BestRewardResult
            // 
            this.BestRewardResult.AutoSize = true;
            this.BestRewardResult.Location = new System.Drawing.Point(155, 23);
            this.BestRewardResult.Name = "BestRewardResult";
            this.BestRewardResult.Size = new System.Drawing.Size(13, 13);
            this.BestRewardResult.TabIndex = 6;
            this.BestRewardResult.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best Reward:";
            // 
            // GenerationResult
            // 
            this.GenerationResult.AutoSize = true;
            this.GenerationResult.Location = new System.Drawing.Point(68, 24);
            this.GenerationResult.Name = "GenerationResult";
            this.GenerationResult.Size = new System.Drawing.Size(13, 13);
            this.GenerationResult.TabIndex = 2;
            this.GenerationResult.Text = "0";
            // 
            // GenerationResultLabel
            // 
            this.GenerationResultLabel.AutoSize = true;
            this.GenerationResultLabel.Location = new System.Drawing.Point(4, 23);
            this.GenerationResultLabel.Name = "GenerationResultLabel";
            this.GenerationResultLabel.Size = new System.Drawing.Size(67, 13);
            this.GenerationResultLabel.TabIndex = 1;
            this.GenerationResultLabel.Text = "Generations:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ConsoleLog);
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 227);
            this.panel1.TabIndex = 0;
            // 
            // ConsoleLog
            // 
            this.ConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleLog.Location = new System.Drawing.Point(0, 0);
            this.ConsoleLog.Multiline = true;
            this.ConsoleLog.Name = "ConsoleLog";
            this.ConsoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleLog.Size = new System.Drawing.Size(446, 223);
            this.ConsoleLog.TabIndex = 0;
            // 
            // LevelResult
            // 
            this.LevelResult.AutoSize = true;
            this.LevelResult.Location = new System.Drawing.Point(40, 28);
            this.LevelResult.Name = "LevelResult";
            this.LevelResult.Size = new System.Drawing.Size(13, 13);
            this.LevelResult.TabIndex = 4;
            this.LevelResult.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(6, 28);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(36, 13);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Level:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PositionYResult);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.PositionXResult);
            this.groupBox3.Controls.Add(this.WorldResult);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LevelLabel);
            this.groupBox3.Controls.Add(this.LevelResult);
            this.groupBox3.Location = new System.Drawing.Point(14, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 62);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Information";
            // 
            // PositionYResult
            // 
            this.PositionYResult.AutoSize = true;
            this.PositionYResult.Location = new System.Drawing.Point(306, 28);
            this.PositionYResult.Name = "PositionYResult";
            this.PositionYResult.Size = new System.Drawing.Size(13, 13);
            this.PositionYResult.TabIndex = 10;
            this.PositionYResult.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position Y:";
            // 
            // PositionXResult
            // 
            this.PositionXResult.AutoSize = true;
            this.PositionXResult.Location = new System.Drawing.Point(209, 28);
            this.PositionXResult.Name = "PositionXResult";
            this.PositionXResult.Size = new System.Drawing.Size(13, 13);
            this.PositionXResult.TabIndex = 8;
            this.PositionXResult.Text = "0";
            // 
            // WorldResult
            // 
            this.WorldResult.AutoSize = true;
            this.WorldResult.Location = new System.Drawing.Point(114, 28);
            this.WorldResult.Name = "WorldResult";
            this.WorldResult.Size = new System.Drawing.Size(13, 13);
            this.WorldResult.TabIndex = 7;
            this.WorldResult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Position X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "World:";
            // 
            // SpeedToggle
            // 
            this.SpeedToggle.AutoSize = true;
            this.SpeedToggle.Location = new System.Drawing.Point(400, 74);
            this.SpeedToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.SpeedToggle.Name = "SpeedToggle";
            this.SpeedToggle.OffBackColor = System.Drawing.Color.Gray;
            this.SpeedToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.SpeedToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.SpeedToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.SpeedToggle.Size = new System.Drawing.Size(45, 22);
            this.SpeedToggle.TabIndex = 8;
            this.SpeedToggle.UseVisualStyleBackColor = true;
            // 
            // GeneticAlgorithmToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 490);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneticAlgorithmToolForm";
            this.Load += new System.EventHandler(this.OnBotLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MutationRateInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GenerationResultLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ConsoleLog;
        private System.Windows.Forms.Label GenerationsInputLabel;
        private System.Windows.Forms.NumericUpDown PopulationInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GenerationInput;
        private System.Windows.Forms.Label LevelResult;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label GenerationResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BestRewardResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PositionYResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PositionXResult;
        private System.Windows.Forms.Label WorldResult;
        private System.Windows.Forms.ComboBox GameActionInput;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.NumericUpDown MutationRateInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Controls.ToggleButton SpeedToggle;
    }
}