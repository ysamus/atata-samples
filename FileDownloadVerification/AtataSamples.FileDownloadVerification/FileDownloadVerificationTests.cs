using Atata;
using NUnit.Framework;

namespace AtataSamples.FileDownloadVerification
{
	[TestFixture]
	public class FileDownloadVerificationTests
	{

		[SetUp]
		public void SetUp()
		{
			AtataContext.Configure().
				UseChrome().
					WithArguments("start-maximized").
				UseBaseUrl("https://github.com/atata-framework/atata/releases/tag/v1.5.0/").
				UseCulture("en-us").
				UseNUnitTestName().
				AddNUnitTestContextLogging().
					WithoutSectionFinish().
				LogNUnitError().
				Build();
		}

		[TearDown]
		public void TearDown()
		{
			AtataContext.Current?.CleanUp();
		}

		[Test]
		public void FileDownloadVerification()
		{
		}
	}
}
