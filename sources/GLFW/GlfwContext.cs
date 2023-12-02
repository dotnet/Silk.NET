namespace Silk.NET.GLFW;

/// <summary>
/// Represents an OpenGL context held by a GLFW window.
/// </summary>
/// <param name="window">The window.</param>
/// <param name="glfw">The API object.</param>
public unsafe class GlfwContext(Window* window, IGlfw glfw) : IGLContext
{
    /// <summary>
    /// Creates a <see cref="GlfwContext"/> using GLFW's static default.
    /// </summary>
    /// <param name="window">The window.</param>
    public GlfwContext(Window* window)
        : this(window, new Glfw.StaticWrapper<Glfw>()) { }

    public void Dispose() { }

    public void* LoadFunction(string functionName, string libraryNameHint) =>
        glfw.GetProcAddress(functionName);

    public bool IsCurrent => glfw.GetCurrentContext() == window;

    public void SwapInterval(int interval) => glfw.SwapInterval(interval);

    public void SwapBuffers() => glfw.SwapBuffers(window);

    public void MakeCurrent() => glfw.MakeContextCurrent(window);

    public void Clear() => glfw.MakeContextCurrent(nullptr);
}
