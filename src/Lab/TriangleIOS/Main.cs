using System;
using Silk.NET.SDL;
using Silk.NET.Windowing.Sdl.iOS;
using Triangle;

namespace TriangleIOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            SilkMobile.RunApp(args, Run);
            Console.WriteLine("Goodbye, world!");
            SdlProvider.SDL.Value.ThrowError();
        }

        static void Run(string[] args) => Program.Main(null!);
    }
}
