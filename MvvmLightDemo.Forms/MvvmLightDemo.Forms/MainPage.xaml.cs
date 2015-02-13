using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoCDemo.Core;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;

namespace MvvmLightDemo.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel Vm
        {
            get { return (MainViewModel) BindingContext; }
        }

        public MainPage()
        {
            InitializeComponent();

            //set page binding context
            BindingContext = ServiceLocator.Current.GetInstance<MainViewModel>();
        }
    }
}
