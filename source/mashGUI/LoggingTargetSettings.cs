using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging
{
	public class LoggingTargetSettings : ITarget
	{

		public void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			// Nothing to do here.
		}
	}
}
