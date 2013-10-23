using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging.Target
{
	public interface IBase : System.IDisposable
	{
		void write(string message, MessageLevel level = MessageLevel.Normal);
	}
}
