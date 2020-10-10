using Silk.NET.Windowing.Sdl.iOS;
using Triangle;

namespace TriangleIOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args) => SilkMobile.RunApp(args, Run);
        static void Run(string[] args) => Program.Main(null!);
    }
}
