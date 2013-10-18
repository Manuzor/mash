using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace mash.Logging
{
	public class TargetStandardOutput : ITarget
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

		public TargetStandardOutput()
		{
			ColorScheme = new Dictionary<MessageLevel, ConsoleColor>();
		}

		public TargetStandardOutput(IDictionary<MessageLevel, ConsoleColor> colorScheme)
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

		public void logMessage(string message, MessageLevel level)
		{
			Console.WriteLine(message);
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
	}
}
