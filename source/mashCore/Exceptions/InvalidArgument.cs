using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.exceptions
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
