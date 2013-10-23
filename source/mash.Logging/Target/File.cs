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
		public static string DefaultLogName { get; protected set; }

		static File()
		{
			string programName = AppDomain.CurrentDomain.FriendlyName;
			DefaultLogName = string.Format("{0}.log", programName);
		}

		protected StreamWriter _fileStream;
		public string FileName { get; set; }

		public File() :
			this(DefaultLogName, false)
		{
		}

		public File(string filename, bool tryToCreateIfNotExists = true)
		{
			FileName = filename;
			var fi = new FileInfo(FileName);
			if (tryToCreateIfNotExists)
			{
				Directory.CreateDirectory(fi.Directory.FullName);
			}
			_fileStream = fi.CreateText();
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
