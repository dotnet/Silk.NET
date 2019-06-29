using System;
using System.Drawing;
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
            options.FramesPerSecond = 60.0;
            
            var window = new GlfwWindow(options);

            window.OnFileDrop += OnFileDrop;
            window.OnMove += OnMove;
            window.OnResize += OnResize;
            window.OnStateChanged += OnStateChanged;
            window.OnLoad += OnLoad;
            window.OnClosing += OnClosing;
            window.OnFocusChanged += OnFocusChanged;
            
            window.Run();
        }

        public static void OnFileDrop(string[] args)
        {
            foreach (var file in args) {
                Console.WriteLine(file);
            }
        }

        public static void OnMove(Point position)
        {
            Console.WriteLine(position);
        }

        public static void OnResize(Size size)
        {
            Console.WriteLine(size);
        }

        public static void OnStateChanged(WindowState state)
        {
            Console.WriteLine(state);
        }

        public static void OnLoad()
        {
            Console.WriteLine("Finished loading");
        }

        public static void OnClosing()
        {
            Console.WriteLine("Window is closing now");
        }

        public static void OnFocusChanged(bool isFocused)
        {
            Console.WriteLine($"Focused = {isFocused}");
        }
    }
}