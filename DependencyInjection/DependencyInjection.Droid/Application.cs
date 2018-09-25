using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DependencyInjection.Core;

namespace DependencyInjection.Droid
{
    [Application]
    public class Application : Android.App.Application
    {
        //This constructor is required
        public Application(IntPtr javaReference, 
                           JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();

            //Android platform specific
            ServiceContainer.Register<ISettings>(() => new DroidSettings(this));
            //ViewModels
            ServiceContainer.Register<SettingsViewModel>();
        }
    }
}

