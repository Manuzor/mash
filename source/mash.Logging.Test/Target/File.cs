using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging.Test.Target
{
	[TestFixture]
	public class File
	{
		[TestCase]
		public void test000_BasicCreation()
		{
			var traget = new Logging.Target.File();

		}
	}
}
