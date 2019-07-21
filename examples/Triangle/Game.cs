// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Drawing;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Triangle
{
    public unsafe class Game
    {
        private IWindow window;
        private GL gl;

        private uint vbo;
        private uint vao;
        
        private float[] vertices = {
            -0.5f, -0.5f, 0.0f, //Bottom-left vertex
            0.5f, -0.5f, 0.0f, //Bottom-right vertex
            0.0f,  0.5f, 0.0f  //Top vertex
        };

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

            vbo = gl.GenBuffer(1);
            gl.BindBuffer((int)GLEnum.ArrayBuffer, vbo);

            //var size = (uint)vertices.Length * sizeof(float);
            //gl.BufferData((int)GLEnum.ArrayBuffer, new UIntPtr(size), vertices, (int)GLEnum.StaticDraw);
        }

        public void OnRender(double delta)
        {
            gl.Clear((uint)GLEnum.ColorBufferBit);

            window.SwapBuffers();
        }

        public void OnResize(Size size)
        {
            gl.Viewport(0, 0, (uint)size.Width, (uint)size.Height);
        }
    }
}