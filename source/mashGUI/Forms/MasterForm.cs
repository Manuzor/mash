using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace mash.Gui
{
	public partial class MasterForm : Form
	{
		private char _currentKey;
		private bool _characterKey;

		public string InputBuffer { get; set; }

		public ShellView ActiveShellView
		{
			get
			{
				var page = shellTabs.SelectedTab as ShellTabPage;
				if (page == null)
				{
					//TODO: throw exception.
				}
				return page.ShellView;
			}
		}

		public MasterForm()
		{
			InitializeComponent();
			_currentKey = '\0';
			_characterKey = false;

			addShell("shell");
		}

		private TabPage addShell(string name)
		{
			var page = new ShellTabPage(name);

			shellTabs.TabPages.Add(page);
			return page;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			shellTabs.SelectedTab = addShell("shell");
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

			//ActiveShellView.onKeyDown(sender, e);
			//e.Handled = true;
		}

		private void MasterForm_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Only raised by character-keys (keys that have a proper string representation)

			//ActiveShellView.onKeyPress(sender, e);
			//e.Handled = true;
		}

		private void shellTabs_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				Debug.Assert(shellTabs.TabCount == shellTabs.TabPages.Count);
				if (shellTabs.TabCount > 1)
				{
					var selected = shellTabs.SelectedTab;
					int selectedIndex = shellTabs.SelectedIndex;

					if (selectedIndex == shellTabs.TabCount - 1)
					{
						selectedIndex -= 1;
					}

					shellTabs.TabPages.Remove(selected);
					shellTabs.SelectedIndex = selectedIndex;
				}
				else
				{
					MessageBox.Show("Cannot close last tab.");
				}
			}
		}
	}
}
