// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.OpenGL;
using Silk.NET.SDL;

if (!Sdl.Init(uint.MaxValue))
{
    throw new Exception($"failed to init: {(string)Sdl.GetError()}");
}

var window = Sdl.CreateWindow(
    "Hello Window!",
    1000,
    800,
    Sdl.WindowOpengl | Sdl.WindowHighPixelDensity | Sdl.WindowResizable
);
if (window == nullptr)
{
    throw new Exception($"failed to create window: {(string)Sdl.GetError()}");
}

Console.WriteLine(
    $"SDL_GetDisplayContentScale {Sdl.GetDisplayContentScale(Sdl.GetDisplayForWindow(window))}"
);
Console.WriteLine($"SDL_GetWindowDisplayScale {Sdl.GetWindowDisplayScale(window)}");
Console.WriteLine($"SDL_GetWindowPixelDensity {Sdl.GetWindowPixelDensity(window)}");
int sx = 0,
    sy = 0,
    px = 0,
    py = 0;
Sdl.GetWindowSize(window, sx.AsRef(), sy.AsRef());
Sdl.GetWindowSizeInPixels(window, px.AsRef(), py.AsRef());
Console.WriteLine($"SDL_GetWindowSize {sx} {sy}");
Console.WriteLine($"SDL_GetWindowSizeInPixels {px} {py}");

var context = new SdlContext(
    window,
    new KeyValuePair<GLAttr, int>(GLAttr.ContextMajorVersion, 3),
    new KeyValuePair<GLAttr, int>(GLAttr.ContextMinorVersion, 3),
    new KeyValuePair<GLAttr, int>(GLAttr.ContextProfileMask, Sdl.GlContextProfileCore),
    new KeyValuePair<GLAttr, int>(
        GLAttr.ContextFlags,
        Sdl.GlContextForwardCompatibleFlag | Sdl.GlContextDebugFlag
    )
);
GL.ThisThread.MakeCurrent(GL.Create(context));

float[] vertices = { -0.5f, -0.5f, 0.0f, 0.5f, -0.5f, 0.0f, 0.0f, 0.5f, 0.0f };

var vbo = GL.GenBuffer();
GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
GL.BufferData(
    BufferTarget.ArrayBuffer,
    (nuint)(vertices.Length * sizeof(float)),
    vertices[0].AsRef(), // TODO simplify this
    BufferUsage.StaticDraw
);

var vao = GL.GenVertexArray();
GL.BindVertexArray(vao);
GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), nullptr);
GL.EnableVertexAttribArray(0);
var vert = GL.CreateShader(ShaderType.VertexShader);
var frag = GL.CreateShader(ShaderType.FragmentShader);
const string vertSource = """
    #version 330 core
    layout(location = 0) in vec3 aPosition;
    void main(void)
    {
        gl_Position = vec4(aPosition, 1.0);
    }
    """;
var vertSourceLength = vertSource.Length;
GL.ShaderSource(vert, 1, new[] { vertSource }, vertSourceLength.AsRef());
const string fragSource = """
    #version 330
    out vec4 outputColor;
    void main()
    {
        outputColor = vec4(1.0, 0.5, 0.2, 1.0);
    }
    """;
var fragSourceLength = fragSource.Length;
GL.ShaderSource(frag, 1, new[] { fragSource }, fragSourceLength.AsRef());
GL.CompileShader(vert);
GL.CompileShader(frag);
var prog = GL.CreateProgram();
GL.AttachShader(prog, vert);
GL.AttachShader(prog, frag);
GL.LinkProgram(prog);
GL.DeleteShader(vert);
GL.DeleteShader(frag);
GL.UseProgram(prog);

Event @event = default;
while (true)
{
    if (Sdl.PollEvent(@event.AsRef()))
    {
        Console.WriteLine((EventType)@event.Type);
        if (@event.Type == (int)EventType.Quit)
        {
            break;
        }
    }

    if (@event.Window.Type == EventType.WindowDisplayScaleChanged)
    {
        Console.WriteLine(
            $"SDL_GetDisplayContentScale {Sdl.GetDisplayContentScale(Sdl.GetDisplayForWindow(window))}"
        );
        Console.WriteLine($"SDL_GetWindowDisplayScale {Sdl.GetWindowDisplayScale(window)}");
        Console.WriteLine($"SDL_GetWindowPixelDensity {Sdl.GetWindowPixelDensity(window)}");
    }

    if (@event.Window.Type == EventType.WindowResized)
    {
        Sdl.GetWindowSize(window, sx.AsRef(), sy.AsRef());
        Sdl.GetWindowSizeInPixels(window, px.AsRef(), py.AsRef());
        Console.WriteLine($"SDL_GetWindowSize {sx} {sy}");
        Console.WriteLine($"SDL_GetWindowSizeInPixels {px} {py}");
    }

    GL.Clear(ClearBufferMask.ColorBufferBit);
    GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
    context.SwapBuffers();
}

GL.DeleteVertexArray(vao);
GL.DeleteBuffer(vbo);
Sdl.DestroyWindow(window);
Sdl.Quit();
