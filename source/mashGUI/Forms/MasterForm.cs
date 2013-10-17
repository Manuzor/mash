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
		private Keys _currentKey;
		private int _counter;

		public string InputBuffer { get; set; }

		public MasterForm()
		{
			InitializeComponent();
			_currentKey = Keys.None;
			_counter = 0;
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
			if (_currentKey != e.KeyData)
			{
				_currentKey = e.KeyData;
				_counter = 0;
			}
			globalStatus.Text = string.Format("{0}: {1} ({2})", e.Modifiers, e.KeyData, _counter);
			++_counter;

			e.Handled = true;
		}
	}
}
