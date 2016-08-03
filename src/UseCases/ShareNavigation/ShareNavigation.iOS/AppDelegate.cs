using Foundation;
using ReactiveUI;
using ReactiveUI.Routing;
using ReactiveUI.Routing.iOS;
using ShareNavigation.Views;
using UIKit;

namespace ShareNavigation
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register ("AppDelegate")]
    public partial class AppDelegate : DefaultAppDelegate
    {
        protected override IRoutedAppConfig BuildAppConfig(UIApplication app, NSDictionary options)
        {
            return new iOSAppConfig(this);
        }
    }
}

