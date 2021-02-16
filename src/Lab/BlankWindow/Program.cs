// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.PixelFormats;

namespace BlankWindow
{
    internal class Program
    {
        public const bool Quieter = true;

        public static IWindow window;

        private static void Main()
        {
            var options = WindowOptions.Default;

            //options.ShouldSwapAutomatically = false;

            options.UpdatesPerSecond = 60.0;
            options.FramesPerSecond = 60.0;
            options.VSync = true;
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

        public static void Move(Vector2D<int> position)
        {
            Console.WriteLine(position);
        }

        public static void Resize(Vector2D<int> size)
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
            var memoryGroup = image.GetPixelMemoryGroup();
            Memory<byte> array = new byte[memoryGroup.TotalLength * sizeof(Rgba32)];
            var block = MemoryMarshal.Cast<byte, Rgba32>(array.Span);
            foreach (var memory in memoryGroup)
            {
                memory.Span.CopyTo(block);
                block = block.Slice(memory.Length);
            }

            var icon = new RawImage(image.Width, image.Height, array);
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
            if (!Quieter)
            {
                Console.WriteLine($"Render {1 / delta}");
            }
        }

        public static void Update(double delta)
        {
            //if (_rsz)
            //{
            //    Console.WriteLine("* " + window.Size);
            //    _rsz = false;
            //}

            if (!Quieter)
            {
                Console.WriteLine($"Update {1 / delta}");
            }

            //Debug.WriteLine(window.VSync);
        }
    }
}
