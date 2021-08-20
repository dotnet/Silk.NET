#if __IOS__
using System;
using Silk.NET.Input.Sdl;
using Silk.NET.SDL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.iOS;
using Triangle;

namespace TriangleIOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            SdlInput.RegisterPlatform();
            Console.WriteLine("Hello, world!");
            SilkMobile.RunApp(args, Run);
            Console.WriteLine("Goodbye, world!");
            SdlProvider.SDL.Value.ThrowError();
        }

        static void Run(string[] args)
        {
            Program.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Core, ContextFlags.Default, new APIVersion(3, 0));
            Program.Main(null!);
        }
    }
}
#endif
