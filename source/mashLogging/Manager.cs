using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.logging
{
	public delegate void MessageDelegate(string message, MessageLevel level);

	public class Manager
	{
		public event MessageDelegate onLogMessage;

		public void logMessage(string message, MessageLevel level)
		{
			if (onLogMessage != null)
			{
				onLogMessage(message, level);
			}
		}
	}
}
