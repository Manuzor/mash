namespace mash.Exceptions.Internal
{
	public class Base : Exceptions.Base
	{
		public Base()
			: base()
		{
		}

		public Base(string message)
			: base(message)
		{
		}

		public Base(string message, System.Exception inner)
			: base(message, inner)
		{
		}

		protected override void logMessage(string message)
		{
			Logging.Manager.Instance.logMessage(message, Logging.MessageLevel.Critical);
		}
	}
}
