// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Threading;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.Maths;
using Silk.NET.OpenGLES;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Advanced;
using SixLabors.ImageSharp.PixelFormats;
#if WASM
using Uno.Foundation;
#endif

namespace BlankWindow
{
    internal class Program
    {
        private const bool QUIETER = true;

        private static  IView   _View;
        private static  IWindow _Window;

        private static void Main()
        {
            SdlWindowing.RegisterPlatform();

#if WASM
            WebAssemblyRuntime.InvokeJS
            (
                @"var canvas = document.createElement('canvas');
canvas.style.position = ""absolute"";
canvas.style.left       = ""0px"";
canvas.style.top        = ""0px"";
canvas.style.zIndex     = ""100"";
canvas.style.width      = ""1920"";
canvas.style.height     = ""1080"";
canvas.style.width = ""100%"";
canvas.style.height = ""100%"";
canvas.oncontextmenu=""event.preventDefault()"";
canvas.id = 'canvas';
document.body.appendChild(canvas);
//Set the module canvas
Module['canvas'] = canvas;
"
            );
#endif

            var options = WindowOptions.Default;

            options.UpdatesPerSecond = 60.0;
            options.FramesPerSecond  = 60.0;
            options.VSync = true;

            if (Window.IsViewOnly)
            {
                _View = Window.GetView(new(options));
            }
            else
            {
                _View = _Window = Window.Create(options);
                
                _Window.FileDrop     += FileDrop;
                _Window.Move         += Move;
                _Window.StateChanged += StateChanged;
            }

            _View.Resize       += Resize;
            _View.Load         += Load;
            _View.Closing      += Closing;
            _View.FocusChanged += FocusChanged;

            _View.Render += Render;
            _View.Update += Update;

            Console.WriteLine($"Entry thread is {Thread.CurrentThread.ManagedThreadId}");

            _View.Run();
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
            if (!Silk.NET.Windowing.Window.IsViewOnly)
            {
                using var    image       = Image.Load<Rgba32>("favicon.png");
                var          memoryGroup = image.GetPixelMemoryGroup();
                Memory<byte> array       = new byte[memoryGroup.TotalLength * sizeof(Rgba32)];
                var          block       = MemoryMarshal.Cast<byte, Rgba32>(array.Span);
                foreach (var memory in memoryGroup)
                {
                    memory.Span.CopyTo(block);
                    block = block.Slice(memory.Length);
                }

                var icon = new RawImage(image.Width, image.Height, array);
                _Window.SetWindowIcon(ref icon);
            }
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
            if (!QUIETER)
            {
                Console.WriteLine($"Render {delta}:{1 / delta}");
            }
        }

        public static void Update(double delta)
        {
            //if (_rsz)
            //{
            //    Console.WriteLine("* " + view.Size);
            //    _rsz = false;
            //}

            if (!QUIETER)
            {
                Console.WriteLine($"Update {delta}:{1 / delta}");
            }

            //Debug.WriteLine(view.VSync);
        }
    }
}
