using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.gui
{
	public partial class MasterForm : Form
	{
		public string InputBuffer { get; set; }

		public MasterForm()
		{
			InitializeComponent();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			var page = new TabPage("cmd");
			page.Margin = Padding.Empty;
			page.Padding = Padding.Empty;
			page.BackColor = Color.Black;

			var shell = new ShellView();

			page.Controls.Add(shell);
			shellTabs.TabPages.Add(page);
		}

		private void teststdinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Click OK.", "", MessageBoxButtons.OKCancel);
			if (result == DialogResult.Cancel)
			{
				return;
			}

			string stdin = Console.In.ReadToEnd();
		}

		private void MasterForm_KeyDown(object sender, KeyEventArgs e)
		{
			//TODO: Implement.
		}
	}
}
