using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Gui.Exceptions.Internal
{
	public class InvalidControl
		: Exceptions.Internal.Base
	{
		public InvalidControl()
			: base()
		{
		}

		public InvalidControl(string message)
			: base(message)
		{
		}

		public InvalidControl(string message, System.Exception inner)
			: base(message, inner)
		{
		}
	}
}
