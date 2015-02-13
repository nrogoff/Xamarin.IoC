using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using GalaSoft.MvvmLight.Ioc;
using IoCDemo.Core;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MvvmLightDemo.Forms.WinPhone.Implementations;

namespace MvvmLightDemo.Forms.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            //set local implementations in IOC
            SimpleIoc.Default.Register<ISettings, WinPhoneSettings>();
            SimpleIoc.Default.Register<IPlatform, WinPhonePlatform>();


            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new MvvmLightDemo.Forms.App());
        }
    }
}
