using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.gui
{
	public partial class ShellView : UserControl
	{
		private Keys _currentKey = 0;
		private int _counter = 0;

		public ShellView()
		{
			InitializeComponent();

			Dock = DockStyle.Fill;
			Padding = Padding.Empty;
			Margin = Padding.Empty;
		}
	}
}
