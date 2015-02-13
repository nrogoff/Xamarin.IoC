using IoCDemo.Core;

namespace MvvmLightDemo.Forms.WinPhone.Implementations
{
	public class WinPhonePlatform : IPlatform
	{
		public string GetPlatformName ()
		{
			return "Windows Phone";
		}

		public string ContainerName {
			get {
                return "MvvmLight SimpleIoc";
			}
		}
	}
}