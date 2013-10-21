namespace mash.gui.Forms
{
	partial class LogWindow
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
			this.logTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// logTextBox
			// 
			this.logTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::mash.gui.Properties.Settings.Default, "GlobalLog", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logTextBox.Location = new System.Drawing.Point(0, 0);
			this.logTextBox.Multiline = true;
			this.logTextBox.Name = "logTextBox";
			this.logTextBox.ReadOnly = true;
			this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.logTextBox.Size = new System.Drawing.Size(453, 353);
			this.logTextBox.TabIndex = 0;
			this.logTextBox.Text = global::mash.gui.Properties.Settings.Default.GlobalLog;
			// 
			// LogWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 353);
			this.Controls.Add(this.logTextBox);
			this.Name = "LogWindow";
			this.Text = "Log";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox logTextBox;
	}
}