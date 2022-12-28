#define REOPEN_EXPERIMENT

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using SampleBase;
using Silk.NET.Input.Sdl;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;
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

#if !ANDROID
        // Exclude the entry point if we're running in .NET 6, as this file is
        // compiled into the TriangleNET6 project too which has its own
        // entrypoint.
        public static void Main() => Run();
#endif

        public static void Run()
        {
            Console.WriteLine("Start");
            #if WASM //NOTE: not having this WASM check changes nothing, but it's here for clarity
            // Register SDL windowing and Input manually
            // Silk.NET doesn't have all the reflection facilities to find them automatically on WASM
            Console.WriteLine("Before Window registration");
            SdlWindowing.RegisterPlatform();
            Console.WriteLine("Before Input registration");
            SdlInput.RegisterPlatform();
            #endif
            
            var opts = ViewOptions.Default;
            opts.FramesPerSecond = 90;
            opts.UpdatesPerSecond = 90;
            opts.API = API;
            
            #if WASM
            //On WASM, we should be using OpenGLES 3.0
            opts.API = new GraphicsAPI(ContextAPI.OpenGLES, new APIVersion(3, 0));
            #endif
            
            opts.VSync = false;
            Console.WriteLine("Before window creation");
            Console.WriteLine(Window.Platforms.Count);
            if (Window.IsViewOnly)
            {
                Console.WriteLine("View only");
                _window = Window.GetView(opts);
            }
            else
            {
                Console.WriteLine("Not view only");
                _window = Window.Create(new(opts));
            }
            Console.WriteLine($"After window creation");

            Console.WriteLine($"before setting events");
            _window.Load += Load;
            _window.Load += InputTest.Program.OnLoad(_window);
            _window.Render += RenderFrame;
            _window.Update += UpdateFrame;
            _window.FramebufferResize += Resize;
            _window.Closing += End;
            Console.WriteLine("Before window run");
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
            Console.WriteLine("Before GL");
            _gl = _window.CreateOpenGL();
            // Console.WriteLine("=== BEGIN OPENGL INFORMATION");
            // foreach (StringName val in Enum.GetValues(typeof(StringName)))
            // {
            //     Console.WriteLine($"{val} = {_gl.GetStringS(val)}");
            // }
            // Console.WriteLine("=== END OPENGL INFORMATION");

            if (API.API == ContextAPI.OpenGL)
            {
                _gl.Enable(GLEnum.DebugOutput);
                _gl.Enable(GLEnum.DebugOutputSynchronous);
                _gl.DebugMessageCallback(OnDebug, null);
            }

            Console.WriteLine("Before clear");
            _gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = _gl.GenBuffer();
            _gl.BindBuffer(GLEnum.ArrayBuffer, _vertexBufferObject);
            fixed (float* vertices = _vertices)
            {
                Console.WriteLine("Before buffer");
                _gl.BufferData
                    (GLEnum.ArrayBuffer, (nuint)( _vertices.Length * sizeof(float)), vertices, GLEnum.StaticDraw);
            }

            Console.WriteLine("Before shader");
#if ANDROID
            _shader = new Shader("TriangleNET6.shader.vert", "TriangleNET6.shader.frag", _gl, typeof(Program));
#else
            _shader = new Shader("Triangle.shader.vert", "Triangle.shader.frag", _gl, typeof(Program));
#endif
            Console.WriteLine("After shader");
            
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
