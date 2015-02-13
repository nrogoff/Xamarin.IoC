using IoCDemo.Core;

namespace MvvmLightDemo.Forms.iOS.Implementations
{
	public class AppleSettings : ISettings
	{
		public string UserName {
			get {
                return "SteveJobs@apple.com";
			}
		}
		public string Password {
			get {
                return "whyPayLess?";
			}
		}
	}
}