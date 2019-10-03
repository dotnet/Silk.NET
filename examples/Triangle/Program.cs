using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using SampleBase;
using Silk.NET.Core.Native;
using Silk.NET.Input;
using Silk.NET.Input.Common;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Common;

namespace Triangle
{
    public static class Program
    {
        private static readonly float[] _vertices =
        {
            -0.5f, -0.5f, 0.0f, // Bottom-left vertex
            0.5f, -0.5f, 0.0f, // Bottom-right vertex
            0.0f,  0.5f, 0.0f  // Top vertex
        };
        private static uint _vertexBufferObject;
        private static uint _vertexArrayObject;
        private static GL _gl;
        private static IWindow _window;
        private static Shader _shader;

        public static void Main(string[] args)
        {
            _window = Window.Create(WindowOptions.Default);
            _window.Load += Load;
            _window.Render += RenderFrame;
            _window.Update += UpdateFrame;
            _window.Resize += Resize;
            _window.Run();
            End();
        }

        private static unsafe void Load()
        {
            _gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = _gl.GenBuffer();
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            fixed (float* vertices = _vertices)
            {
                _gl.BufferData(GLEnum.ArrayBuffer, (uint)_vertices.Length * sizeof(float), vertices, GLEnum.StaticDraw);
            }
            
            // shader.vert and shader.frag contain the actual shader code.

            _shader = new Shader("Triangle.shader.vert", "Triangle.shader.frag", _gl, typeof(Program));
            _shader.Use();
            _vertexArrayObject = _gl.GenVertexArray();
            _gl.BindVertexArray(_vertexArrayObject);
            _gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), 0);
            _gl.EnableVertexAttribArray(0);
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
        }

        private static void OnDebug(GLEnum source, GLEnum type, int id, GLEnum severity, int length, IntPtr message, IntPtr userparam)
        {
            Console.WriteLine
            (
                $"|{severity.ToString().Substring(13)}| {type.ToString().Substring(9)}/{id}: {Marshal.PtrToStringAnsi(message)}"
            );
        }

        private static void RenderFrame(double delta)
        {
            _gl.Clear((uint) GLEnum.ColorBufferBit);
            _shader.Use();
            _gl.BindVertexArray(_vertexArrayObject);
            _gl.DrawArrays(GLEnum.Triangles, 0, 3);
        }


        private static void UpdateFrame(double delta)
        {
        }

        private static void Resize(Size size)
        {
            _gl.Viewport(0, 0, (uint) size.Width, (uint) size.Height);
            Console.WriteLine("done resize");
        }
        
        private static void End()
        {
        }
    }
}
