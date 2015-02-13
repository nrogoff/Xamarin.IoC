using IoCDemo.Core;

namespace MvvmLightDemo.Forms.iOS.Implementations
{
	public class ApplePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Apple";
		}

		public string ContainerName {
			get {
				return "MvvmLight SimpleIoc";
			}
		}
	}
}