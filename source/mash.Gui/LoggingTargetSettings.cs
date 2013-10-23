using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging.Target
{
	public class Settings :
		IBase
	{

		public void write(string message, MessageLevel level = MessageLevel.Normal)
		{
			message = string.Format("{0}: {1}", DateTime.Now, message);
			Gui.Properties.Settings.Default.GlobalLog += message;
		}

		public void Dispose()
		{
			// Empty the settings log in case the settings are saved on program shutdown.
			Gui.Properties.Settings.Default.GlobalLog = string.Empty;
		}
	}
}
