using IoCDemo.Core;

namespace MvvmLightDemo.Forms.WinPhone.Implementations
{
	public class WinPhoneSettings : ISettings
	{
		public string UserName {
			get {
				return "BillGates@Microsoft.com";
			}
		}
		public string Password {
			get {
				return "weAreEverywhere";
			}
		}
	}
}