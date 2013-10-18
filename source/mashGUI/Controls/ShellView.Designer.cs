namespace mash.gui
{
	partial class ShellView
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.console = new System.Windows.Forms.TextBox();
			this.input = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// console
			// 
			this.console.BackColor = System.Drawing.Color.Black;
			this.console.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.console.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.console.Dock = System.Windows.Forms.DockStyle.Fill;
			this.console.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.console.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.console.Location = new System.Drawing.Point(0, 0);
			this.console.Margin = new System.Windows.Forms.Padding(0);
			this.console.Multiline = true;
			this.console.Name = "console";
			this.console.ReadOnly = true;
			this.console.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.console.Size = new System.Drawing.Size(642, 368);
			this.console.TabIndex = 100;
			this.console.TabStop = false;
			// 
			// input
			// 
			this.input.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.input.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.input.BackColor = System.Drawing.Color.Black;
			this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.input.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.input.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.input.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.input.HideSelection = false;
			this.input.Location = new System.Drawing.Point(0, 368);
			this.input.Margin = new System.Windows.Forms.Padding(0);
			this.input.Name = "input";
			this.input.Size = new System.Drawing.Size(642, 23);
			this.input.TabIndex = 0;
			this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
			// 
			// ShellView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Controls.Add(this.console);
			this.Controls.Add(this.input);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ShellView";
			this.Size = new System.Drawing.Size(642, 391);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox console;
		private System.Windows.Forms.TextBox input;
	}
}
