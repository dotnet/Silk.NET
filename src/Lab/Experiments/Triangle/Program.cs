#define REOPEN_EXPERIMENT

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using SampleBase;
using Silk.NET.Core.Native;
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
        private static IView _window;
        private static Shader _shader;
        
        public static GraphicsAPI API { get; set; } = GraphicsAPI.Default;

#if !NET6_0
        // Exclude the entry point if we're running in .NET 6, as this file is
        // compiled into the TriangleNET6 project too which has its own
        // entrypoint.
        public static void Main() => Run();
#endif

        public static void Run()
        {
            //Silk.NET.Windowing.Sdl.SdlWindowing.Use();
            //SdlProvider.SetMainReady = true;
            var opts = ViewOptions.Default;
            opts.FramesPerSecond = 90;
            opts.UpdatesPerSecond = 90;
            opts.API = API;
            opts.VSync = false;
            if (Window.IsViewOnly)
            {
                _window = Window.GetView(opts);
            }
            else
            {
                _window = Window.Create(new(opts));
            }

            _window.Load += Load;
            _window.Load += InputTest.Program.OnLoad(_window);
            _window.Render += RenderFrame;
            _window.Update += UpdateFrame;
            _window.FramebufferResize += Resize;
            _window.Closing += End;
            _window.Run();
#if REOPEN_EXPERIMENT
            // Experiment notes:
            // - This is something we're meant to support, but we've never tested it!
            // - GLFW worked fine, bar input which for some reason didn't work when the window reloaded.
            // - SDL worked flawlessly.
            // - Right now the Closing event can actually cancel window closure using IsClosing.
            //     - We need to test this too.
            //     - We need to add an Unload event that is only called once the window is guaranteed to be terminated.
            // - TODO for 3.0 (to add the Unload event, by all means fix bugs before then)
            if (_window is IWindow)
            {
                _window.Run();
            }
#endif
        }

        private static unsafe void Load()
        {
            _gl = GL.GetApi(_window);
            Console.WriteLine("=== BEGIN OPENGL INFORMATION");
            foreach (StringName val in Enum.GetValues(typeof(StringName)))
            {
                Console.WriteLine($"{val} = {SilkMarshal.PtrToString((nint) _gl.GetString((GLEnum) val))}");
            }
            Console.WriteLine("=== END OPENGL INFORMATION");

            if (API.API == ContextAPI.OpenGL)
            {
                _gl.Enable(GLEnum.DebugOutput);
                _gl.Enable(GLEnum.DebugOutputSynchronous);
                _gl.DebugMessageCallback(OnDebug, null);
            }

            _gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            fixed (uint* vbo = &_vertexBufferObject)
            {
                _gl.GenBuffers(1, vbo);
            }

            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            fixed (float* vertices = _vertices)
            {
                _gl.BufferData
                    (GLEnum.ArrayBuffer, (nuint)( _vertices.Length * sizeof(float)), vertices, GLEnum.StaticDraw);
            }

#if NET6_0
            _shader = new Shader("TriangleNET6.shader.vert", "TriangleNET6.shader.frag", _gl, typeof(Program));
#else
            _shader = new Shader("Triangle.shader.vert", "Triangle.shader.frag", _gl, typeof(Program));
#endif
            _shader.Use();
            fixed (uint* vao = &_vertexArrayObject)
            {
                _gl.GenVertexArrays(1, vao);
            }

            _gl.BindVertexArray(_vertexArrayObject);
            _gl.VertexAttribPointer(0, 3, GLEnum.Float, false, 3 * sizeof(float), null);
            _gl.EnableVertexAttribArray(0);
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            _gl.Viewport(0, 0, (uint) _window.FramebufferSize.X, (uint) _window.FramebufferSize.Y);
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
            (GLEnum source, GLEnum type, int id, GLEnum severity, int length, nint message, nint userparam)
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
            _gl.Viewport(0, 0, (uint) size.X, (uint) size.Y);
        }

        private static unsafe void End()
        {
            Console.WriteLine("Ending...");
            _gl.BindBuffer(GLEnum.ArrayBuffer, 0);
            _gl.BindVertexArray(0);
            _gl.UseProgram(0);
            fixed (uint* vbo = &_vertexBufferObject)
            {
                _gl.DeleteBuffers(1, vbo);
            }

            fixed (uint* vao = &_vertexArrayObject)
            {
                _gl.DeleteVertexArrays(1, vao);
            }

            _gl.DeleteProgram(_shader.Handle);
        }
    }
}
