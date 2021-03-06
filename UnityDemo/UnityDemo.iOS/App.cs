﻿using Microsoft.Practices.Unity;
using IoCDemo.Core;

namespace UnityDemo.iOS
{
	public static class App
	{
		public static UnityContainer Container { get; set; }

		public static void Initialize()
		{
			App.Container = new UnityContainer();
			App.Container.RegisterType<IPlatform, ApplePlatform> ();
			App.Container.RegisterType<ISettings, AppleSettings> ();
		}
	}
}