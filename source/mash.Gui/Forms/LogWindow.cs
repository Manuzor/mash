using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.Gui.Forms
{
	public partial class LogWindow :
		Form,
		logging.Target.IBase
	{
		public LogWindow()
		{
			InitializeComponent();

			logging.Manager.Instance.Targets.Add(this);
		}

		private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		public void write(string message, logging.MessageLevel level = logging.MessageLevel.Normal)
		{
			logTextBox.AppendText(string.Format("{0} [{1}]: {2}{3}",
				DateTime.Now,
				level.ToString(),
				message,
				Environment.NewLine
				));
		}
	}
}
