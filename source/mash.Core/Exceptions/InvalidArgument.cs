namespace mash.Core.Exceptions
{
	public class InvalidArgument : Base
	{
		public InvalidArgument()
			: base()
		{
		}

		public InvalidArgument(string message)
			: base(message)
		{
		}

		public InvalidArgument(string message, System.Exception inner)
			: base(message, inner)
		{
		}
	}
}
