using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: AssemblyTitle(LinuxFixes.BuildInfo.Name)]
[assembly: AssemblyProduct(LinuxFixes.BuildInfo.GUID)]
[assembly: AssemblyVersion(LinuxFixes.BuildInfo.Version)]
[assembly: AssemblyCompany("neos.ljoonal.xyz")]

namespace LinuxFixes
{
	public static class BuildInfo
	{
		public const string Version = "0.0.1";

		public const string Name = "Linux Fixes";

		public const string Author = "ljoonal";

		public const string Link = "https://neos.ljoonal.xyz/";

		public const string GUID = "xyz.ljoonal.neos.linuxfixes";
	}
}