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
            this.GenerationInput = new System.Windows.Forms.NumericUpDown();
            this.GenerationsInputLabel = new System.Windows.Forms.Label();
            this.PopulationInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LevelResult = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.GenerationResult = new System.Windows.Forms.Label();
            this.GenerationResultLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConsoleLog = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenerationInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BotMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenerationInput);
            this.groupBox1.Controls.Add(this.GenerationsInputLabel);
            this.groupBox1.Controls.Add(this.PopulationInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // GenerationInput
            // 
            this.GenerationInput.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.GenerationInput.Location = new System.Drawing.Point(79, 65);
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
            this.GenerationInput.Size = new System.Drawing.Size(60, 20);
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
            this.GenerationsInputLabel.Location = new System.Drawing.Point(6, 67);
            this.GenerationsInputLabel.Name = "GenerationsInputLabel";
            this.GenerationsInputLabel.Size = new System.Drawing.Size(67, 13);
            this.GenerationsInputLabel.TabIndex = 2;
            this.GenerationsInputLabel.Text = "Generations:";
            // 
            // PopulationInput
            // 
            this.PopulationInput.Location = new System.Drawing.Point(80, 26);
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
            this.PopulationInput.Size = new System.Drawing.Size(60, 20);
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
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Population:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LevelResult);
            this.groupBox2.Controls.Add(this.LevelLabel);
            this.groupBox2.Controls.Add(this.GenerationResult);
            this.groupBox2.Controls.Add(this.GenerationResultLabel);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // LevelResult
            // 
            this.LevelResult.AutoSize = true;
            this.LevelResult.Location = new System.Drawing.Point(186, 29);
            this.LevelResult.Name = "LevelResult";
            this.LevelResult.Size = new System.Drawing.Size(13, 13);
            this.LevelResult.TabIndex = 4;
            this.LevelResult.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(143, 29);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(36, 13);
            this.LevelLabel.TabIndex = 3;
            this.LevelLabel.Text = "Level:";
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
            this.GenerationResultLabel.Location = new System.Drawing.Point(6, 29);
            this.GenerationResultLabel.Name = "GenerationResultLabel";
            this.GenerationResultLabel.Size = new System.Drawing.Size(67, 13);
            this.GenerationResultLabel.TabIndex = 1;
            this.GenerationResultLabel.Text = "Generations:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ConsoleLog);
            this.panel1.Location = new System.Drawing.Point(7, 63);
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
            this.ConsoleLog.Size = new System.Drawing.Size(446, 223);
            this.ConsoleLog.TabIndex = 0;
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
            // GeneticAlgorithmToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 493);
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
    }
}