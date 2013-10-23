using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace mash.Logging.Target
{
	public class StandardOutput : IBase
	{
		#region Inner classes
		public class ColorSchemeDefault : Dictionary<MessageLevel, ConsoleColor>
		{
			public ColorSchemeDefault()
			{
				Add(MessageLevel.None, ConsoleColor.Gray);
				Add(MessageLevel.Trivial, ConsoleColor.Gray);
				Add(MessageLevel.Normal, ConsoleColor.Gray);
				Add(MessageLevel.Warning, ConsoleColor.Yellow);
				Add(MessageLevel.Error, ConsoleColor.Red);
				Add(MessageLevel.Critical, ConsoleColor.Red);
				Add(MessageLevel.Fatal, ConsoleColor.Red);
				Add(MessageLevel.Maximum, ConsoleColor.Red);
			}
		}
		#endregion

		public IDictionary<MessageLevel, ConsoleColor> ColorScheme { get; set; }

		public StandardOutput()
		{
			ColorScheme = new Dictionary<MessageLevel, ConsoleColor>();
		}

		public StandardOutput(IDictionary<MessageLevel, ConsoleColor> colorScheme)
		{
			if (colorScheme == null)
			{
				ColorScheme = new Dictionary<MessageLevel, ConsoleColor>();
			}
			else
			{
				ColorScheme = colorScheme;
			}
		}

		public void write(string message, MessageLevel level = MessageLevel.Normal)
		{
			message = string.Format("{0}: {1}", DateTime.Now, message);
			if (ColorScheme.ContainsKey(level))
			{
				var bak = Console.ForegroundColor;
				Console.ForegroundColor = ColorScheme[level];
				Console.WriteLine(message);
				Console.ForegroundColor = bak;
			}
			else
			{
				Console.WriteLine(message);
			}
		}

		public void Dispose()
		{
			// Nothing to do here.
		}
	}
}
