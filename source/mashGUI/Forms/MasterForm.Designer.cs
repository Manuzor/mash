namespace mash.gui
{
	partial class MasterForm
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
			System.Windows.Forms.MenuStrip mainMenuStrip;
			System.Windows.Forms.StatusStrip globalStatusBar;
			System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teststdinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.globalStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.globalProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.shellBar = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.shellTabs = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			mainMenuStrip = new System.Windows.Forms.MenuStrip();
			globalStatusBar = new System.Windows.Forms.StatusStrip();
			toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			mainMenuStrip.SuspendLayout();
			globalStatusBar.SuspendLayout();
			this.shellBar.SuspendLayout();
			this.shellTabs.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenuStrip
			// 
			mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teststdinToolStripMenuItem});
			mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			mainMenuStrip.Name = "mainMenuStrip";
			mainMenuStrip.Size = new System.Drawing.Size(670, 24);
			mainMenuStrip.TabIndex = 0;
			mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// teststdinToolStripMenuItem
			// 
			this.teststdinToolStripMenuItem.Name = "teststdinToolStripMenuItem";
			this.teststdinToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.teststdinToolStripMenuItem.Text = "test_stdin";
			this.teststdinToolStripMenuItem.Click += new System.EventHandler(this.teststdinToolStripMenuItem_Click);
			// 
			// globalStatusBar
			// 
			globalStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.globalStatus,
            toolStripStatusLabel1,
            this.globalProgressBar});
			globalStatusBar.Location = new System.Drawing.Point(0, 379);
			globalStatusBar.Name = "globalStatusBar";
			globalStatusBar.Size = new System.Drawing.Size(670, 23);
			globalStatusBar.TabIndex = 1;
			globalStatusBar.Text = "Ready.";
			// 
			// globalStatus
			// 
			this.globalStatus.Name = "globalStatus";
			this.globalStatus.Size = new System.Drawing.Size(42, 18);
			this.globalStatus.Text = global::mash.gui.Properties.Settings.Default.GlobalStatusLine;
			// 
			// toolStripStatusLabel1
			// 
			toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			toolStripStatusLabel1.Size = new System.Drawing.Size(493, 18);
			toolStripStatusLabel1.Spring = true;
			// 
			// globalProgressBar
			// 
			this.globalProgressBar.Name = "globalProgressBar";
			this.globalProgressBar.Size = new System.Drawing.Size(118, 17);
			this.globalProgressBar.Value = global::mash.gui.Properties.Settings.Default.StatusProgress;
			// 
			// shellBar
			// 
			this.shellBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
			this.shellBar.Location = new System.Drawing.Point(0, 24);
			this.shellBar.Name = "shellBar";
			this.shellBar.Size = new System.Drawing.Size(670, 25);
			this.shellBar.TabIndex = 2;
			this.shellBar.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(31, 22);
			this.toolStripButton1.Text = "add";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// shellTabs
			// 
			this.shellTabs.Controls.Add(this.tabPage1);
			this.shellTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shellTabs.Location = new System.Drawing.Point(0, 49);
			this.shellTabs.Margin = new System.Windows.Forms.Padding(0);
			this.shellTabs.Name = "shellTabs";
			this.shellTabs.SelectedIndex = 0;
			this.shellTabs.Size = new System.Drawing.Size(670, 330);
			this.shellTabs.TabIndex = 3;
			this.shellTabs.TabStop = false;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Black;
			this.tabPage1.ForeColor = System.Drawing.Color.White;
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(662, 304);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// MasterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 402);
			this.Controls.Add(this.shellTabs);
			this.Controls.Add(this.shellBar);
			this.Controls.Add(globalStatusBar);
			this.Controls.Add(mainMenuStrip);
			this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::mash.gui.Properties.Settings.Default, "MasterFormTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.KeyPreview = true;
			this.MainMenuStrip = mainMenuStrip;
			this.Name = "MasterForm";
			this.Text = global::mash.gui.Properties.Settings.Default.MasterFormTitle;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterForm_KeyDown);
			mainMenuStrip.ResumeLayout(false);
			mainMenuStrip.PerformLayout();
			globalStatusBar.ResumeLayout(false);
			globalStatusBar.PerformLayout();
			this.shellBar.ResumeLayout(false);
			this.shellBar.PerformLayout();
			this.shellTabs.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip shellBar;
		private System.Windows.Forms.TabControl shellTabs;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripProgressBar globalProgressBar;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ToolStripMenuItem teststdinToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel globalStatus;
	}
}