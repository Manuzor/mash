using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Gui.Exceptions
{
	public class Base :
		mash.Exceptions.Base
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
	}
}
