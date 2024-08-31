// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Silk.NET.Core;
using Silk.NET.SDL;
using Silk.NET.Windowing.Hosting;

namespace Silk.NET.Windowing;

/// <summary>
/// Represents the reference implementation for <see cref="Surface"/>. This currently uses SDL.
/// </summary>
public unsafe class ReferenceImplementation : ISurfaceHost
{
    /// <inheritdoc />
    public static bool IsMultiSurface =>
        !(
            OperatingSystem.IsAndroid()
            || OperatingSystem.IsIOS()
            || OperatingSystem.IsBrowser()
            || OperatingSystem.IsTvOS()
            || OperatingSystem.IsWatchOS()
        );

    /// <inheritdoc />
    public static RequestHandle CreateSurfaceRequest() =>
        new(unchecked((nint)Sdl.CreateProperties()));

    /// <inheritdoc />
    public static void CopySurfaceRequest<TSrc>(RequestHandle dest, TSrc src)
        where TSrc : ISurfaceOrRequestHandle
    {
        // TODO needs handles to be creatable
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public static void DestroySurfaceRequest(RequestHandle surfaceRequest) =>
        Sdl.DestroyProperties(unchecked((uint)surfaceRequest.Value));

    /// <inheritdoc />
    public static bool TryInheritPlatformInfo<TPlatformInfo>(
        RequestHandle surfaceRequest,
        TPlatformInfo info
    )
        where TPlatformInfo : notnull
    {
        var props = unchecked((uint)surfaceRequest.Value);
        // #define SDL_PROP_WINDOW_CREATE_COCOA_WINDOW_POINTER                "SDL.window.create.cocoa.window"
        // #define SDL_PROP_WINDOW_CREATE_COCOA_VIEW_POINTER                  "SDL.window.create.cocoa.view"
        // #define SDL_PROP_WINDOW_CREATE_WAYLAND_SURFACE_ROLE_CUSTOM_BOOLEAN "SDL.window.create.wayland.surface_role_custom"
        // #define SDL_PROP_WINDOW_CREATE_WAYLAND_CREATE_EGL_WINDOW_BOOLEAN   "SDL.window.create.wayland.create_egl_window"
        // #define SDL_PROP_WINDOW_CREATE_WAYLAND_WL_SURFACE_POINTER          "SDL.window.create.wayland.wl_surface"
        // #define SDL_PROP_WINDOW_CREATE_WIN32_HWND_POINTER                  "SDL.window.create.win32.hwnd"
        // #define SDL_PROP_WINDOW_CREATE_WIN32_PIXEL_FORMAT_HWND_POINTER     "SDL.window.create.win32.pixel_format_hwnd"
        // #define SDL_PROP_WINDOW_CREATE_X11_WINDOW_NUMBER                   "SDL.window.create.x11.window"
        if (
            typeof(TPlatformInfo) == typeof(CocoaPlatformInfo)
            && (CocoaPlatformInfo)(object)info is var cocoa
        )
        {
            var ret =
                Sdl.SetProperty(
                    props,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateCocoaWindowPointer), // TODO string consts should use a special type that can collapse to either Ref<byte> or Ref<sbyte>
                    (void*)cocoa.Window // TODO nint to Ref?
                ) == 0;
            // TODO i know it's a try method but should we do something with this?
            if (!ret)
            {
                Sdl.ClearError();
            }

            return ret;
        }

        if (
            typeof(TPlatformInfo) == typeof(WaylandPlatformInfo)
            && (WaylandPlatformInfo)(object)info is var wayland
        )
        {
            return Sdl.SetProperty(
                    props,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateWaylandWlSurfacePointer),
                    (void*)wayland.Surface
                ) == 0;
        }

        if (
            typeof(TPlatformInfo) == typeof(Win32PlatformInfo)
            && (Win32PlatformInfo)(object)info is var win32
        )
        {
            return Sdl.SetProperty(
                    props,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateWin32HwndPointer),
                    (void*)win32.Hwnd
                ) == 0;
        }

        if (
            typeof(TPlatformInfo) == typeof(X11PlatformInfo)
            && (X11PlatformInfo)(object)info is var x11
        )
        {
            return Sdl.SetNumberProperty(
                    props,
                    MemoryMarshal.Cast<byte, sbyte>(Sdl.PropWindowCreateX11WindowNumber),
                    x11.Window
                ) == 0;
        }

        return false;
    }

    /// <inheritdoc />
    public static HostStatus LaunchMainSurface<TActor>(RequestHandle surfaceRequest, TActor actor)
        where TActor : IHostActor
    {
        var window = Sdl.CreateWindowWithProperties(unchecked((uint)surfaceRequest.Value));
        if (window == nullptr)
        {
            Sdl.ThrowError();
        }

        // TODO requires SDL_RunApp and SDL_EnterAppMainCallbacks
        return HostStatus.Failure;
    }

    /// <inheritdoc />
    public static SurfaceHandle CreateChildSurface(
        SurfaceHandle parent,
        RequestHandle surfaceRequest
    ) => throw new NotImplementedException();

    /// <inheritdoc />
    public static void TerminateSurface(SurfaceHandle surface) =>
        throw new NotImplementedException();

    /// <inheritdoc />
    public static bool TryGetPlatformInfo<TPlatformInfo>(
        SurfaceHandle handle,
        [NotNullWhen(true)] out TPlatformInfo? platformInfo
    ) => throw new NotImplementedException();

    /// <inheritdoc />
    public static SurfaceProperty GetSurfaceProperty<T>(T handle, SurfacePropertyName propertyName)
        where T : ISurfaceOrRequestHandle => throw new NotImplementedException();

    /// <inheritdoc />
    public static void SetSurfaceProperty<T>(T handle, SurfaceProperty property)
        where T : ISurfaceOrRequestHandle => throw new NotImplementedException();

    /// <inheritdoc />
    public static EventPumpHandle CreateEventPump(SurfaceHandle relatedSurface) => new(1);

    /// <inheritdoc />
    public static void DestroyEventPump(EventPumpHandle pump) { }

    /// <inheritdoc />
    public static HostEventKind QueryEvent(EventPumpHandle pump, ref int @event) =>
        throw new NotImplementedException();

    /// <inheritdoc />
    public static SurfaceHandle GetEventSurface(EventPumpHandle pump, int @event) =>
        throw new NotImplementedException();

    /// <inheritdoc />
    public static void AcknowledgeEvent(EventPumpHandle pump, int @event) =>
        throw new NotImplementedException();

    /// <inheritdoc />
    public static SurfaceProperty GetEventPropertyChanged(EventPumpHandle pump, int @event) =>
        throw new NotImplementedException();
}
