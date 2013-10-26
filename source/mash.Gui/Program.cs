using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mash.Gui
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			logging.Manager.Instance.Targets.Add(new logging.Target.File("mashGUI.log"));
			logging.Manager.Instance.Targets.Add(new logging.Target.StandardOutput());
			logging.Manager.Instance.Targets.Add(new logging.Target.Settings());

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Forms.MasterWindow());
		}
	}
}
