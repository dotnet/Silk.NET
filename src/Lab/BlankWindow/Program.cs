// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;
using Silk.NET.Windowing.Common.Structs;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Drawing;
using System.Threading;
using Image = SixLabors.ImageSharp.Image;

namespace BlankWindow
{
    internal class Program
    {
        public static IWindow window;

        private static void Main()
        {
            var options = WindowOptions.Default;

            options.UseSingleThreadedWindow = true;
            //options.ShouldSwapAutomatically = false;

            options.UpdatesPerSecond = 60.0;
            options.FramesPerSecond = 60.0;
            // options.VSync = VSyncMode.On;

            // options.WindowState = WindowState.Fullscreen;

            window = Window.Create(options);

            window.FileDrop += FileDrop;
            window.Move += Move;
            window.Resize += Resize;
            window.StateChanged += StateChanged;
            window.Load += Load;
            window.Closing += Closing;
            window.FocusChanged += FocusChanged;

            window.Render += Render;
            window.Update += Update;

            //window.VSync = VSyncMode.Off;

            Console.WriteLine($"Entry thread is {Thread.CurrentThread.ManagedThreadId}");

            window.Run();
        }

        public static void FileDrop(string[] args)
        {
            foreach (var file in args)
            {
                Console.WriteLine(file);
            }
        }

        public static void Move(Point position)
        {
            Console.WriteLine(position);
        }

        public static void Resize(Size size)
        {
            Console.WriteLine(size);
            //_rsz = true;
        }

        public static void StateChanged(WindowState state)
        {
            Console.WriteLine(state);
        }

        //private static bool _rsz = true;
        public static unsafe void Load()
        {
            using var image = Image.Load<Rgba32>("favicon.png");
            Span<byte> span;
            byte[] arr;
            var ogspan = image.GetPixelRowSpan(0);
            fixed (Rgba32* pixels = ogspan)
            {
                span = new Span<byte>(pixels, ogspan.Length * 4);
                arr = span.ToArray();
            }

            var icon = new WindowIcon(image.Width, image.Height, arr);
            window.SetWindowIcon(ref icon);
            Console.WriteLine("Finished loading");
        }

        public static void Closing()
        {
            Console.WriteLine("Window is closing now");
        }

        public static void FocusChanged(bool isFocused)
        {
            Console.WriteLine($"Focused = {isFocused}");
        }

        public static void Render(double delta)
        {
            Console.WriteLine($"Render {1 / delta}");
        }

        public static void Update(double delta)
        {
            //if (_rsz)
            //{
            //    Console.WriteLine("* " + window.Size);
            //    _rsz = false;
            //}

            Console.WriteLine($"Update {1 / delta}");
            //Debug.WriteLine(window.VSync);
        }
    }
}