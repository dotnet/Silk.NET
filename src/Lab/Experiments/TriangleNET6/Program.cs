#if !__IOS__ && !__ANDROID__
Triangle.Program.Run();
#elif __IOS__
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.iOS;
using Silk.NET.Input.Sdl;

SdlInput.RegisterPlatform();
SilkMobile.RunApp(args, _ =>
{
    Triangle.Program.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 0));
    Triangle.Program.Run();
});
#endif
