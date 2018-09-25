using MonoTouch.UIKit;
using MonoTouch.Foundation;
using DependencyInjection.Core;

namespace DependencyInjection.iOS
{
    public class AppleSettings : ISettings
    {
        public bool IsSoundOn
        {
            get { return NSUserDefaults.StandardUserDefaults.BoolForKey("IsSoundOn"); }
            set
            {
                var defaults = NSUserDefaults.StandardUserDefaults;
                defaults.SetBool(value, "IsSoundOn");
                defaults.Synchronize();
            }
        }
    }
}

