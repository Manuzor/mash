namespace mash.Exceptions.Internal
{
	public class Internal : Base
	{
		public Internal()
			: base()
		{
		}

		public Internal(string message)
			: base(message)
		{
		}

		public Internal(string message, System.Exception inner)
			: base(message, inner)
		{
		}

		protected override void logMessage(string message)
		{
			Logging.Manager.Instance.logMessage(message, Logging.MessageLevel.Critical);
		}
	}
}
