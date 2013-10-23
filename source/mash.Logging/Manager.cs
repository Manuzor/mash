using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging
{
	public delegate void MessageDelegate(string message, MessageLevel level = MessageLevel.Normal);

	public interface IManager
	{
		void write(string message, MessageLevel level = MessageLevel.Normal);
		void writeln(string message, MessageLevel level = MessageLevel.Normal);
		void writef(string message, MessageLevel level = MessageLevel.Normal, params object[] args);
		void writefln(string message, MessageLevel level = MessageLevel.Normal, params object[] args);
	}

	public class Manager :
		IManager
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

		public virtual void write(string message, MessageLevel level = MessageLevel.Normal)
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

		public void writeln(string message, MessageLevel level = MessageLevel.Normal)
		{
			message = string.Format("{0}{1}", message, Properties.Settings.Default.NewLine);
			write(message);
		}

		public void writef(string message, MessageLevel level = MessageLevel.Normal, params object[] args)
		{
			message = string.Format(message, args);
			write(message, level);
		}

		public void writefln(string message, MessageLevel level = MessageLevel.Normal, params object[] args)
		{
			message = string.Format(message, args);
			writeln(message, level);
		}
	}
}
