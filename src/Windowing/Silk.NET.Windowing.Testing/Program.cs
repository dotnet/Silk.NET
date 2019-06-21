using System;
using Silk.NET.GLFW;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = WindowOptions.Default;
            options.UpdatesPerSecond = 60.0;
            var window = new TestWindow(options);
            window.Run();
        }
    }
}