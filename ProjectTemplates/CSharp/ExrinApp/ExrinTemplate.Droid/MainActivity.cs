using Android.App;
using Android.Content.PM;
using Android.OS;
using Exrin.Framework;
using Xamarin.Forms;

namespace $safeprojectname$
{
    [Activity(Label = "$safeprojectname$", Icon = "@drawable/icon", LaunchMode = LaunchMode.SingleTop, Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
			
            Forms.Init(this, bundle);
			Exrin.Framework.App.Init(new PlatformOptions() { Platform = Device.RuntimePlatform });
			LoadApplication(new App(new Bootstrapper()));
        }
    }
}

