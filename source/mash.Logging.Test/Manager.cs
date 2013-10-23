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
		public string LastLoggedMessage { get; set; }
		public Logging.MessageLevel LastLoggedMessageLevel { get; set; }
		public bool MessageLogged { get; set; }
		public bool Disposed { get; set; }

		public TestTarget()
		{
			reset();
		}

		public void write(string message, Logging.MessageLevel level = Logging.MessageLevel.Normal)
		{
			LastLoggedMessage = message;
			LastLoggedMessageLevel = level;
			MessageLogged = true;
		}

		public void Dispose()
		{
			Disposed = true;
		}

		public void reset()
		{
			LastLoggedMessage = null;
			LastLoggedMessageLevel = Logging.MessageLevel.None;
			MessageLogged = false;
			Disposed = false;
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
		public void test001_AddingTargets()
		{
			var manager = new Logging.Manager();
			var target = new TestTarget();

			Assert.False(target.MessageLogged);
			Assert.False(target.Disposed);
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.None);

			Assert.AreEqual(manager.Targets.Count, 0);

			manager.Targets.Add(target);
			Assert.AreEqual(manager.Targets.Count, 1);
		}

		[TestCase]
		public void test001_RemovingTargets()
		{
			var manager = new Logging.Manager();
			var target = new TestTarget();

			Assert.False(target.MessageLogged);
			Assert.False(target.Disposed);
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.None);

			Assert.AreEqual(manager.Targets.Count, 0);

			manager.Targets.Add(target);
			Assert.AreEqual(manager.Targets.Count, 1);

			manager.Targets.Remove(target);
			Assert.AreEqual(manager.Targets.Count, 0);
		}

		[TestCase]
		public void test010_LogMessage()
		{
			var manager = new Logging.Manager();
			var target = new TestTarget();
			manager.Targets.Add(target);

			Assert.False(target.Disposed);
			Assert.False(target.MessageLogged);
			Assert.Null(target.LastLoggedMessage);
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.None);

			// Log a message
			manager.logMessage("Hello");
			Assert.True(target.MessageLogged, "write was not called!");
			Assert.AreEqual(target.LastLoggedMessage, "Hello");
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.Normal);

			// Reset the target
			target.reset();
			Assert.False(target.MessageLogged);
			Assert.Null(target.LastLoggedMessage);
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.None);

			manager.logMessage("World", Logging.MessageLevel.Critical);
			Assert.True(target.MessageLogged, "write was not called!");
			Assert.AreEqual(target.LastLoggedMessage, "World");
			Assert.AreEqual(target.LastLoggedMessageLevel, Logging.MessageLevel.Critical);
		}
	}
}
