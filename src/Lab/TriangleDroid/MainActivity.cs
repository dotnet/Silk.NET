using Android.App;
using Android.Content.PM;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.Android;
using Triangle;

namespace TriangleDroid
{
    [Activity
    (
        Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChangesFlags
    )]
    public class MainActivity : SilkActivity
    {
        protected override void OnRun()
        {
            Program.API = new GraphicsAPI
                (ContextAPI.OpenGLES, ContextProfile.Compatability, ContextFlags.Default, new APIVersion(3, 0));
            Program.Main(null!);
        }
    }
}
