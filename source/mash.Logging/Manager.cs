using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging
{
	public delegate void MessageDelegate(string message, MessageLevel level = MessageLevel.Normal);

	public class Manager
	{
		#region Static
		public static Manager Instance { get; protected set; }

		static Manager()
		{
			Instance = new Manager();
		}
		#endregion

		public event MessageDelegate OnMessageLogging;
		public event MessageDelegate OnMessageLogged;

		public IList<Target.IBase> Targets { get; set; }

		public Manager()
		{
			Targets = new List<Target.IBase>();
		}

		public virtual void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			if (OnMessageLogging != null)
			{
				OnMessageLogging(message, level);
			}

			foreach (var target in Targets)
			{
				target.write(message, level);
			}

			if (OnMessageLogged != null)
			{
				OnMessageLogged(message, level);
			}
		}
	}
}
