// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

#pragma warning disable CS9113 // Parameter is unread.
internal partial class SdlSurfaceComponents(SdlSurface surface)
#pragma warning restore CS9113 // Parameter is unread.
{
    public static bool IsChildrenEnabled { get; private set; }
    public static bool IsDisplayEnabled => true;
    public static bool IsOpenGLEnabled { get; private set; }
    public static bool IsScaleEnabled => true;
    public static bool IsVulkanEnabled { get; private set; }
    public static bool IsWindowEnabled { get; private set; }

    /// <summary>
    /// The window handle. This always points to a valid window, but before creation it is simply
    /// </summary>
    public WindowHandle Handle { get; set; }

    public bool IsSurfaceInitialized { get; set; }

    private static uint _platformInitCount;

    private void AssertUninit()
    {
        if (IsSurfaceInitialized)
        {
            throw new InvalidOperationException(
                "This property can only be set during surface initialization (i.e. "
                    + "within the ISurfaceApplication.Initialize<T>() method)."
            );
        }
    }

    /// <summary>
    /// Initializes the platform and returns the temporary window handle used in the process if applicable.
    /// </summary>
    /// <returns>
    /// The window handle. May be <c>nullptr</c>, in which case the platform was already initialised.
    /// </returns>
    public static WindowHandle InitializePlatform()
    {
        if (Interlocked.Increment(ref _platformInitCount) > 1)
        {
            return nullptr;
        }

        if (!Sdl.InitSubSystem(Sdl.InitVideo))
        {
            Sdl.ThrowError();
            return nullptr;
        }

        IsOpenGLEnabled = Sdl.GLLoadLibrary(nullptr);
        IsVulkanEnabled = Sdl.VulkanLoadLibrary(nullptr);
        Sdl.ClearError();

        var props = CreateDummyWindowProps();
        var tempWindow = Sdl.CreateWindowWithProperties(props);
        if (tempWindow == nullptr)
        {
            // Should be able to at least create a window.
            Sdl.DestroyProperties(props);
            Sdl.ThrowError();
            return nullptr;
        }

        var tempChildWindow = Sdl.CreateWindowWithProperties(props);
        if (tempChildWindow != nullptr)
        {
            IsChildrenEnabled = true;
            Sdl.DestroyWindow(tempChildWindow);
        }

        Sdl.ClearError();
        IsWindowEnabled = Sdl.SetWindowPosition(tempWindow, 1, 1);
        Sdl.ClearError();
        Sdl.DestroyProperties(props);
        return tempWindow;
    }

    private static uint CreateDummyWindowProps()
    {
        var props = Sdl.CreateProperties();
        Sdl.SetBooleanProperty(props, Sdl.PropWindowCreateHiddenBoolean, true);
        return props;
    }

    public void PreInitializeSurface()
    {
        Handle = InitializePlatform();
        if (IsDisplayEnabled)
        {
            PreInitializeDisplay();
        }
    }

    public void InitializeSurface()
    {
        var props = Sdl.CreateProperties();
        try
        {
            if (IsDisplayEnabled)
            {
                InitializeDisplay(props);
            }

            if (IsOpenGLEnabled)
            {
                InitializeOpenGL(props);
            }

            if (IsVulkanEnabled)
            {
                InitializeVulkan(props);
            }

            if (IsWindowEnabled)
            {
                InitializeWindow(props);
            }

            if (Handle != nullptr)
            {
                Sdl.DestroyWindow(Handle);
            }

            Handle = Sdl.CreateWindowWithProperties(props);
        }
        finally
        {
            Sdl.DestroyProperties(props);
        }

        if (Handle == nullptr)
        {
            Sdl.ThrowError();
        }

        IsSurfaceInitialized = true;
        if (IsOpenGLEnabled)
        {
            PostInitializeOpenGL();
        }
    }

    public static void TerminatePlatform()
    {
        if (Interlocked.Decrement(ref _platformInitCount) != 0)
        {
            return;
        }

        Sdl.QuitSubSystem(Sdl.InitVideo);
        if (IsOpenGLEnabled)
        {
            Sdl.GLUnloadLibrary();
        }

        if (IsVulkanEnabled)
        {
            Sdl.VulkanUnloadLibrary();
        }
    }

    public void Dispose()
    {
        if (Handle != nullptr)
        {
            Sdl.DestroyWindow(Handle);
        }

        TerminatePlatform();
    }
}
