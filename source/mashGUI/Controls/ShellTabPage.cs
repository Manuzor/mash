using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.gui
{
	public class ShellTabPage : TabPage
	{
		public ShellView ShellView { get; set; }

		public ShellTabPage() :
			base()
		{
			init();
		}

		public ShellTabPage(string text)
			: base(text)
		{
			init();
		}

		private void init()
		{
			Margin = Padding.Empty;
			Padding = Padding.Empty;
			BackColor = Color.Black;

			// Make shell view
			ShellView = new ShellView();

			Controls.Add(ShellView);
		}
	}
}
