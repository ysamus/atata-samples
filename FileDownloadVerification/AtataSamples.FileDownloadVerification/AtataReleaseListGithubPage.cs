using Atata;

namespace AtataSamples.FileDownloadVerification
{
	using _ = AtataReleaseListGithubPage;

	public class AtataReleaseListGithubPage : Page<_>
	{
		[FindByCss("strong.mr-2")]
		public Link<_> RepositoryLink { get; private set; }

		[FindByClass("release-header")]
		public Link<_> LatestReleaseHeaderlink { get; private set; }

		[FindByClass("Box--condensed")]
		public Link<_> LatestReleaseSourceCodeZiplink { get; private set; }
	}
}