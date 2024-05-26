// See https://aka.ms/new-console-template for more information

using Silk.NET.GLFW;
using Silk.NET.OpenGL;
using Buffer = Silk.NET.OpenGL.Buffer;

unsafe
{
    if (Glfw.Init() == 0)
    {
        throw new Exception("failed to init");
    }

    Glfw.WindowHint(Glfw.Constants.ClientApi, Glfw.Constants.OpenglApi);
    Glfw.WindowHint(Glfw.Constants.OpenglProfile, Glfw.Constants.OpenglCoreProfile);
    Glfw.WindowHint(Glfw.Constants.OpenglForwardCompat, Glfw.Constants.True);
    Glfw.WindowHint(Glfw.Constants.ContextVersionMajor, 3);
    Glfw.WindowHint(Glfw.Constants.ContextVersionMinor, 3);
    var window = Glfw.CreateWindow(1000, 800, "Hello Window!", nullptr, nullptr);
    if (window == nullptr)
    {
        Ref<sbyte> error = nullptr;
        if (Glfw.GetError(error.AsRef2D()) == 0 || error == nullptr)
        {
            throw new Exception("failed to create window and failed to get error");
        }

        throw new Exception($"failed to create window: {(string)error}");
    }

    GL.ThisThread.MakeCurrent(GL.Create(new GlfwContext(window)));

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

    while (Glfw.WindowShouldClose(window) == 0)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit);
        GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        Glfw.SwapBuffers(window);
        Glfw.PollEvents();
    }

    GL.DeleteVertexArray(vao);
    GL.DeleteBuffer(vbo);
    Glfw.DestroyWindow(window);
    Glfw.Terminate();
}
