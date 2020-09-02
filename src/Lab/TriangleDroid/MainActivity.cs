using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Silk.NET.Windowing.Sdl.Android;
using Triangle;

namespace TriangleDroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : SilkActivity
    {
        protected override void OnRun()
        {
            Program.Main(null!);
        }
    }
}
