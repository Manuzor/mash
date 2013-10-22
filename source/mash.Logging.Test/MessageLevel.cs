using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mash.Logging.Test
{
	[TestFixture]
	public class MessageLevel
	{
		[TestCase]
		public void test000_ProperRange()
		{
			var values = Enum.GetValues(typeof(Logging.MessageLevel)) as Logging.MessageLevel[];
			Assert.GreaterOrEqual(values.Length, 2, "MessageLevel enum has to have at least the values None and Maximum!");

			var lastIndex = values.Length - 1;

			Assert.AreEqual((int)values[0], 0, "First value of the MessageLevel enum has to be equal to the integer 0!");
			Assert.AreEqual(values.Max(), (Logging.MessageLevel)values[lastIndex], "Last value of the MessageLevel enum has to be the maximum value of the enum!");
		}
	}
}
