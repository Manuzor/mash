using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging
{
	public interface ITarget
	{
		void logMessage(string message, MessageLevel level = MessageLevel.Normal);
	}
}
