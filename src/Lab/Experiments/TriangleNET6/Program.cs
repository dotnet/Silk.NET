#if !__IOS__ && !__ANDROID__
Triangle.Program.Run();
#elif __IOS__
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;
using Silk.NET.Windowing.Sdl.iOS;
using Silk.NET.Input.Sdl;
using Silk.NET.SDL;
using System;
using Triangle;

static void Run(string[] args)
{
    Triangle.Program.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 0));
    Triangle.Program.Run();
}

SdlInput.RegisterPlatform();
Console.WriteLine("Hello, world!");
SilkMobile.RunApp(args, Run);
Console.WriteLine("Goodbye, world!");
SdlProvider.SDL.Value.ThrowError();
#endif
