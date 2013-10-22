using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace mash.Logging.Test
{
	class SuccessException : System.Exception
	{
	}

	class FailureException : System.Exception
	{
	}

	class TestTarget : Logging.Target.IBase
	{

		public void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			throw new SuccessException();
		}

		public void Dispose()
		{
			throw new SuccessException();
		}
	}

	[TestFixture]
	public class Manager
	{
		[TestCase]
		public void test000_Creation()
		{
			var manager = new Logging.Manager();
			Assert.NotNull(manager);
			Assert.NotNull(manager.Targets);

			Assert.Pass("mash.Logging.Manager can be created normally.");
		}

		[TestCase]
		public void test002_LogMessage()
		{
			var manager = new Logging.Manager();
			manager.Targets.Add(new TestTarget());
			Assert.Throws<SuccessException>(delegate() { manager.logMessage("Some message."); });
		}
	}
}
