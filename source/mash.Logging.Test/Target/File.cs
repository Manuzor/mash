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
				var fileinfo = new FileInfo(Environment.ExpandEnvironmentVariables(filename));

				if (System.IO.File.Exists(fileinfo.FullName))
				{
					System.IO.File.Delete(fileinfo.FullName);
				}

				using (var target = new Logging.Target.File(filename))
				{
					Assert.AreEqual(target.FileName, fileinfo.FullName, "Filenames don't match! Was the Logging.Target.File implementation altered to not use absolute paths?");
					Assert.True(System.IO.File.Exists(target.FileName), "File could not be created: {0}", target.FileName);
					Assert.True(Directory.Exists(fileinfo.Directory.FullName), "Directory was not created!");
				}
			}
		}
	}
}
