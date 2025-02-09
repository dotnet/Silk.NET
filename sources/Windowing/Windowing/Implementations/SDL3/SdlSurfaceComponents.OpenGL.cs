// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Loader;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceOpenGL
{
    void IDisposable.Dispose() { }

    public unsafe void* LoadFunction(string functionName, string libraryNameHint)
    {
        if (ContextHandle != nullptr)
        {
            return Sdl.GLGetProcAddress(functionName);
        }

        ThrowGLPrematureAccessException();
        return null;
    }

    private GLContextStateHandle ContextHandle { get; set; }

    public bool IsCurrent
    {
        get => ContextHandle != nullptr && Sdl.GLGetCurrentContext() == ContextHandle;
        set
        {
            if (ContextHandle == nullptr)
            {
                ThrowGLPrematureAccessException();
                return;
            }

            if (!Sdl.GLMakeCurrent(Handle, value ? ContextHandle : nullptr))
            {
                Sdl.ThrowError();
            }
        }
    }

    private void ThrowGLPrematureAccessException()
    {
        if (IsSurfaceInitialized)
        {
            throw new InvalidOperationException(
                "The OpenGL context cannot be accessed as it was not enabled during "
                    + "ISurfaceApplication.Initialize<TSurface>(TSurface)."
            );
        }
        throw new InvalidOperationException(
            "The OpenGL context cannot be accessed until ISurfaceApplication.Initialize<TSurface>(TSurface) "
                + "has finished executing, consider using the Surface.Created callback instead."
        );
    }

    public int SwapInterval
    {
        get
        {
            if (ContextHandle == nullptr)
            {
                return field;
            }

            var ret = 0;
            if (!Sdl.GLGetSwapInterval(ret.AsRef()))
            {
                Sdl.ThrowError();
            }

            return field = ret;
        }
        set
        {
            if (ContextHandle == nullptr)
            {
                field = value;
                SetEnabled();
                return;
            }

            if (!Sdl.GLSetSwapInterval(value))
            {
                Sdl.ThrowError();
            }
            field = value;
        }
    }

    public void SwapBuffers()
    {
        if (!Sdl.GLSwapWindow(Handle))
        {
            Sdl.ThrowError();
        }
    }

    public int? PreferredDepthBufferBits
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public int? PreferredStencilBufferBits
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public Vector4D<int>? PreferredBitDepth
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public int? PreferredSampleCount
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public Version32? Version
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public OpenGLContextFlags Flags
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    public OpenGLContextProfile Profile
    {
        get;
        set
        {
            AssertUninit();
            field = value;
        }
    }

    public bool IsSupported => TryCreateContext(false);

    public bool ShouldSwapAutomatically { get; set; } = true;

    public IGLContext? SharedContext
    {
        get;
        set
        {
            AssertUninit();
            SetEnabled();
            field = value;
        }
    }

    private void SetEnabled()
    {
        if (Profile == OpenGLContextProfile.None)
        {
            Profile = OpenGLContextProfile.Default;
        }
    }

    private bool TryCreateContext(bool isInitializing)
    {
        var profile = Profile;
        if (profile is OpenGLContextProfile.None)
        {
            return true;
        }

        // If isInitializing == false, we should restore the thread to the state we found it in.
        var current = Sdl.GLGetCurrentContext();
        WindowHandle currentWindow = nullptr;
        if (current != nullptr)
        {
            currentWindow = Sdl.GLGetCurrentWindow();
        }

        if (Handle == nullptr && isInitializing)
        {
            throw new InvalidOperationException(
                "Attempted to initialize OpenGL context before window initialization - this should not be possible "
                    + "with normal usage. Please report this at https://github.com/dotnet/Silk.NET"
            );
        }

        // We need to create a dummy window if we haven't already (InitializePlatform does this, but it's only made
        // available to the first Surface). This is assigned to Handle if successful.
        if (
            !isInitializing
            && GetDummyWindow(Sdl.WindowOpengl, nFlags: Sdl.WindowVulkan) == nullptr
        )
        {
            // Guess OpenGL isn't supported after all...
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Get the shared context we need to make current before creating the context
        (GLContextStateHandle Context, WindowHandle Window)? sharedContext = (
            (ISurfaceOpenGL)this
        ).SharedContext switch
        {
            SdlContext sdlCtx => (sdlCtx.Context, sdlCtx.Window),
            SdlSurfaceComponents impl => (impl.ContextHandle, impl.Handle),
            not null => (nullptr, nullptr),
            _ => null,
        };

        // If SharedContext is set to some type we don't recognise, fail.
        if (sharedContext?.Context == nullptr)
        {
            if (isInitializing)
            {
                throw new NotSupportedException(
                    "On this platform, SharedContext must be either a Silk.NET.SDL.SdlContext an OpenGL component "
                        + "retrieved from a surface created using ISurfaceApplication.Run<T>() or "
                        + "IDetachedSurfaceLifecycle.TryCreate<T>(out IDetachedSurfaceLifecycle?)."
                );
            }
            return false;
        }

        // Ensure that the current context is either the context we want to share with or empty.
        var expectedCurrentWindow = sharedContext?.Window ?? Handle;
        var expectedCurrent = sharedContext?.Context ?? nullptr;
        if (current != expectedCurrent || currentWindow != expectedCurrentWindow)
        {
            Sdl.GLMakeCurrent(sharedContext?.Window ?? Handle, sharedContext?.Context ?? nullptr);
        }

        if (sharedContext is not null && !Sdl.GLSetAttribute(GLAttr.ShareWithCurrentContext, 1))
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Set the context profile.
        if (
            profile is not OpenGLContextProfile.Default
            && !Sdl.GLSetAttribute(
                GLAttr.ContextProfileMask,
                profile switch
                {
                    OpenGLContextProfile.Core => Sdl.GlContextProfileCore,
                    OpenGLContextProfile.Compatibility => Sdl.GlContextProfileCompatibility,
                    OpenGLContextProfile.ES2 => Sdl.GlContextProfileEs,
                    _ => throw new InvalidOperationException(
                        "OpenGLContextProfile is not a legal value."
                    ),
                }
            )
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Set the context flags.
        var flags = Flags;
        if (
            flags is not OpenGLContextFlags.Default
            && !Sdl.GLSetAttribute(
                GLAttr.ContextProfileMask,
                ((flags & OpenGLContextFlags.Debug) != 0 ? Sdl.GlContextDebugFlag : 0)
                    | (
                        (flags & OpenGLContextFlags.ForwardCompatible) != 0
                            ? Sdl.GlContextForwardCompatibleFlag
                            : 0
                    )
            )
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Set the specific version requested, if applicable.
        if (
            Version is { } ver
            && !(
                Sdl.GLSetAttribute(GLAttr.ContextMajorVersion, (int)ver.Major)
                && Sdl.GLSetAttribute(GLAttr.ContextMinorVersion, (int)ver.Minor)
            )
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Set the bit depth.
        if (
            PreferredBitDepth is { } colour
            && !(
                (colour.X < 0 || Sdl.GLSetAttribute(GLAttr.RedSize, colour.X))
                && (colour.Y < 0 || Sdl.GLSetAttribute(GLAttr.GreenSize, colour.Y))
                && (colour.Z < 0 || Sdl.GLSetAttribute(GLAttr.BlueSize, colour.Z))
                && (colour.W < 0 || Sdl.GLSetAttribute(GLAttr.AlphaSize, colour.W))
            )
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Configure MSAA.
        if (
            PreferredSampleCount is >= 0 and var count
            && !(
                Sdl.GLSetAttribute(GLAttr.Multisamplebuffers, 1)
                && Sdl.GLSetAttribute(GLAttr.Multisamplesamples, count)
            )
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Configure depth buffer.
        if (PreferredDepthBufferBits is { } depth && !Sdl.GLSetAttribute(GLAttr.DepthSize, depth))
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Configure stencil buffer.
        if (
            PreferredStencilBufferBits is { } stencil
            && !Sdl.GLSetAttribute(GLAttr.StencilSize, stencil)
        )
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // Now let's try to create the context!
        var ctx = Sdl.GLCreateContext(Handle);
        if (ctx == nullptr)
        {
            ClearErrorIf(!isInitializing);
            return false;
        }

        // If successful, we should update our state if we're initializing. If we're not initializing, then we simply
        // destroy the context (as sadly that's the only way we can check whether a given configuration is supported).
        if (isInitializing)
        {
            var swapInterval = SwapInterval;
            ContextHandle = ctx;
            SwapInterval = swapInterval;
            return true;
        }

        if (!Sdl.GLMakeCurrent(currentWindow, current))
        {
            Sdl.ThrowError();
        }

        if (!Sdl.GLDestroyContext(ctx))
        {
            Sdl.ThrowError();
        }

        return true;
        static void ClearErrorIf(bool value)
        {
            if (value)
            {
                Sdl.ClearError();
            }
        }
    }

    private void InitializeOpenGL(uint props)
    {
        if (Profile == OpenGLContextProfile.None)
        {
            return;
        }

        AddWindowCreateFlags(props, Sdl.WindowOpengl);
    }

    private void PostInitializeOpenGL()
    {
        DebugPrint();
        if (!TryCreateContext(true))
        {
            Sdl.ThrowError();
        }
    }
}
