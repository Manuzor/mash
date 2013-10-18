using System.Diagnostics;

namespace mash.exceptions
{
	public class Base : System.Exception
	{
		public Base()
			: base()
		{
		}

		public Base(string message)
			: base(message)
		{
			logMessage(message);
		}

		public Base(string message, System.Exception inner)
			: base(message, inner)
		{
			logMessage(message);
		}

		[Conditional("DEBUG")]
		protected virtual void logMessage(string message)
		{
			logging.Manager.Instance.logMessage(message, logging.MessageLevel.Warning);
		}
	}
}
