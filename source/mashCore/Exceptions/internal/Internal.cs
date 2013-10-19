namespace mash.exceptions
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
			logging.Manager.Instance.logMessage(message, logging.MessageLevel.Critical);
		}
	}
}
