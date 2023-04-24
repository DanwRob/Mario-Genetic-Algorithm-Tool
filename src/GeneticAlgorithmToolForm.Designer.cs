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
            this.GameActionInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerationInput = new System.Windows.Forms.NumericUpDown();
            this.GenerationsInputLabel = new System.Windows.Forms.Label();
            this.PopulationInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.BotMenu = new BizHawk.WinForms.Controls.MenuStripEx();
            this.FileSubMenu = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.NewMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.OpenMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.SaveMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.SaveAsMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.RecentSubMenu = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.toolStripSeparator2 = new BizHawk.WinForms.Controls.ToolStripSeparatorEx();
            this.OptionsSubMenu = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.MemoryDomainsMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.toolStripSeparator3 = new BizHawk.WinForms.Controls.ToolStripSeparatorEx();
            this.DataSizeMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this._1ByteMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this._2ByteMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this._4ByteMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.BigEndianMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.toolStripSeparator4 = new BizHawk.WinForms.Controls.ToolStripSeparatorEx();
            this.TurboWhileBottingMenuItem = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.SettingsSubMenu = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.HelpSubMenu = new BizHawk.WinForms.Controls.ToolStripMenuItemEx();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PositionYResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PositionXResult = new System.Windows.Forms.Label();
            this.WorldResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BotMenu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GameActionInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GenerationInput);
            this.groupBox1.Controls.Add(this.GenerationsInputLabel);
            this.groupBox1.Controls.Add(this.PopulationInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // GameActionInput
            // 
            this.GameActionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GameActionInput.FormattingEnabled = true;
            this.GameActionInput.Items.AddRange(new object[] {
            "Right",
            "Simple",
            "Complex"});
            this.GameActionInput.Location = new System.Drawing.Point(370, 24);
            this.GameActionInput.Name = "GameActionInput";
            this.GameActionInput.Size = new System.Drawing.Size(84, 21);
            this.GameActionInput.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 28);
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
            this.PopulationInput.Location = new System.Drawing.Point(217, 26);
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
            this.label1.Location = new System.Drawing.Point(154, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Population:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StopBtn);
            this.groupBox2.Controls.Add(this.StartBtn);
            this.groupBox2.Controls.Add(this.BestRewardResult);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.GenerationResult);
            this.groupBox2.Controls.Add(this.GenerationResultLabel);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(285, 19);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(75, 23);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(374, 19);
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
            this.BestRewardResult.Location = new System.Drawing.Point(184, 29);
            this.BestRewardResult.Name = "BestRewardResult";
            this.BestRewardResult.Size = new System.Drawing.Size(13, 13);
            this.BestRewardResult.TabIndex = 6;
            this.BestRewardResult.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best Reward:";
            // 
            // GenerationResult
            // 
            this.GenerationResult.AutoSize = true;
            this.GenerationResult.Location = new System.Drawing.Point(75, 29);
            this.GenerationResult.Name = "GenerationResult";
            this.GenerationResult.Size = new System.Drawing.Size(13, 13);
            this.GenerationResult.TabIndex = 2;
            this.GenerationResult.Text = "0";
            // 
            // GenerationResultLabel
            // 
            this.GenerationResultLabel.AutoSize = true;
            this.GenerationResultLabel.Location = new System.Drawing.Point(4, 29);
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
            // BotMenu
            // 
            this.BotMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSubMenu,
            this.OptionsSubMenu,
            this.SettingsSubMenu,
            this.HelpSubMenu});
            this.BotMenu.TabIndex = 2;
            // 
            // FileSubMenu
            // 
            this.FileSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.RecentSubMenu});
            this.FileSubMenu.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Text = "&New";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Text = "&Open...";
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Text = "&Save";
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsMenuItem.Text = "Save &As...";
            // 
            // RecentSubMenu
            // 
            this.RecentSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
            this.RecentSubMenu.Text = "Recent";
            // 
            // OptionsSubMenu
            // 
            this.OptionsSubMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MemoryDomainsMenuItem,
            this.DataSizeMenuItem,
            this.BigEndianMenuItem,
            this.toolStripSeparator4,
            this.TurboWhileBottingMenuItem});
            this.OptionsSubMenu.Text = "&Options";
            // 
            // MemoryDomainsMenuItem
            // 
            this.MemoryDomainsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            this.MemoryDomainsMenuItem.Text = "Memory Domains";
            // 
            // DataSizeMenuItem
            // 
            this.DataSizeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._1ByteMenuItem,
            this._2ByteMenuItem,
            this._4ByteMenuItem});
            this.DataSizeMenuItem.Text = "Data Size";
            // 
            // _1ByteMenuItem
            // 
            this._1ByteMenuItem.Text = "1 Byte";
            // 
            // _2ByteMenuItem
            // 
            this._2ByteMenuItem.Text = "2 Bytes";
            // 
            // _4ByteMenuItem
            // 
            this._4ByteMenuItem.Text = "4 Bytes";
            // 
            // BigEndianMenuItem
            // 
            this.BigEndianMenuItem.Text = "Big Endian";
            // 
            // TurboWhileBottingMenuItem
            // 
            this.TurboWhileBottingMenuItem.Text = "Turbo While Botting";
            // 
            // SettingsSubMenu
            // 
            this.SettingsSubMenu.Text = "Settings";
            // 
            // HelpSubMenu
            // 
            this.HelpSubMenu.Text = "Help";
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
            // GeneticAlgorithmToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 493);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BotMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneticAlgorithmToolForm";
            this.Load += new System.EventHandler(this.OnBotLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BotMenu.ResumeLayout(false);
            this.BotMenu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public BizHawk.WinForms.Controls.MenuStripEx BotMenu;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx FileSubMenu;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx NewMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx OpenMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx SaveMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx SaveAsMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx RecentSubMenu;
        public BizHawk.WinForms.Controls.ToolStripSeparatorEx toolStripSeparator2;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx OptionsSubMenu;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx MemoryDomainsMenuItem;
        public BizHawk.WinForms.Controls.ToolStripSeparatorEx toolStripSeparator3;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx DataSizeMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx _1ByteMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx _2ByteMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx _4ByteMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx BigEndianMenuItem;
        public BizHawk.WinForms.Controls.ToolStripSeparatorEx toolStripSeparator4;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx TurboWhileBottingMenuItem;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx SettingsSubMenu;
        public BizHawk.WinForms.Controls.ToolStripMenuItemEx HelpSubMenu;
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
    }
}