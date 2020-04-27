using Atata;

namespace AtataSamples.FileDownloadVerification
{
	using _ = ReleaseGitHubPage;

	public class ReleaseGitHubPage : Page<_>
	{
		[FindByContent("Source code (zip)")]
		public Link<_> SourceCodeZipLink { get; private set; }
	}
}