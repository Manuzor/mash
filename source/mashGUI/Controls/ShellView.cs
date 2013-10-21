using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.Gui.Controls
{
	public partial class ShellView : UserControl
	{
		string _onEnter = string.Format("{0}{1}$ ", Environment.CurrentDirectory, Environment.NewLine);

		public ShellView()
		{
			InitializeComponent();

			Dock = DockStyle.Fill;
			Padding = Padding.Empty;
			Margin = Padding.Empty;

			console.Text = _onEnter;
		}

		private void input_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				console.Text += string.Format("{0}{1}{2}", input.Text, Environment.NewLine, _onEnter);
				input.Text = string.Empty;
			}
		}
	}
}
