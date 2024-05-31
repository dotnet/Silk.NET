// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using Silk.NET.OpenGL;
using Silk.NET.SDL;

var ec = Sdl.Init(uint.MaxValue);
if (ec is not 0)
{
    throw new Exception(
        $"failed to init (error code: {(Errorcode)ec} {ec}): {(string)Sdl.GetError()}"
    );
}

var window = Sdl.CreateWindow("Hello Window!", 1000, 800, Sdl.WindowOpengl);
if (window == nullptr)
{
    throw new Exception($"failed to create window: {(string)Sdl.GetError()}");
}

var context = new SdlContext(
    window,
    new KeyValuePair<GLattr, int>(GLattr.ContextMajorVersion, 3),
    new KeyValuePair<GLattr, int>(GLattr.ContextMinorVersion, 3),
    new KeyValuePair<GLattr, int>(GLattr.ContextProfileMask, (int)GLprofile.Core),
    new KeyValuePair<GLattr, int>(
        GLattr.ContextFlags,
        (int)(GLcontextFlag.ForwardCompatibleFlag | GLcontextFlag.DebugFlag)
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
    if (Sdl.PollEvent(@event.AsRef()) && @event.Type == (int)EventType.Quit)
    {
        break;
    }

    GL.Clear(ClearBufferMask.ColorBufferBit);
    GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
    context.SwapBuffers();
}

GL.DeleteVertexArray(vao);
GL.DeleteBuffer(vbo);
Sdl.DestroyWindow(window);
Sdl.Quit();
