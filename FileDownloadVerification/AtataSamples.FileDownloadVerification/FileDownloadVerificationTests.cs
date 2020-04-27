using System;
using System.IO;
using Atata;
using NUnit.Framework;

namespace AtataSamples.FileDownloadVerification
{
	[TestFixture]
	public class FileDownloadVerificationTests
	{
		private string DownloadDirectoryPath { get; } = $"{AppDomain.CurrentDomain.BaseDirectory}/OutputFiles";

		[SetUp]
		public void SetUp()
		{
			SetUpDownloadDirectory();

			AtataContext.Configure().
				UseChrome().
					//WithArguments("headless").
					WithOptions(options => options.AddUserProfilePreference("download.default_directory", DownloadDirectoryPath)).
					WithLocalDriverPath().
				UseBaseUrl("https://github.com/").
				UseCulture("en-us").
				UseAllNUnitFeatures().
				Build();
		}

		private void SetUpDownloadDirectory()
		{
			if (Directory.Exists(DownloadDirectoryPath))
				Directory.Delete(DownloadDirectoryPath);

			Directory.CreateDirectory(DownloadDirectoryPath);
		}

		[TearDown]
		public void TearDown()
		{
			AtataContext.Current?.CleanUp();
		}

		[Test]
		public void FileDownloadVerification()
		{
			Go.To<ReleaseGitHubPage>(url: "atata-framework/atata/releases/tag/v1.5.0").
				SourceCodeZipLink.Click();

			//string sourceCodeZipExpectedPath = Path.Combine(DownloadDirectoryPath, "atata-1.5.0.zip");
		}
	}
}
