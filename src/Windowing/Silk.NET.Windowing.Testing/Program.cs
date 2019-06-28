using System;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing.Testing
{
    internal class Program
    {
        private static void Main()
        {
            var options = WindowOptions.Default;
            options.UpdatesPerSecond = 60.0;
            var window = new GlfwWindow(options);
            window.OnFileDrop += OnFileDrop;
            window.Run();
        }

        public static void OnFileDrop(object e, string[] args)
        {
            foreach (var file in args) {
                Console.WriteLine(file);
            }
        }
    }
}