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
			Logging.Manager.Instance.Targets.Add(new Logging.Target.File("mashGUI.log"));
			Logging.Manager.Instance.Targets.Add(new Logging.Target.StandardOutput());
			Logging.Manager.Instance.Targets.Add(new Logging.Target.Settings());

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Forms.MasterWindow());
		}
	}
}
