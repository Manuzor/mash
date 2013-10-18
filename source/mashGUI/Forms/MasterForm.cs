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
		private char _currentKey;
		private bool _characterKey;

		public string InputBuffer { get; set; }

		public MasterForm()
		{
			InitializeComponent();
			_currentKey = '\0';
			_characterKey = false;
		}

		private TabPage addShell(string name)
		{
			var page = new TabPage(name);
			page.Margin = Padding.Empty;
			page.Padding = Padding.Empty;
			page.BackColor = Color.Black;

			var shell = new ShellView();

			page.Controls.Add(shell);
			shellTabs.TabPages.Add(page);
			return page;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			shellTabs.SelectedTab = addShell("cmd");
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
			// Raised by all keyboard keys

			if (_characterKey && (char)e.KeyValue == _currentKey)
			{
				globalStatus.Text = string.Format("{0}", _currentKey);
			}
		}

		private void MasterForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Only raised by character-keys (keys that have a proper string representation)

			_characterKey = true;
			_currentKey = e.KeyChar;

			e.Handled = true;
		}
	}
}
