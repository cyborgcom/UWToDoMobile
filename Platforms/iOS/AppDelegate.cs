using Foundation;
using UIKit;
using UserNotifications;

namespace UWToDoMobile
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate, IUNUserNotificationCenterDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            bool result = base.FinishedLaunching(app, options);

            return result;
        }
    }
}
