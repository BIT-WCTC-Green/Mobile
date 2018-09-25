using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DependencyInjection.Core;

namespace DependencyInjection.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window
        {
            get;
            set;
        }

        public override void FinishedLaunching(UIApplication application)
        {
            //iOS platform specific
            ServiceContainer.Register<ISettings>(() => new AppleSettings());
            //ViewModels
            ServiceContainer.Register<SettingsViewModel>();
        }
    }
}

