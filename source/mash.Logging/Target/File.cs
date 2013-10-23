using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace mash.Logging.Target
{
	public class File : IBase
	{
		#region Static
		public static string DefaultLogName { get; protected set; }

		static File()
		{
			string programName = AppDomain.CurrentDomain.FriendlyName;
			DefaultLogName = string.Format("{0}.log", programName);
		}
		#endregion
		#region Inner classes/structs/enums
		[Flags]
		public enum Options
		{
			None = 0,                 // Default options.
			CreateDirectory = 1 << 0, // Create the directory of the file if it does not exist already.
			AutoFlush = 1 << 1        // Automatically flush after every call to logMessage.
		}
		#endregion

		protected StreamWriter _fileStream;
		public string FileName { get; set; }
		public Options TargetOptions { get; set; }

		public File() :
			this(DefaultLogName)
		{
		}

		public File(string filename, Options options = Options.None)
		{
			TargetOptions = options;

			var fi = new FileInfo(Environment.ExpandEnvironmentVariables(filename));
			FileName = fi.FullName;
			if (TargetOptions.HasFlag(Options.CreateDirectory))
			{
				Directory.CreateDirectory(fi.Directory.FullName);
			}
			_fileStream = fi.CreateText();
			_fileStream.AutoFlush = TargetOptions.HasFlag(Options.AutoFlush);
		}

		public void logMessage(string message, MessageLevel level = MessageLevel.Normal)
		{
			_fileStream.Write(string.Format("[{0}] {1}: {2}",
				Enum.GetName(typeof(MessageLevel), level),
				DateTime.Now,
				message));
		}

		public void Dispose()
		{
			_fileStream.Close();
		}
	}
}
