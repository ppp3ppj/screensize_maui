using Android.App;
using Android.Content.PM;
using Android.OS;

namespace TestScreenDisplay;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        App.ScreenHeight = (int)(Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
        App.ScreenWidth = (int)(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density);
        App.ScreenHeightDp = (int)(Resources.DisplayMetrics.HeightPixels);
        App.ScreenWidthDp = (int)(Resources.DisplayMetrics.WidthPixels);
        App.ScreenDensity = (int)(Resources.DisplayMetrics.Density);
    }
}
