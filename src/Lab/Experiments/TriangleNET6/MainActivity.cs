#if __ANDROID__
using Android.App;
using Android.Content.PM;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.Android;
using Triangle;

namespace TriangleDroid
{
    [Activity
    (
        Label = "@string/app_name",
        MainLauncher = true,
        ConfigurationChanges = ConfigChangesFlags,
        ScreenOrientation = ScreenOrientation.Landscape,
        Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen"
    )]
    public class MainActivity : SilkActivity
    {
        protected override void OnRun()
        {
            Program.API = new GraphicsAPI
                (ContextAPI.OpenGLES, ContextProfile.Compatability, ContextFlags.Default, new APIVersion(3, 0));
            Program.Run();
        }
    }
}
#endif
