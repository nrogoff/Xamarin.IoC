using IoCDemo.Core;

namespace MvvmLightDemo.Forms.Droid.Implementations
{
	public class DroidPlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Android";
		}

		public string ContainerName {
			get {
				return "MvvmLight";
			}
		}
	}
}