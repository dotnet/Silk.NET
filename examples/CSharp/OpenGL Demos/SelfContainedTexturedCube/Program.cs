using System.Drawing;
using Silk.NET.Maths;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;

namespace SelfContainedTexturedCube;

public class Program
{
    private static IWindow _window;
    private static GL _gl;
    
    public static void Main(string[] args)
    {
        WindowOptions options = WindowOptions.Default with
        {
            Title = "Self Contained Textured Cube Demo",
            Size = new Vector2D<int>(1280, 720)
        };

        _window = Window.Create(options);
        _window.Load += Initialize;
        _window.Update += Update;
        _window.Render += Draw;
        
        _window.Run();
        
        _window.Dispose();
    }

    private static void Initialize()
    {
        _gl = _window.CreateOpenGL();

        _gl.ClearColor(Color.Indigo);
    }

    private static void Update(double dt)
    {
        
    }

    private static void Draw(double dt)
    {
        _gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
    }
}
