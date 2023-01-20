using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Silk.NET.Windowing;
using Silk.NET.Input;
using Silk.NET.OpenGL;

WindowOptions windowOptions = WindowOptions.Default with
{
    Title = "My Silk.NET Triangle",
    PreferredDepthBufferBits = 24,
    PreferredStencilBufferBits = 8,
    API = new GraphicsAPI(ContextAPI.OpenGL, new APIVersion(3, 3))
};

using IWindow window = Window.Create(windowOptions);
IInputContext inputContext = null!;
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
    inputContext = window.CreateInput();

    // We create a Span with our vertex data. Since it's very little
    // data, we'll just allocate it in the stack.
    Span<Vertex> vertexData = stackalloc Vertex[]
    {
        new Vertex(new Vector3(-0.5f, -0.5f, 0), 255, 0, 0, 255),
        new Vertex(new Vector3(0, 0.5f, 0), 0, 255, 0, 255),
        new Vertex(new Vector3(0.5f, -0.5f, 0), 0, 0, 255, 255)
    };

    // We create or GL Buffer Object, bind it and fill it up with data
    // from our span.
    vbo = gl.GenBuffer();
    gl.BindBuffer(BufferTargetARB.ArrayBuffer, vbo);
    gl.BufferData<Vertex>(BufferTargetARB.ArrayBuffer, vertexData, BufferUsageARB.StaticDraw);

    // We create or GL Vertex Array Object, bind it and specify two
    // vertex attributes sourced from the currently bound buffer;
    // Attrib 0: 3 floats (a vec3)
    // Attrib 1: 4 unsigned bytes, normalized into a vec4
    vao = gl.GenVertexArray();
    gl.BindVertexArray(vao);
    unsafe
    {
        gl.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, Vertex.Size, (void*)0);
        gl.VertexAttribPointer(1, 4, VertexAttribPointerType.UnsignedByte, true, Vertex.Size, (void*)12);
    }
    gl.EnableVertexAttribArray(0);
    gl.EnableVertexAttribArray(1);

    // We create the vertex shader, give it it's source code, and compile.
    uint vs = gl.CreateShader(ShaderType.VertexShader);
    gl.ShaderSource(vs, VertexShaderCode);
    gl.CompileShader(vs);

    // We create the fragment shader, give it it's source code, and compile.
    uint fs = gl.CreateShader(ShaderType.FragmentShader);
    gl.ShaderSource(fs, FragmentShaderCode);
    gl.CompileShader(fs);

    // We create the GL Shader Program Object, which links the vertex and
    // fragment shaders into a single program.
    shader = gl.CreateProgram();
    gl.AttachShader(shader, vs);
    gl.AttachShader(shader, fs);
    gl.LinkProgram(shader);

    // We detach the shaders from the program and delete them. This won't
    // have any effect until the program itself is re-linked or deleted.
    gl.DetachShader(shader, vs);
    gl.DetachShader(shader, fs);
    gl.DeleteShader(vs);
    gl.DeleteShader(fs);

    gl.Viewport(window.FramebufferSize);
};

window.Update += deltaSeconds =>
{
    // ran every frame but before render - use this event to update data (e.g. physics).
};

window.Render += deltaSeconds =>
{
    // ran every frame but after update - use this event to draw.

    // Clear the whole screen to black.
    gl.ClearColor(0f, 0f, 0f, 1f);
    gl.Clear(ClearBufferMask.ColorBufferBit);

    // Draw the 3 vertices from our buffer object as a single triangle.
    gl.BindVertexArray(vao);
    gl.UseProgram(shader);
    gl.DrawArrays(PrimitiveType.Triangles, 0, 3);
};

window.FramebufferResize += newSize =>
{
    // ran when the window framebuffer is resized - usually used to update the viewport and, in 3D apps, view matrices.
    gl.Viewport(newSize);
};

window.Closing += () =>
{
    // ran just before the window closes.
    gl.DeleteProgram(shader);
    gl.DeleteVertexArray(vao);
    gl.DeleteBuffer(vbo);
};

window.Run();
gl.Dispose();
inputContext.Dispose();

[StructLayout(LayoutKind.Sequential)]
record struct Vertex(Vector3 Position, byte R, byte G, byte B, byte A)
{
    public static uint Size = 3 * 4 + 4;
}