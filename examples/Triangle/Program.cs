using System;
using System.Drawing;
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
            -0.5f, -0.5f, 0.0f,
             0.5f, -0.5f, 0.0f,
             0.0f,  0.5f, 0.0f
        };

        private static uint _vertexBufferObject;
        private static uint _vertexArrayObject;
        private static uint _shader;
        private static GL _gl;
        private static IInputContext _input;
        private static IWindow _window;

        private const string VertexShader = "#version 330\n\n" +

                                             "out vec4 outputColor;\n\n" +

                                             "void main()\n" +
                                             "{\n" +
                                             "    outputColor = vec4(1.0, 1.0, 0.0, 1.0);\n" +
                                             "}\n";

        private const string FragmentShader = "#version 330 core\n\n" +

                                               "layout(location = 0) in vec3 aPosition;\n\n" +

                                               "void main(void)\n" +
                                               "{\n" +
                                               "    gl_Position = vec4(aPosition, 1.0);\n" +
                                               "}\n";

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
            _gl ??= GL.GetApi();
            var vertShader = _gl.CreateShader(GLEnum.VertexShader);
            var fragShader = _gl.CreateShader(GLEnum.FragmentShader);
            var vertLen = VertexShader.Length;
            _gl.ShaderSource(vertShader, 1, SilkMarshal.ToPointer(new []{VertexShader}), &vertLen);
            var fragLen = FragmentShader.Length;
            _gl.ShaderSource(fragShader, 1, SilkMarshal.ToPointer(new []{FragmentShader}), &fragLen);
            _gl.CompileShader(vertShader);
            _gl.CompileShader(fragShader);
            _shader = _gl.CreateProgram();
            _gl.AttachShader(_shader, vertShader);
            _gl.AttachShader(_shader, fragShader);
            _gl.LinkProgram(_shader);
            _gl.DetachShader(_shader, vertShader);
            _gl.DetachShader(_shader, fragShader);
            _gl.DeleteShader(fragShader);
            _gl.DeleteShader(vertShader);
            _gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = _gl.GenBuffer();
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            fixed (void* vertices = _vertices)
            {
                _gl.BufferData(GLEnum.ArrayBuffer, (uint) _vertices.Length * sizeof(float), vertices, GLEnum.StaticDraw);
            }

            _vertexArrayObject = _gl.GenVertexArray();
            _gl.BindVertexArray(_vertexArrayObject);
            var attrib = 0;
            _gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), &attrib);
            _gl.EnableVertexAttribArray(0);
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            Console.WriteLine("done load");
        }


        private static void RenderFrame(double delta)
        {
            _gl.Clear((uint)GLEnum.ColorBufferBit);
            _gl.UseProgram(_shader);
            _gl.BindVertexArray(_vertexArrayObject);
            _gl.DrawArrays(GLEnum.Triangles, 0, 3);
        }


        private static void UpdateFrame(double delta)
        {
            _input ??= _window.GetInput();
            if (_input.Keyboards[0].IsKeyPressed(Key.Escape))
            {
                _window.Close();
            }
        }

        private static void Resize(Size size)
        {
            _gl.Viewport(0, 0, (uint) size.Width, (uint) size.Height);
            Console.WriteLine("done resize");
        }
        
        private static void End()
        {
            _gl.BindBuffer(GLEnum.ArrayBuffer, 0);
            _gl.BindVertexArray(0);
            _gl.UseProgram(0);
            _gl.DeleteBuffer(_vertexBufferObject);
            _gl.DeleteVertexArray(_vertexArrayObject);
            _gl.DeleteProgram(_shader);
        }
    }
}
