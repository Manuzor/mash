using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.logging
{
	public enum MessageLevel
	{
		None = 0,
		Trivial = 1,
		Normal = 10,
		Warning = 100,
		Error = 1000,
		Critical = 10000,
		Fatal = 100000,
		Maximum = int.MaxValue
	}
}
