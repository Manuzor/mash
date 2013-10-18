using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.logging
{
	public interface ITarget
	{
		void logMessage(string message, MessageLevel level);
	}
}
