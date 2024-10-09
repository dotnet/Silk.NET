// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SDL;

/// <summary>
/// Represents an OpenGL context created using SDL.
/// </summary>
public class SdlContext : IGLContext
{
    /// <summary>
    /// Creates an OpenGL context using SDL.
    /// </summary>
    /// <param name="window">The window to associate the context with.</param>
    /// <param name="attributes">The context attributes.</param>
    /// <param name="sdl">The SDL interface to use. Defaults to <see cref="Sdl.Instance"/></param>
    /// <exception cref="SdlException">If an error occurs when creating the context.</exception>
    public SdlContext(
        WindowHandle window,
        Span<KeyValuePair<GLattr, int>> attributes,
        ISdl? sdl = null
    )
    {
        Api = sdl ?? Sdl.Instance;
        foreach (var (attr, value) in attributes)
        {
            Expect(Api.GLSetAttribute(attr, value), "set OpenGL context attribute");
        }

        Window = window;
        Context = Api.GLCreateContext(window);
        if (Context != nullptr)
        {
            return;
        }

        var ctxError = (string)Api.GetError();
        Api.ClearError();
        throw new SdlException($"Failed to create OpenGL context: {ctxError}");
    }

    /// <summary>
    /// Creates an OpenGL context using SDL.
    /// </summary>
    /// <param name="window">The window to associate the context with.</param>
    /// <param name="attributes">The context attributes.</param>
    /// <param name="sdl">The SDL interface to use.</param>
    /// <exception cref="SdlException">If an error occurs when creating the context.</exception>
    public SdlContext(WindowHandle window, ISdl sdl, params KeyValuePair<GLattr, int>[] attributes)
        : this(window, attributes, sdl) { }

    /// <summary>
    /// Creates an OpenGL context using SDL.
    /// </summary>
    /// <param name="window">The window to associate the context with.</param>
    /// <param name="attributes">The context attributes.</param>
    /// <exception cref="SdlException">If an error occurs when creating the context.</exception>
    public SdlContext(WindowHandle window, params KeyValuePair<GLattr, int>[] attributes)
        : this(window, attributes, Sdl.Instance) { }

    /// <summary>
    /// Creates a <see cref="SdlContext" /> from an existing context handle.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="context">The context handle.</param>
    /// <param name="sdl">The SDL interface to use. Defaults to <see cref="Sdl.Instance"/>.</param>
    public SdlContext(WindowHandle window, Ptr context, ISdl? sdl = null) =>
        (Window, Context, Api) = (window, context, sdl ?? Sdl.Instance);

    /// <summary>
    /// The window associated with this context.
    /// </summary>
    public WindowHandle Window { get; }

    /// <summary>
    /// The context handle.
    /// </summary>
    public Ptr Context { get; }

    /// <summary>
    /// The API interface in use.
    /// </summary>
    public ISdl Api { get; }

    /// <inheritdoc />
    public void Dispose() => Expect(Api.GLDeleteContext((Ref)Context), "dispose OpenGL context");

    /// <inheritdoc />
    public unsafe void* LoadFunction(string functionName, string libraryNameHint)
    {
        var ret = libraryNameHint.Contains("EGL")
            ? Api.EGLGetProcAddress(libraryNameHint)
            : Api.GLGetProcAddress(functionName);
        Api.ClearError();
        return ret;
    }

    /// <inheritdoc />
    public bool IsCurrent => Api.GLGetCurrentContext() == Context;

    /// <inheritdoc />
    public void SwapInterval(int interval) =>
        Expect(Api.GLSetSwapInterval(interval), "set swap interval");

    /// <inheritdoc />
    public void SwapBuffers() => Expect(Api.GLSwapWindow(Window), "swap buffers");

    /// <inheritdoc />
    public void MakeCurrent() =>
        Expect(Api.GLMakeCurrent(Window, (Ref)Context), "make context current");

    /// <inheritdoc />
    public void Clear() => Expect(Api.GLMakeCurrent(Window, (Ref)nullptr), "clear current context");

    private void Expect(int ec, string action)
    {
        if (ec is 0)
        {
            return;
        }

        var err = (string)Api.GetError();
        Api.ClearError();

        Throw(action, err, ec);
        return;

        static void Throw(string act, string err, int ec) =>
            throw new SdlException(
                $"Failed to {act} with error code {(Errorcode)ec} ({ec}): {err}"
            );
    }
}
