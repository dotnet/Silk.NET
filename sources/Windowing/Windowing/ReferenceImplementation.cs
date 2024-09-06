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

    private static Event _event;

    /// <inheritdoc />
    public static HostEventKind QueryEvent(EventPumpHandle pump, ref int @event)
    {
        var ts = unchecked((int)_event.Common.Timestamp);
        if (ts != 0 && @event == ts)
        {
            return HostEventKind.None;
        }

        if (!Sdl.PollEvent(_event.AsRef()))
        {
            return HostEventKind.None;
        }

        return (EventType)_event.Type switch
        {
            EventType.Quit => HostEventKind.AppLifecycleTerminationRequested,
            EventType.Terminating => HostEventKind.AppLifecycleTerminating,
            EventType.LowMemory => HostEventKind.AppLifecycleLowMemoryWarning,
            EventType.WillEnterBackground => HostEventKind.AppLifecyclePausing,
            EventType.DidEnterBackground => HostEventKind.AppLifecyclePaused,
            EventType.WillEnterForeground => HostEventKind.AppLifecycleResuming,
            EventType.DidEnterForeground => HostEventKind.AppLifecycleResumed,
            // ???
            EventType.LocaleChanged
            or EventType.SystemThemeChanged
                => HostEventKind.None,
            // TODO monitor API
            EventType.DisplayOrientation
            or EventType.DisplayAdded
            or EventType.DisplayRemoved
            or EventType.DisplayMoved
            or EventType.DisplayContentScaleChanged
            or EventType.DisplayHdrStateChanged
                => HostEventKind.None,
            EventType.WindowShown
            or EventType.WindowHidden
            or EventType.WindowMoved
            or EventType.WindowResized
            or EventType.WindowPixelSizeChanged
            or EventType.WindowMinimized
            or EventType.WindowMaximized
            or EventType.WindowRestored
            or EventType.WindowMouseEnter
            or EventType.WindowMouseLeave
            or EventType.WindowFocusGained
            or EventType.WindowFocusLost
            or EventType.WindowCloseRequested
            or EventType.WindowTakeFocus
            or EventType.WindowHitTest
            or EventType.WindowIccprofChanged
            or EventType.WindowDisplayChanged
            or EventType.WindowDisplayScaleChanged
            or EventType.WindowOccluded
            or EventType.WindowEnterFullscreen
            or EventType.WindowLeaveFullscreen
            or EventType.WindowPenEnter
            or EventType.WindowPenLeave
            or EventType.DropFile // TODO drag and drop
            or EventType.DropText // TODO drag and drop
            or EventType.DropBegin // TODO drag and drop
            or EventType.DropComplete // TODO drag and drop
            or EventType.DropPosition // TODO drag and drop
                => HostEventKind.SurfacePropertyChanged, // TODO
            // Not exposing this one right now, Tick should be invoked which means we'll redraw if we need to.
            EventType.WindowExposed
                => HostEventKind.None,
            EventType.WindowDestroyed => HostEventKind.AppLifecycleTerminating,
            EventType.KeyDown
            or EventType.KeyUp
            or EventType.TextEditing
            or EventType.TextInput
            or EventType.KeymapChanged
            or EventType.KeyboardAdded
            or EventType.KeyboardRemoved
            or EventType.MouseMotion
            or EventType.MouseButtonDown
            or EventType.MouseButtonUp
            or EventType.MouseWheel
            or EventType.MouseAdded
            or EventType.MouseRemoved
            or EventType.JoystickAxisMotion
            or EventType.JoystickBallMotion
            or EventType.JoystickHatMotion
            or EventType.JoystickButtonDown
            or EventType.JoystickButtonUp
            or EventType.JoystickAdded
            or EventType.JoystickRemoved
            or EventType.JoystickBatteryUpdated
            or EventType.JoystickUpdateComplete
            or EventType.GamepadAxisMotion
            or EventType.GamepadButtonDown
            or EventType.GamepadButtonUp
            or EventType.GamepadAdded
            or EventType.GamepadRemoved
            or EventType.GamepadRemapped
            or EventType.GamepadTouchpadDown
            or EventType.GamepadTouchpadMotion
            or EventType.GamepadTouchpadUp
            or EventType.GamepadSensorUpdate
            or EventType.GamepadUpdateComplete
            or EventType.GamepadSteamHandleUpdated
                => HostEventKind.None,
            // TODO touch API in the input HLU one day?
            EventType.FingerDown
            or EventType.FingerUp
            or EventType.FingerMotion
            or EventType.ClipboardUpdate
                => HostEventKind.None,
            // don't care about these
            EventType.AudioDeviceAdded
            or EventType.AudioDeviceRemoved
            or EventType.AudioDeviceFormatChanged
                => HostEventKind.None,
            // TODO drawing API in the input HLU one day?
            EventType.SensorUpdate
            or EventType.PenDown
            or EventType.PenUp
            or EventType.PenMotion
            or EventType.PenButtonDown
            or EventType.PenButtonUp
                => HostEventKind.None,
            // TODO camera API in the input HLU one day?
            EventType.CameraDeviceAdded
            or EventType.CameraDeviceRemoved
            or EventType.CameraDeviceApproved
            or EventType.CameraDeviceDenied
                => HostEventKind.None,
            // don't care about these
            EventType.RenderTargetsReset
            or EventType.RenderDeviceReset
                => HostEventKind.None,
            // EventType.PollSentinel => expr,
            // EventType.User => expr,
            // EventType.Last => expr,
            // EventType.EnumPadding => expr,
            _ => HostEventKind.None
        };
    }

    /// <inheritdoc />
    public static SurfaceHandle GetEventSurface(EventPumpHandle pump, int @event) =>
        throw new NotImplementedException();

    /// <inheritdoc />
    public static void AcknowledgeEvent(EventPumpHandle pump, int @event)
    {
        var ts = unchecked((int)_event.Common.Timestamp);
        if (ts != 0 && @event == ts)
        {
            _event = default;
        }
    }

    /// <inheritdoc />
    public static SurfaceProperty GetEventPropertyChanged(EventPumpHandle pump, int @event) =>
        throw new NotImplementedException();
}
