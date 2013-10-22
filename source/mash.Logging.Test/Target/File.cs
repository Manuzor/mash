using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mash.Logging.Test.Target
{
	[TestFixture]
	public class File
	{
		[TestCase]
		public void test000_BasicCreation()
		{
			var target = new Logging.Target.File();
			Assert.AreEqual(target.FileName, Logging.Target.File.DefaultLogName);
			//Assert.AreSame(target.FileName, Logging.Target.File.DefaultLogName);
		}

		[TestCase]
		public void test001_CreationWithArgs()
		{
			string[] filenames = new string[]
			{
				@"TheLog.log",
				@"%TEMP%\mash.Logging.Test\aLogWithoutAnExtension",
				@"%TEMP%\mash.Logging.Test\aSubDirectory\anotherLogFile.log"
			};

			foreach (var filename in filenames)
			{
				var fileinfo = new FileInfo(filename);
				var target = new Logging.Target.File(filename);
				Assert.AreEqual(target.FileName, filename);
				Assert.True(Directory.Exists(fileinfo.Directory.FullName), "Directory was not created!");
				Assert.True(fileinfo.Exists, "File could not be created.");
			}
		}
	}
}
