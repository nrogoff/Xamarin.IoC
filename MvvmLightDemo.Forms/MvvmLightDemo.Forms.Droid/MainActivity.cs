using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Ioc;
using IoCDemo.Core;
using Microsoft.Practices.ServiceLocation;
using MvvmLightDemo.Forms.Droid.Implementations;

namespace MvvmLightDemo.Forms.Droid
{
    [Activity(Label = "MvvmLightDemo.Forms", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //set local implementations in IOC
            SimpleIoc.Default.Register<ISettings, DroidSettings>();
            SimpleIoc.Default.Register<IPlatform, DroidPlatform>();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

