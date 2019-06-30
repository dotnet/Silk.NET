using System;
using System.Drawing;
using System.Threading;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Desktop;

namespace Silk.NET.Windowing.Testing
{
    internal class Program
    {
        private static void Main()
        {
            var options = WindowOptions.Default;

            options.UseSingleThreadedWindow = true;
            
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

            window.OnRender += OnRender;
            window.OnUpdate += OnUpdate;
            
            Console.WriteLine($"Entry thread is {Thread.CurrentThread.ManagedThreadId}");
            
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

        public static void OnRender(double delta)
        {
            Console.WriteLine($"Render {delta}");
        }

        public static void OnUpdate(double delta)
        {
            Console.WriteLine($"Update {delta}");
        }
    }
}