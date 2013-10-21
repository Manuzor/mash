using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mash.Gui.Properties;

namespace mash.Logging.Target
{
	public class Settings :
		IBase
	{

		public void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			message = string.Format("{0}: {1}", DateTime.Now, message);
			mash.Gui.Properties.Settings.Default.GlobalLog += message;
		}

		public void Dispose()
		{
			// Nothing to do here.
		}
	}
}
