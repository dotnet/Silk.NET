// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SDL;

/// <summary>
/// Represents an OpenGL context created using SDL.
/// </summary>
public class SdlContext : IGlContext
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
        Span<KeyValuePair<GlAttr, int>> attributes,
        ISdl? sdl = null
    )
    {
        Api = sdl ?? Sdl.Instance;
        foreach (var (attr, value) in attributes)
        {
            Expect(Api.GlSetAttribute(attr, value), "set OpenGL context attribute");
        }

        Window = window;
        Context = Api.GlCreateContext(window);
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
    public SdlContext(WindowHandle window, ISdl sdl, params KeyValuePair<GlAttr, int>[] attributes)
        : this(window, attributes, sdl) { }

    /// <summary>
    /// Creates an OpenGL context using SDL.
    /// </summary>
    /// <param name="window">The window to associate the context with.</param>
    /// <param name="attributes">The context attributes.</param>
    /// <exception cref="SdlException">If an error occurs when creating the context.</exception>
    public SdlContext(WindowHandle window, params KeyValuePair<GlAttr, int>[] attributes)
        : this(window, attributes, Sdl.Instance) { }

    /// <summary>
    /// Creates a <see cref="SdlContext" /> from an existing context handle.
    /// </summary>
    /// <param name="window">The window handle.</param>
    /// <param name="context">The context handle.</param>
    /// <param name="sdl">The SDL interface to use. Defaults to <see cref="Sdl.Instance"/>.</param>
    public SdlContext(WindowHandle window, GlContextStateHandle context, ISdl? sdl = null) =>
        (Window, Context, Api) = (window, context, sdl ?? Sdl.Instance);

    /// <summary>
    /// The window associated with this context.
    /// </summary>
    public WindowHandle Window { get; }

    /// <summary>
    /// The context handle.
    /// </summary>
    public GlContextStateHandle Context { get; }

    /// <summary>
    /// The API interface in use.
    /// </summary>
    public ISdl Api { get; }

    /// <inheritdoc />
    public void Dispose() => Expect(Api.GlDestroyContext(Context), "dispose OpenGL context");

    /// <inheritdoc />
    public unsafe void* LoadFunction(string functionName, string libraryNameHint)
    {
        var ret = libraryNameHint.Contains("EGL")
            ? Api.EglGetProcAddress(libraryNameHint)
            : Api.GlGetProcAddress(functionName);
        Api.ClearError();
        return ret;
    }

    /// <inheritdoc />
    public bool IsCurrent
    {
        get => Api.GlGetCurrentContext() == Context;
        set
        {
            if (value)
            {
                Expect(Api.GlMakeCurrent(Window, Context), "make context current");
            }
            else
            {
                Expect(Api.GlMakeCurrent(Window, nullptr), "clear current context");
            }
        }
    }

    /// <inheritdoc />
    public int SwapInterval
    {
        get
        {
            var interval = 0;
            Expect(Api.GlGetSwapInterval(interval.AsRef()), "get swap interval");
            return interval;
        }
        set => Expect(Api.GlSetSwapInterval(value), "set swap interval");
    }

    /// <inheritdoc />
    public void SwapBuffers() => Expect(Api.GlSwapWindow(Window), "swap buffers");

    private void Expect(bool ec, string action)
    {
        if (ec)
        {
            return;
        }

        var err = (string)Api.GetError();
        Api.ClearError();

        Throw(action, err);
        return;

        static void Throw(string act, string err) =>
            throw new SdlException($"Failed to {act}: {err}");
    }
}
