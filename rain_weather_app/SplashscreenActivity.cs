using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace rain_weather_app
{
    [Activity(Label = "SplashscreenActivity")]
    public class SplashscreenActivity : MvxSplashScreenAppCompatActivity
    {
        public SplashscreenActivity() : base(Resource.Layout.Splashscreen_view)
        { 
        }
    }
}