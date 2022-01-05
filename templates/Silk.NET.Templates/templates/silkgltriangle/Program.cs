using System;
using System.Numerics;
using Silk.NET.Windowing;
using Silk.NET.OpenGL;

WindowOptions windowOptions = WindowOptions.Default;
windowOptions.Title = "My Silk.NET Triangle";
windowOptions.PreferredDepthBufferBits = 0;
windowOptions.PreferredStencilBufferBits = 0;
windowOptions.API = new GraphicsAPI(ContextAPI.OpenGL, new APIVersion(3, 3));
using IWindow window = Window.Create(windowOptions);
GL gl = null!;

uint vbo = 0;
uint vao = 0;
uint shader = 0;

const string VertexShaderCode = @"
#version 330 core
layout (location = 0) in vec3 vPosition;
layout (location = 1) in vec4 vColor;

out vec4 fColor;

void main() {
    gl_Position = vec4(vPosition, 1.0);
    fColor = vColor;
}";

const string FragmentShaderCode = @"
#version 330 core
in vec4 fColor;

out vec4 FragColor;

void main() {
    FragColor = fColor;
}";

window.Load += () =>
{
    // ran on first startup - use this event to initialize stuff.
    gl = window.CreateOpenGL();

    vbo = gl.GenBuffer();
    gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);

    Span<Vertex> vertexData = stackalloc Vertex[]
    {
        new Vertex(new Vector3(-0.5f, -0.5f, 0), 255, 0, 0, 255),
        new Vertex(new Vector3(0, 0.5f, 0), 0, 255, 0, 255),
        new Vertex(new Vector3(0.5f, -0.5f, 0), 0, 0, 255, 255)
    };

    gl.BufferData<Vertex>(BufferTargetARB.ArrayBuffer, vertexData, BufferUsageARB.StaticDraw);

    vao = gl.GenVertexArray();
    gl.BindVertexArray(vao);
    unsafe
    {
        gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Vertex.Size, (void*)0);
        gl.VertexAttribPointer(1, 4, VertexAttribPointerType.UnsignedByte, true, Vertex.Size, (void*)12);
    }
    gl.EnableVertexAttribArray(0);
    gl.EnableVertexAttribArray(1);

    uint vs = gl.CreateShader(ShaderType.VertexShader);
    gl.ShaderSource(vs, VertexShaderCode);
    gl.CompileShader(vs);

    uint fs = gl.CreateShader(ShaderType.FragmentShader);
    gl.ShaderSource(fs, FragmentShaderCode);
    gl.CompileShader(fs);

    shader = gl.CreateProgram();
    gl.AttachShader(shader, vs);
    gl.AttachShader(shader, fs);
    gl.LinkProgram(shader);
    gl.DetachShader(shader, vs);
    gl.DetachShader(shader, fs);
    gl.DeleteShader(vs);
    gl.DeleteShader(fs);

    gl.Viewport(window.Size);
};

window.Update += deltaSeconds =>
{
    // ran every frame but before render - use this event to update data (e.g. physics).
};

window.Render += deltaSeconds =>
{
    // ran every frame but after update - use this event to draw.
    gl.ClearColor(0f, 0f, 0f, 1f);
    gl.Clear(ClearBufferMask.ColorBufferBit);

    gl.BindVertexArray(vao);
    gl.UseProgram(shader);
    gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
};

window.FramebufferResize += newSize =>
{
    // ran when the window is resized - usually used to update the viewport and, in 3D apps, view matrices.
    gl.Viewport(newSize);
};

window.Closing += () =>
{
    gl.DeleteProgram(shader);
    gl.DeleteVertexArray(vao);
    gl.DeleteBuffer(vbo);
    // ran just before the window closes.
};

window.Run();
gl.Dispose();

struct Vertex
{
    public static uint Size = 3 * 4 + 4;

    Vector3 Position;
    byte R, G, B, A;

    public Vertex(Vector3 position, byte r, byte g, byte b, byte a)
    {
        Position = position;
        R = r;
        G = g;
        B = b;
        A = a;
    }
}