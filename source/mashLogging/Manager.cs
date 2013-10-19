using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.logging
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

		public event MessageDelegate OnLogMessage;

		public virtual void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			if (OnLogMessage != null)
			{
				OnLogMessage(message, level);
			}
		}
	}
}
