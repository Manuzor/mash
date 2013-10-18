using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace mash.Logging
{
	public class TargetFile : ITarget
	{
		public string FileName { get; set; }

		public TargetFile()
		{
		}

		public TargetFile(string filename)
		{
		}

		public void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			//TODO: Implement this.
		}
	}
}
