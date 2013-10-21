using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace mash.Logging
{
	public class TargetFile : ITarget
	{
		protected StreamWriter _fileStream;
		public string FileName { get; set; }

		public TargetFile()
		{
		}

		public TargetFile(string filename, bool tryToCreateIfNotExists = true)
		{
			var fi = new FileInfo(filename);
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
