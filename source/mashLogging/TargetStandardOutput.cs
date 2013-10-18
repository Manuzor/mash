using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.logging
{
	public class TargetStandardOutput : ITarget
	{
		public void logMessage(string message, MessageLevel level)
		{
			Console.WriteLine(message);
		}
	}
}
