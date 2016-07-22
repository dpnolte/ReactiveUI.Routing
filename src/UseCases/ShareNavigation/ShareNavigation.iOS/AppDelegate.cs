using MonoTouch.Foundation;
using MonoTouch.UIKit;
using ReactiveUI;
using ShareNavigation.Views;

namespace ShareNavigation
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register ("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations
        UIWindow window;
        TestViewController viewController;
		AutoSuspendHelper suspendHelper;

		public AppDelegate()
		{
			suspendHelper = new AutoSuspendHelper(this);
		}

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            viewController = new TestViewController();
            window.RootViewController = viewController;
            window.MakeKeyAndVisible();
            
			suspendHelper.FinishedLaunching(app, options);
            return true;
        }

        public override void DidEnterBackground(UIApplication application)
        {
            suspendHelper.DidEnterBackground(application);
        }

        public override void OnActivated(UIApplication application)
        {
            suspendHelper.OnActivated(application);
        }
    }
}

