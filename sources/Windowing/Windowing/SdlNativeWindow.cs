// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

global using static Silk.NET.Core.DSL;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.SDL;

namespace Silk.NET.Windowing;

/// <summary>
/// A HLU component encapsulating SDL info. This should be registered to <see cref="IHluComponentHost"/>s as an
/// implementation of <see cref="IPlatformInfo"/>.
/// </summary>
public sealed class SdlNativeWindow : IPlatformInfo, IDisposable
{
    /// <summary>
    /// Creates a <see cref="SdlNativeWindow"/> component from the given base components.
    /// </summary>
    /// <param name="platform">The base platform info, to create a SDL window from an existing window.</param>
    /// <param name="sdl">The SDL API interface (optional, defaults to <see cref="Sdl.Instance"/>).</param>
    public unsafe SdlNativeWindow(
        [HluHostedComponent] IPlatformInfo platform,
        [HluHostedComponent] ISdl? sdl = null
    )
        : this(sdl)
    {
        switch (platform)
        {
            // These are additional supported properties with X11:
            // - `SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER`: the X11 Window associated
            //   with the window, if you want to wrap an existing window.
            case X11PlatformInfo x11:
                Api.SetNumberProperty(
                    Properties,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateX11WindowNumber),
                    x11.Window
                );
                Next = platform;
                break;
            // These are additional supported properties on macOS:
            // - `SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER`: the
            //   `(__unsafe_unretained)` NSWindow associated with the window, if you want
            //   to wrap an existing window.
            // - `SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER`: the `(__unsafe_unretained)`
            //   NSView associated with the window, defaults to `[window contentView]`
            case CocoaPlatformInfo cocoa:
                Api.SetProperty(
                    Properties,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateCocoaWindowPointer),
                    (void*)cocoa.Window // TODO should we add a nint -> Ref implicit cast?
                );
                Next = platform;
                break;
            // These are additional supported properties on Wayland:
            //
            // - `SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN` - true if - TODO do we want this?
            //   the application wants to use the Wayland surface for a custom role and
            //   does not want it attached to an XDG toplevel window. See
            //   [README/wayland](README/wayland) for more information on using custom
            //   surfaces.
            // - `SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN` - true if the - TODO do we want this?
            //   application wants an associated `wl_egl_window` object to be created,
            //   even if the window does not have the OpenGL property or flag set.
            // - `SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER` - the wl_surface
            //   associated with the window, if you want to wrap an existing window. See
            //   [README/wayland](README/wayland) for more information.
            case WaylandPlatformInfo wayland:
                Api.SetProperty(
                    Properties,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateWaylandWlSurfacePointer),
                    (void*)wayland.Surface // TODO should we add a nint -> Ref implicit cast?
                );
                Next = platform;
                break;
            // These are additional supported properties on Windows:
            // - `SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER`: the HWND associated with the
            //    window, if you want to wrap an existing window.
            // - `SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER`: optional,
            //    another window to share pixel format with, useful for OpenGL windows
            case Win32PlatformInfo win32:
                Api.SetProperty(
                    Properties,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateWin32HwndPointer),
                    (void*)win32.Hwnd
                );
                Next = platform;
                break;
        }
    }

    /// <summary>
    /// Creates a <see cref="SdlNativeWindow"/> component from the given base components.
    /// </summary>
    /// <param name="sdl">The SDL API interface (optional, defaults to <see cref="Sdl.Instance"/>).</param>
    public SdlNativeWindow([HluHostedComponent] ISdl? sdl = null)
    {
        Api = sdl ?? Sdl.Instance;
        Properties = Api.CreateProperties();
        Api.SetStringProperty(
            Properties,
            MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateTitleString),
            Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Window"
        );

        // The bounds component will override this if the user has requested a window of a specific dimension.
        // Otherwise, we enact the lowest common denominator across platforms - borderless fullscreen.
        Api.SetBooleanProperty(
            Properties,
            MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateBorderlessBoolean),
            true
        );
        Api.SetBooleanProperty(
            Properties,
            MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateFullscreenBoolean),
            true
        );
    }

    /// <summary>
    /// The SDL API interface in use.
    /// </summary>
    public ISdl Api { get; }

    /// <summary>
    /// The SDL window handle. May be null.
    /// </summary>
    public WindowHandle Window { get; private set; }

    /// <summary>
    /// The SDL window properties. Never zero.
    /// </summary>
    /// <remarks>
    /// If <see cref="WindowHandle"/> is not <see cref="DSL.get_nullptr"/>, then this tracks the properties of the
    /// actual window.
    /// </remarks>
    public uint Properties { get; private set; }

    /// <summary>
    /// Gets a property for this window.
    /// </summary>
    /// <param name="runtimePropertyName">The property name to use if the window has been created.</param>
    /// <param name="creationTimePropertyName">The property name to use if the window has not been created.</param>
    /// <param name="defaultValue">The default value to use.</param>
    /// <typeparam name="T">
    /// The type of the property. Must be one of:
    /// <list type="bullet">
    /// <item>
    /// <term><see cref="long"/>: </term>
    /// <description>For <see cref="ISdl.GetNumberProperty(uint, Ref{sbyte}, long)"/></description>
    /// </item>
    /// <item>
    /// <term><see cref="float"/>: </term>
    /// <description>For <see cref="ISdl.GetFloatProperty(uint, Ref{sbyte}, float)"/></description>
    /// </item>
    /// <item>
    /// <term><see cref="bool"/>: </term>
    /// <description>For <see cref="ISdl.GetBooleanProperty(uint, Ref{sbyte}, MaybeBool{int})"/></description>
    /// </item>
    /// <item>
    /// <term>
    /// <see cref="string"/> or <see cref="Ptr{T}"/> where <c>T</c> is <see cref="sbyte"/> or <see cref="byte"/>:
    /// </term>
    /// <description>For <see cref="ISdl.GetStringProperty(uint, Ref{sbyte}, Ref{sbyte})"/></description>
    /// </item>
    /// <item>
    /// <term>A pointer sized struct: </term>
    /// <description>For <see cref="ISdl.GetProperty(uint, Ref{sbyte}, Ref)"/></description>
    /// </item>
    /// </list>
    /// </typeparam>
    /// <returns>The property, or the default value if it was not set.</returns>
    /// <exception cref="ArgumentException">
    /// The window has not been created and no creation-time property name has been provided.
    /// </exception>
    /// <exception cref="InvalidOperationException">An invalid type was used.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- required to optimise away throwing
    public unsafe T? GetProperty<T>(
        ReadOnlySpan<byte> runtimePropertyName,
        ReadOnlySpan<byte> creationTimePropertyName = default,
        T? defaultValue = default!
    )
    {
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
        var propName = MemoryMarshal.Cast<byte, sbyte>(
            runtimePropertyName.IsEmpty
                ? creationTimePropertyName
                : Window == nullptr
                    ? creationTimePropertyName.IsEmpty
                        ? throw new ArgumentException(
                            "Window has not been created, and no creation-time property name has been provided.",
                            nameof(creationTimePropertyName)
                        )
                        : creationTimePropertyName
                    : runtimePropertyName
        );

        // YES THIS IS TERRIBLE CODE, BUT IT MAKES THE REST OF OUR CODEBASE CLEAN.
        // - Story of Silk.NET's life
        if (typeof(T) == typeof(long))
        {
            return (T)
                (object)Api.GetNumberProperty(Properties, propName, (long)(object?)defaultValue!);
        }

        if (typeof(T) == typeof(float))
        {
            return (T)
                (object)Api.GetFloatProperty(Properties, propName, (float)(object?)defaultValue!);
        }

        if (typeof(T) == typeof(bool))
        {
            return (T)
                (object)
                    (bool)
                        Api.GetBooleanProperty(Properties, propName, (bool)(object?)defaultValue!);
        }

        if (
            typeof(T) == typeof(Ptr<sbyte>)
            || typeof(T) == typeof(Ptr<byte>)
            || typeof(T) == typeof(string)
        )
        {
            var ret = Api.GetStringProperty(Properties, propName, nullptr);
            return ret == nullptr
                ? default
                : typeof(T) == typeof(string)
                    ? (T)(object)ret.ReadToString()
                    : *(T*)&ret;
        }

        if (sizeof(T) != sizeof(nint) || !typeof(T).IsValueType)
        {
            throw new InvalidOperationException(
                "Can't retrieve using this type - must be long, float, bool, string"
                    + "(or a Ptr<sbyte>/Ptr<byte>), or a pointer-sized type."
            );
        }

        void* ptr = Api.GetProperty(Properties, propName, *(void**)&defaultValue);
        return *(T*)&ptr;
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
    }

    /// <summary>
    /// Sets a property for this window.
    /// </summary>
    /// <param name="runtimePropertyName">The property name to use if the window has been created.</param>
    /// <param name="creationTimePropertyName">The property name to use if the window has not been created.</param>
    /// <param name="value">The value to set the property to.</param>
    /// <typeparam name="T">
    /// The type of the property. Must be one of:
    /// <list type="bullet">
    /// <item>
    /// <term><see cref="long"/>: </term>
    /// <description>For <see cref="ISdl.GetNumberProperty(uint, Ref{sbyte}, long)"/></description>
    /// </item>
    /// <item>
    /// <term><see cref="float"/>: </term>
    /// <description>For <see cref="ISdl.GetFloatProperty(uint, Ref{sbyte}, float)"/></description>
    /// </item>
    /// <item>
    /// <term><see cref="bool"/>: </term>
    /// <description>For <see cref="ISdl.GetBooleanProperty(uint, Ref{sbyte}, MaybeBool{int})"/></description>
    /// </item>
    /// <item>
    /// <term>
    /// <see cref="string"/> or <see cref="Ptr{T}"/> where <c>T</c> is <see cref="sbyte"/> or <see cref="byte"/>:
    /// </term>
    /// <description>For <see cref="ISdl.GetStringProperty(uint, Ref{sbyte}, Ref{sbyte})"/></description>
    /// </item>
    /// <item>
    /// <term>A pointer sized struct: </term>
    /// <description>For <see cref="ISdl.GetProperty(uint, Ref{sbyte}, Ref)"/></description>
    /// </item>
    /// </list>
    /// </typeparam>
    /// <exception cref="ArgumentException">
    /// The window has not been created and no creation-time property name has been provided.
    /// </exception>
    /// <exception cref="InvalidOperationException">An invalid type was used.</exception>
    /// <exception cref="SdlException">An error occurred while setting the property.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)] // <-- required to optimise away throwing
    public unsafe void SetProperty<T>(
        ReadOnlySpan<byte> runtimePropertyName,
        T? value,
        ReadOnlySpan<byte> creationTimePropertyName = default
    )
    {
#pragma warning disable CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
        var propName = MemoryMarshal.Cast<byte, sbyte>(
            runtimePropertyName.IsEmpty
                ? creationTimePropertyName
                : Window == nullptr
                    ? creationTimePropertyName.IsEmpty
                        ? throw new ArgumentException(
                            "Window has not been created, and no creation-time property name has been provided.",
                            nameof(creationTimePropertyName)
                        )
                        : creationTimePropertyName
                    : runtimePropertyName
        );

        // YES THIS IS TERRIBLE CODE, BUT IT MAKES THE REST OF OUR CODEBASE CLEAN.
        // - Story of Silk.NET's life
        if (typeof(T) == typeof(long))
        {
            if (Api.SetNumberProperty(Properties, propName, (long)(object?)value!) != 0)
            {
                Api.ThrowError();
            }
        }

        if (typeof(T) == typeof(float))
        {
            if (Api.SetFloatProperty(Properties, propName, (float)(object?)value!) != 0)
            {
                Api.ThrowError();
            }
        }

        if (typeof(T) == typeof(bool))
        {
            if (Api.SetBooleanProperty(Properties, propName, (bool)(object?)value!) != 0)
            {
                Api.ThrowError();
            }
        }

        if (typeof(T) == typeof(Ptr<sbyte>) || typeof(T) == typeof(Ptr<byte>))
        {
            if (Api.SetStringProperty(Properties, propName, *(Ptr<sbyte>*)&value) != 0)
            {
                Api.ThrowError();
            }
        }

        if (typeof(T) == typeof(string))
        {
            if (Api.SetStringProperty(Properties, propName, (string?)(object?)value) != 0)
            {
                Api.ThrowError();
            }
        }

        if (sizeof(T) != sizeof(nint) || !typeof(T).IsValueType)
        {
            throw new InvalidOperationException(
                "Can't retrieve using this type - must be long, float, bool, string"
                    + "(or a Ptr<sbyte>/Ptr<byte>), or a pointer-sized type."
            );
        }

        if (Api.SetProperty(Properties, propName, *(void**)&value) != 0)
        {
            Api.ThrowError();
        }
#pragma warning restore CS8500 // This takes the address of, gets the size of, or declares a pointer to a managed type
    }

    /// <summary>
    /// Creates the underlying window. If the window has already been created, this does nothing.
    /// This should only be called once all initial creation time properties have been set.
    /// </summary>
    public void CreateWindow()
    {
        if (Window != nullptr)
        {
            return;
        }

        if (Api.InitSubSystem((uint)InitFlags.Video) != 0)
        {
            Api.ThrowError();
        }

        Window = Api.CreateWindowWithProperties(Properties);
        if (Window == nullptr)
        {
            Api.ThrowError();
        }

        Api.DestroyProperties(Properties);
        Properties = Api.GetWindowProperties(Window);
        // On Android:
        // - `SDL_PROP_WINDOW_ANDROID_WINDOW_POINTER`: the ANativeWindow associated
        //   with the window
        // - `SDL_PROP_WINDOW_ANDROID_SURFACE_POINTER`: the EGLSurface associated with
        //   the window
        if (GetProperty<nint>(Sdl.PropWindowAndroidWindowPointer) is not 0 and var aNativeWindow)
        {
            Next = new AndroidPlatformInfo(
                aNativeWindow,
                GetProperty<nint>(Sdl.PropWindowAndroidSurfacePointer)
            );
        }
        // On iOS:
        // - `SDL_PROP_WINDOW_UIKIT_WINDOW_POINTER`: the `(__unsafe_unretained)`
        //   UIWindow associated with the window
        // - TODO `SDL_PROP_WINDOW_UIKIT_METAL_VIEW_TAG_NUMBER`: the NSInteger tag
        //   assocated with metal views on the window
        // - `SDL_PROP_WINDOW_UIKIT_OPENGL_FRAMEBUFFER_NUMBER`: the OpenGL view's
        //   framebuffer object. It must be bound when rendering to the screen using
        //   OpenGL.
        // - `SDL_PROP_WINDOW_UIKIT_OPENGL_RENDERBUFFER_NUMBER`: the OpenGL view's
        //   renderbuffer object. It must be bound when SDL_GL_SwapWindow is called.
        // - `SDL_PROP_WINDOW_UIKIT_OPENGL_RESOLVE_FRAMEBUFFER_NUMBER`: the OpenGL
        //   view's resolve framebuffer, when MSAA is used.
        else if (GetProperty<nint>(Sdl.PropWindowUikitWindowPointer) is not 0 and var uiWindow)
        {
            // TODO our bindings need to be updated
            throw new NotImplementedException();
        }
        // On KMS/DRM:
        // - `SDL_PROP_WINDOW_KMSDRM_DEVICE_INDEX_NUMBER`: the device index associated
        //   with the window (e.g. the X in /dev/dri/cardX)
        // - `SDL_PROP_WINDOW_KMSDRM_DRM_FD_NUMBER`: the DRM FD associated with the
        //   window
        // - `SDL_PROP_WINDOW_KMSDRM_GBM_DEVICE_POINTER`: the GBM device associated
        //   with the window
        // TODO we don't have KMS/DRM platform info structs yet
        // On macOS:
        //
        // - `SDL_PROP_WINDOW_COCOA_WINDOW_POINTER`: the `(__unsafe_unretained)`
        //   NSWindow associated with the window
        // - TODO `SDL_PROP_WINDOW_COCOA_METAL_VIEW_TAG_NUMBER`: the NSInteger tag
        //   assocated with metal views on the window
        else if (GetProperty<nint>(Sdl.PropWindowCocoaWindowPointer) is not 0 and var nsWindow)
        {
            Next = new CocoaPlatformInfo(nsWindow);
        }
        // On Vivante:
        // - `SDL_PROP_WINDOW_VIVANTE_DISPLAY_POINTER`: the EGLNativeDisplayType
        //   associated with the window
        // - `SDL_PROP_WINDOW_VIVANTE_WINDOW_POINTER`: the EGLNativeWindowType
        //   associated with the window
        // - TODO `SDL_PROP_WINDOW_VIVANTE_SURFACE_POINTER`: the EGLSurface associated with
        //   the window
        else if (GetProperty<nint>(Sdl.PropWindowVivanteDisplayPointer) is not 0 and var vivDisplay)
        {
            Next = new VivantePlatformInfo(
                vivDisplay,
                GetProperty<nint>(Sdl.PropWindowVivanteWindowPointer)
            );
        }
        // On UWP:
        // - `SDL_PROP_WINDOW_WINRT_WINDOW_POINTER`: the IInspectable CoreWindow
        //   associated with the window
        else if (GetProperty<nint>(Sdl.PropWindowWinrtWindowPointer) is not 0 and var inspectable)
        {
            Next = new WinRTPlatformInfo(inspectable);
        }
        // On Windows:
        // - `SDL_PROP_WINDOW_WIN32_HWND_POINTER`: the HWND associated with the window
        // - `SDL_PROP_WINDOW_WIN32_HDC_POINTER`: the HDC associated with the window
        // - `SDL_PROP_WINDOW_WIN32_INSTANCE_POINTER`: the HINSTANCE associated with
        //   the window
        else if (GetProperty<nint>(Sdl.PropWindowWin32HwndPointer) is not 0 and var hwnd)
        {
            Next = new Win32PlatformInfo(
                hwnd,
                GetProperty<nint>(Sdl.PropWindowWin32HdcPointer),
                GetProperty<nint>(Sdl.PropWindowWin32InstancePointer)
            );
        }
        // On Wayland:
        //
        // Note: The `xdg_*` window objects do not internally persist across window
        // show/hide calls. They will be null if the window is hidden and must be
        // queried each time it is shown.
        //
        // - `SDL_PROP_WINDOW_WAYLAND_DISPLAY_POINTER`: the wl_display associated with
        //   the window
        // - `SDL_PROP_WINDOW_WAYLAND_SURFACE_POINTER`: the wl_surface associated with
        //   the window
        // - `SDL_PROP_WINDOW_WAYLAND_EGL_WINDOW_POINTER`: the wl_egl_window
        //   associated with the window
        // - `SDL_PROP_WINDOW_WAYLAND_XDG_SURFACE_POINTER`: the xdg_surface associated
        //   with the window
        // - `SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_POINTER`: the xdg_toplevel role
        //   associated with the window
        // - 'SDL_PROP_WINDOW_WAYLAND_XDG_TOPLEVEL_EXPORT_HANDLE_STRING': the export
        //   handle associated with the window
        // - `SDL_PROP_WINDOW_WAYLAND_XDG_POPUP_POINTER`: the xdg_popup role
        //   associated with the window
        // - `SDL_PROP_WINDOW_WAYLAND_XDG_POSITIONER_POINTER`: the xdg_positioner
        //   associated with the window, in popup mode
        else if (GetProperty<nint>(Sdl.PropWindowWaylandSurfacePointer) is not 0 and var wlSurface)
        {
            Next = new WaylandPlatformInfo(
                GetProperty<nint>(Sdl.PropWindowWaylandDisplayPointer),
                wlSurface
            );
        }
        // On X11:
        // - `SDL_PROP_WINDOW_X11_DISPLAY_POINTER`: the X11 Display associated with
        //   the window
        // - `SDL_PROP_WINDOW_X11_SCREEN_NUMBER`: the screen number associated with
        //   the window
        // - `SDL_PROP_WINDOW_X11_WINDOW_NUMBER`: the X11 Window associated with the
        //   window
        else if (GetProperty<long>(Sdl.PropWindowX11WindowNumber) is not 0 and var xWindow)
        {
            Next = new X11PlatformInfo(
                GetProperty<nint>(Sdl.PropWindowX11DisplayPointer),
                (nint)xWindow
            );
        }
    }

    /// <inheritdoc />
    public IPlatformInfo? Next { get; private set; }

    private void ReleaseUnmanagedResources() => Api.DestroyWindow(Window);

    /// <inheritdoc />
    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~SdlNativeWindow() => ReleaseUnmanagedResources();
}
