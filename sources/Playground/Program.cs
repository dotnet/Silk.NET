// See https://aka.ms/new-console-template for more information

// TODO bool-like

using Silk.NET.GLFW;
using Silk.NET.OpenGL;

unsafe
{
    if (Glfw.Init() == 0)
    {
        throw new Exception("failed to init");
    }

    Glfw.WindowHint(Glfw.Constants.ClientApi, Glfw.Constants.OpenglApi);
    Glfw.WindowHint(Glfw.Constants.OpenglProfile, Glfw.Constants.OpenglCoreProfile);
    Glfw.WindowHint(Glfw.Constants.ContextVersionMajor, 3);
    Glfw.WindowHint(Glfw.Constants.ContextVersionMinor, 3);
    var window = Glfw.CreateWindow(1000, 800, "Hello Window!", nullptr, nullptr);
    if (window == nullptr)
    {
        // TODO const correctness
        Ref<sbyte> error = nullptr;
        if (Glfw.GetError(error.AsRef2D()) == 0 || error == nullptr)
        {
            throw new Exception("failed to create window and failed to get error");
        }

        throw new Exception($"failed to create window: {(string)error}");
    }

    GL.ThisThread.MakeCurrent(GL.Create(new GlfwContext(window)));

    float[] vertices = { -0.5f, -0.5f, 0.0f, 0.5f, -0.5f, 0.0f, 0.0f, 0.5f, 0.0f };

    uint vao = 0;
    uint vbo = 0;
    GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
    GL.GenBuffers(1, vbo.AsRef());
    GL.BindBuffer(GL.Constants.ArrayBuffer, vbo);
    GL.BufferData(
        GL.Constants.ArrayBuffer,
        vertices.Length * sizeof(float),
        vertices[0].AsRef(), // TODO simplify this
        GL.Constants.StaticDraw
    );
    GL.GenVertexArrays(1, vao.AsRef());
    GL.BindVertexArray(vao);
    GL.VertexAttribPointer(
        0,
        3,
        GL.Constants.Float,
        0, // TODO bool
        3 * sizeof(float),
        nullptr
    );
    GL.EnableVertexAttribArray(0);
    var vert = GL.CreateShader(GL.Constants.VertexShader);
    var frag = GL.CreateShader(GL.Constants.FragmentShader);
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
        GL.Clear(GL.Constants.ColorBufferBit);
        GL.DrawArrays(GL.Constants.Triangles, 0, 3);
        Glfw.SwapBuffers(window);
        Glfw.PollEvents();
    }

    Glfw.DestroyWindow(window);
    Glfw.Terminate();
}
