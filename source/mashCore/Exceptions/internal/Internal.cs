using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
