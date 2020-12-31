#define MINIMAL

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using SampleBase;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using SdlProvider = Silk.NET.SDL.SdlProvider;
using Shader = SampleBase.Shader;

namespace Triangle
{
    public static class Program
    {
        private static readonly float[] _vertices =
        {
            -0.5f, -0.5f, 0.0f, // Bottom-left vertex
            0.5f, -0.5f, 0.0f, // Bottom-right vertex
            0.0f, 0.5f, 0.0f // Top vertex
        };

        private static uint _vertexBufferObject;
        private static uint _vertexArrayObject;
        private static GL _gl;
#if MINIMAL
        private static IView _window;
#else
        private static IWindow _window;
#endif
        private static Shader _shader;
        
        public static GraphicsAPI API { get; set; } = GraphicsAPI.Default;

        public static void Main(string[] args)
        {
            //SdlProvider.SetMainReady = true;
#if MINIMAL
            var opts = ViewOptions.Default;
            opts.FramesPerSecond = 90;
            opts.UpdatesPerSecond = 90;
            opts.API = API;
            opts.VSync = false;
            _window = Window.GetView(opts);
#else
            var opts = WindowOptions.Default;
            opts.FramesPerSecond = 90;
            opts.API = API;
            opts.UpdatesPerSecond = 90;
            _window = Window.Create(opts);
#endif
            _window.Load += Load;
            _window.Load += InputTest.Program.OnLoad(_window);
            _window.Render += RenderFrame;
            _window.Update += UpdateFrame;
            _window.FramebufferResize += Resize;
            _window.Closing += End;
            _window.Run();
        }

        private static unsafe void Load()
        {
            _gl = GL.GetApi(_window);
            Console.WriteLine("=== BEGIN OPENGL INFORMATION");
            foreach (StringName val in Enum.GetValues(typeof(StringName)))
            {
                Console.WriteLine($"{val} = {_gl.GetStringS(val)}");
            }
            Console.WriteLine("=== END OPENGL INFORMATION");

            if (API.API == ContextAPI.OpenGL)
            {
                _gl.Enable(GLEnum.DebugOutput);
                _gl.Enable(GLEnum.DebugOutputSynchronous);
                _gl.DebugMessageCallback(OnDebug, null);
            }

            _gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = _gl.GenBuffer();
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            fixed (float* vertices = _vertices)
            {
                _gl.BufferData
                    (GLEnum.ArrayBuffer, (UIntPtr)( _vertices.Length * sizeof(float)), vertices, GLEnum.StaticDraw);
            }

            _shader = new Shader("Triangle.shader.vert", "Triangle.shader.frag", _gl, typeof(Program));
            _shader.Use();
            _vertexArrayObject = _gl.GenVertexArray();
            _gl.BindVertexArray(_vertexArrayObject);
            _gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), null);
            _gl.EnableVertexAttribArray(0);
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            _gl.Viewport(_window.FramebufferSize);
            _window.Update += WindowOnUpdate;
        }

        private static void WindowOnUpdate(double obj)
        {
            if (_window is IWindow w)
            {
                w.Title = "FPS " + Math.Ceiling(1d / obj);
            }
        }

        private static void OnDebug
            (GLEnum source, GLEnum type, int id, GLEnum severity, int length, IntPtr message, IntPtr userparam)
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

        private static void Resize(Vector2D<int> size)
        {
            _gl.Viewport(size);
        }

        private static void End()
        {
            Console.WriteLine("Ending...");
            _gl.BindBuffer(GLEnum.ArrayBuffer, 0);
            _gl.BindVertexArray(0);
            _gl.UseProgram(0);
            _gl.DeleteBuffer(_vertexBufferObject);
            _gl.DeleteVertexArray(_vertexArrayObject);
            _gl.DeleteProgram(_shader.Handle);
        }
    }
}
