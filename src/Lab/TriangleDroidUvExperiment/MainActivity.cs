using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Org.Libsdl.App;
using Triangle;

namespace TriangleDroidUvExperiment
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : SDLActivity
    {
        protected override void OnUltravioletRun()
        {
            //var main = this;
            //var aaaa = SDL.Context;
            //var oooo = MSingleton;
            //SDL.SetupJNI();
            Program.Main(null!);
        }
    }
}
