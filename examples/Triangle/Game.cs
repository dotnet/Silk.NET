// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using System.Threading;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Triangle
{
    public class Game
    {
        private IWindow window;
        private GL gl;

        public Game()
        {
            var options = WindowOptions.Default;

            options.UseSingleThreadedWindow = false;

            window = Window.Create(options);

            window.OnLoad += OnLoad;
            window.OnRender += OnRender;
            window.OnResize += OnResize;
            
            gl = GL.GetApi();
        }

        public void Run()
        {
            window.Run();
        }
        
        public void OnLoad()
        {
            gl.ClearColor(1.0f, 0.4f, 0.3f, 1.0f);
        }

        public void OnRender(double delta)
        {
            gl.Clear((uint)GLEnum.ColorBufferBit);
        }

        public void OnResize(Size size)
        {
            gl.Viewport(0, 0, (uint)size.Width, (uint)size.Height);
        }
    }
}