using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using IoCDemo.Core;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;

namespace MvvmLightDemo.Forms
{
    public class App : Application
    {

        public App()
        {
            //Init IOC and use Common Service Locator
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //Platform specific services are registered on each platform

            //Register view model
            SimpleIoc.Default.Register<MainViewModel>();

            // The root page of your application
            MainPage = new MainPage();
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
