using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private static DebugProc _onDebug;
        private static GCHandle _onDebugHandle;

        private const string FragmentShader = "#version 410 core\n\n" +

                                             "out vec4 outputColor;\n\n" +

                                             "void main()\n" +
                                             "{\n" +
                                             "    outputColor = vec4(1.0f, 0.5f, 0.2f, 1.0f);\n" +
                                             "}\n";

        private const string VertexShader = "#version 410 core\n\n" +

                                               "layout(location = 0) in vec3 aPosition;\n\n" +

                                               "void main()\n" +
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
            _onDebug = OnDebug;
            _onDebugHandle = GCHandle.Alloc(_onDebug);
            _gl.DebugMessageCallback(_onDebug, (void*)0);
            _gl.Enable(GLEnum.DebugOutput);
            _gl.Enable(GLEnum.DebugOutputSynchronous);
            var vertShader = _gl.CreateShader(GLEnum.VertexShader);
            var fragShader = _gl.CreateShader(GLEnum.FragmentShader);
            var vertLen = VertexShader.Length;
            var vertArr = new[] {VertexShader}.Select
            (
                Marshal.StringToHGlobalAnsi
            ).ToArray();
            fixed (IntPtr* ss = vertArr)
            _gl.ShaderSource(vertShader, 1, (char**)ss, &vertLen);
            var fragLen = FragmentShader.Length;
            var fragArr = new[] {FragmentShader}.Select
            (
                Marshal.StringToHGlobalAnsi
            ).ToArray();
            fixed (IntPtr* ss = fragArr)
            _gl.ShaderSource(fragShader, 1, (char**)ss, &fragLen);
            _gl.CompileShader(vertShader);
            CheckShaderErrors(vertShader);
            _gl.CompileShader(fragShader);
            CheckShaderErrors(fragShader);
            _shader = _gl.CreateProgram();
            _gl.AttachShader(_shader, vertShader);
            _gl.AttachShader(_shader, fragShader);
            _gl.LinkProgram(_shader);
            CheckProgramErrors(_shader);
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

        private static void OnDebug(GLEnum source, GLEnum type, int id, GLEnum severity, int length, IntPtr message, IntPtr userparam)
        {
            Console.WriteLine
            (
                $"|{severity.ToString().Substring(13)}| {type.ToString().Substring(9)}/{id}: {Marshal.PtrToStringAnsi(message)}"
            );
        }

        private static void CheckShaderErrors(uint shader)
        {
            _gl.GetShader(shader, GLEnum.CompileStatus, out var status);
            if (status != 1)
            {
                _gl.DebugMessageInsert
                (
                    GLEnum.DebugSourceApplication, GLEnum.DebugTypeError, 900110, GLEnum.DebugSeverityHigh,
                    19u + (uint) shader.ToString().Length, $"{shader} failed to compile."
                );
                var str = new string(' ', 1024);
                _gl.GetShaderInfoLog(shader, 1024u, out uint length, str);
                str = str.Substring(0, (int)length);
                _gl.DebugMessageInsert
                (
                    GLEnum.DebugSourceApplication, GLEnum.DebugTypeError, 900111, GLEnum.DebugSeverityHigh,
                    length, str
                );
            }
        }

        private static void CheckProgramErrors(uint program)
        {
            _gl.GetProgram(program, GLEnum.LinkStatus, out var status);
            if (status != 1)
            {
                _gl.GetProgram(program, GLEnum.InfoLogLength, out var len2);
                _gl.DebugMessageInsert
                (
                    GLEnum.DebugSourceApplication, GLEnum.DebugTypeError, 900112, GLEnum.DebugSeverityHigh,
                    19u + (uint) program.ToString().Length, $"{program} failed to compile. " + len2
                );
                var str = new string(' ', 1024);
                _gl.GetProgramInfoLog(program, 1024, out var length, str);
                str = str.Substring(0, (int)length);
                _gl.DebugMessageInsert
                (
                    GLEnum.DebugSourceApplication, GLEnum.DebugTypeError, 900113, GLEnum.DebugSeverityHigh,
                    length, str
                );
            }
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
