using Acr.UserDialogs;
using Android.App;
using Android.Runtime;
using AndroidX.AppCompat.App;

namespace UWToDoMobile
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            AppCompatDelegate.DefaultNightMode = AppCompatDelegate.ModeNightNo;
        }

        public override void OnCreate()
        {
            base.OnCreate();

            UserDialogs.Init(this);
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
