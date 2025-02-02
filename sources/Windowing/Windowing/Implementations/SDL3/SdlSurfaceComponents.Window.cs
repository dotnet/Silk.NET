// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceWindow
{
    private Rectangle<float> _bounds;
    public Rectangle<float> Bounds
    {
        get => GetBounds(ClientArea);
        set
        {
            var top = 0;
            var left = 0;
            var bottom = 0;
            var right = 0;
            if (
                IsSurfaceInitialized
                && !Sdl.GetWindowBordersSize(
                    Handle,
                    top.AsRef(),
                    left.AsRef(),
                    bottom.AsRef(),
                    right.AsRef()
                )
            )
            {
                Sdl.ThrowError();
            }

            ClientArea = new Rectangle<float>(
                value.Origin.X + left,
                value.Origin.Y - top,
                value.Size.X - left - right,
                value.Size.Y - top - bottom
            );
            _bounds = value;
        }
    }

    private Rectangle<float> GetBounds(Rectangle<float> ca)
    {
        if (!IsSurfaceInitialized)
        {
            return _bounds = ca;
        }

        var top = 0;
        var left = 0;
        var bottom = 0;
        var right = 0;
        if (
            !Sdl.GetWindowBordersSize(
                Handle,
                top.AsRef(),
                left.AsRef(),
                bottom.AsRef(),
                right.AsRef()
            )
        )
        {
            Sdl.ClearError();
        }

        return _bounds = new Rectangle<float>(
            ca.Origin.X - left,
            ca.Origin.Y + top,
            ca.Size.X + left + right,
            ca.Size.Y + top + bottom
        );
    }

    private Rectangle<float> _clientArea = new(-1, -1, 640, 480);
    public Rectangle<float> ClientArea
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return _clientArea;
            }

            var x = 0;
            var y = 0;
            var width = 0;
            var height = 0;
            if (!Sdl.GetWindowPosition(Handle, x.AsRef(), y.AsRef()))
            {
                Sdl.ThrowError();
            }

            if (!Sdl.GetWindowSize(Handle, width.AsRef(), height.AsRef()))
            {
                Sdl.ThrowError();
            }

            return _clientArea = new Rectangle<float>(x, y, width, height);
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                OnWindowCoordinatesChanged(value);
                return;
            }

            var x = (int)value.Origin.X;
            var y = (int)value.Origin.Y;
            var currentDisplay = 0u;
            CheckForDontCare(ref x, ref currentDisplay);
            CheckForDontCare(ref y, ref currentDisplay);
            if (
                !Sdl.SetWindowPosition(Handle, x, y)
                || !Sdl.SetWindowSize(Handle, (int)value.Size.X, (int)value.Size.Y)
            )
            {
                Sdl.ThrowError();
            }

            OnWindowCoordinatesChanged(value);
            return;
            void CheckForDontCare(ref int axis, ref uint display)
            {
                if (axis != -1)
                {
                    return;
                }

                if (display == 0)
                {
                    display = Sdl.GetDisplayForWindow(Handle);
                }

                axis = (int)(Sdl.WindowposUndefinedMask | display);
            }
        }
    }

    public event Action<WindowCoordinatesEvent>? CoordinatesChanged;

    public bool IsCloseRequested
    {
        get;
        set
        {
            var prev = field;
            field = value;
            if (!prev && value)
            {
                DebugPrint("Raising CloseRequested...");
                CloseRequested?.Invoke(new WindowToggleEvent(surface, true));
            }
        }
    }

    public event Action<WindowToggleEvent>? CloseRequested;

    private bool _isVisible = true;
    public bool IsVisible
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return _isVisible;
            }

            return _isVisible = (Sdl.GetWindowFlags(Handle) & Sdl.WindowHidden) == 0;
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                OnVisibilityChanged(value);
                return;
            }

            if ((value && !Sdl.ShowWindow(Handle)) || (!value && !Sdl.HideWindow(Handle)))
            {
                Sdl.ThrowError();
            }
            OnVisibilityChanged(value);
        }
    }

    public event Action<WindowToggleEvent>? VisibilityChanged;

    public bool IsFocused
    {
        get => !IsSurfaceInitialized || (Sdl.GetWindowFlags(Handle) & Sdl.WindowInputFocus) != 0;
        set
        {
            if (!IsSurfaceInitialized || !value)
            {
                return;
            }

            if (!Sdl.RaiseWindow(Handle))
            {
                Sdl.ThrowError();
            }
        }
    }

    public event Action<WindowToggleEvent>? FocusChanged;

    public string Title
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            var title = Sdl.GetWindowTitle(Handle);
            if (title == nullptr)
            {
                Sdl.ThrowError();
            }

            return field = title.ReadToString();
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (!Sdl.SetWindowTitle(Handle, value))
            {
                Sdl.ThrowError();
            }

            field = value;
        }
    } = Assembly.GetEntryAssembly()?.GetName().Name ?? "Silk.NET Application";

    private WindowState _state;

    public WindowState State
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                // The windows vs exclusive fullscreen doesn't need to be up-to-date in _state as they're encoded in the
                // window create flags the same.
                return _state = _state
                    is WindowState.ExclusiveFullscreen
                        or WindowState.WindowedFullscreen
                    ? VideoMode == default
                        ? WindowState.WindowedFullscreen
                        : WindowState.ExclusiveFullscreen
                    : _state;
            }
            var flags = Sdl.GetWindowFlags(Handle);
            return _state =
                (flags & Sdl.WindowFullscreen) != 0
                    ? Sdl.GetWindowFullscreenMode(Handle) == nullptr
                        ? WindowState.WindowedFullscreen
                        : WindowState.ExclusiveFullscreen
                    : (flags & Sdl.WindowMaximized) != 0
                        ? WindowState.Maximized
                        : (flags & Sdl.WindowMinimized) != 0
                            ? WindowState.Minimized
                            : WindowState.Normal;
        }
        set => SetState(State, value);
    }

    private void SetState(
        WindowState current,
        WindowState value,
        (VideoMode Silk, Ptr<DisplayMode> Sdl)? exclusiveMode = null,
        SdlDisplay? display = null
    )
    {
        var goingFullscreen =
            value is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen;
        var wasFullscreen =
            current is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen;
        if (current == value && exclusiveMode is null)
        {
            return;
        }

        // Note that if we are changing state, we need to enact the appropriate changes to the video mode.
        // If `value` is not exclusive fullscreen but we have a video mode that indicates that we're in exclusive
        // fullscreen right now, then we'll change our non-default video mode to the default one. If `value` is
        // exclusive fullscreen, then we change our video mode to the first available video mode. Note that because
        // we've checked above whether we're actually enacting a state change, this is always valid so we don't need
        // to care about the previous value of _videoMode.
        display ??= (SdlDisplay)Current;
        var newVideoMode =
            exclusiveMode?.Silk
            ?? (value == WindowState.ExclusiveFullscreen ? display.KnownVideoModes![1] : default);
        if (!IsSurfaceInitialized)
        {
            Return();
            return;
        }

        if (
            (wasFullscreen != goingFullscreen && !Sdl.SetWindowFullscreen(Handle, goingFullscreen))
            || (
                goingFullscreen
                && !Sdl.SetWindowFullscreenMode(
                    Handle,
                    value == WindowState.ExclusiveFullscreen
                        ? exclusiveMode?.Sdl ?? display.DisplayModes[0]
                        : (Ref<DisplayMode>)nullptr
                )
            )
        )
        {
            Sdl.ThrowError();
        }

        Return();
        return;
        void Return()
        {
            _state = value;
            var oldVideoMode = _videoMode;
            _videoMode = newVideoMode;
            if (oldVideoMode != newVideoMode)
            {
                DebugPrint("Raising VideoModeChanged due to a programmatic change...");
                VideoModeChanged?.Invoke(new VideoModeChangeEvent(surface, newVideoMode));
            }

            if (current != value)
            {
                DebugPrint("Raising StateChanged due to a programmatic change...");
                StateChanged?.Invoke(new WindowStateEvent(surface, current, value));
            }

            if (wasFullscreen != goingFullscreen)
            {
                DebugPrint("Raising AvailableVideoModesChanged due to a window state change...");
                AvailableVideoModesChanged?.Invoke(
                    new DisplayVideoModeAvailabilityChangeEvent(surface, display)
                );
            }
        }
    }

    public event Action<WindowStateEvent>? StateChanged;

    public WindowBorder Border
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            var flags = Sdl.GetWindowFlags(Handle);
            if ((flags & Sdl.WindowResizable) != 0)
            {
                return field = WindowBorder.Resizable;
            }

            if ((flags & Sdl.WindowBorderless) != 0)
            {
                return field = WindowBorder.Hidden;
            }

            return field = WindowBorder.Fixed;
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (
                !Sdl.SetWindowBordered(Handle, value != WindowBorder.Hidden)
                || !Sdl.SetWindowResizable(Handle, value == WindowBorder.Resizable)
            )
            {
                Sdl.ThrowError();
            }

            field = value;
            OnWindowCoordinatesChanged(); // <-- Bounds includes the border
        }
    }

    public bool IsTopMost
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            return field = (Sdl.GetWindowFlags(Handle) & Sdl.WindowAlwaysOnTop) != 0;
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (!Sdl.SetWindowAlwaysOnTop(Handle, value))
            {
                Sdl.ThrowError();
            }

            field = value;
        }
    }

    public event Action<WindowFileEvent>? FileDrop;

    private void InitializeWindow(uint props)
    {
        var clientArea = ClientArea;
        var display = 0u;
        var posX = (int)clientArea.Size.X;
        var posY = (int)clientArea.Size.Y;

        // If the user has specified "don't care", we use the display configured in the display component to determine
        // the position. The Display component is aware of this, and allows the user to select the display without
        // changing the position if IsDisplayDeterminedByPosition is false (if it's true, then ClientArea is changed to
        // go on the correct display anyway). In all other cases, the display is determined by the ClientArea.
        posX =
            CanPositionDetermineDisplay && posX != -1
                ? posX
                : (int)(Sdl.WindowposUndefinedMask | GetDisplayId(ref display));
        posY =
            CanPositionDetermineDisplay && posY != -1
                ? posY
                : (int)(Sdl.WindowposUndefinedMask | GetDisplayId(ref display));

        if (
            !Sdl.SetStringProperty(props, Sdl.PropWindowCreateTitleString, Title)
            || !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateWidthNumber,
                (long)ClientArea.Size.X
            )
            || !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateHeightNumber,
                (long)ClientArea.Size.Y
            )
            || !Sdl.SetNumberProperty(props, Sdl.PropWindowCreateXNumber, posX)
            || !Sdl.SetNumberProperty(props, Sdl.PropWindowCreateYNumber, posY)
        )
        {
            Sdl.ThrowError();
        }

        if (!IsWindowEnabled)
        {
            AddWindowCreateFlags(props, Sdl.WindowResizable | Sdl.WindowFullscreen);
            return;
        }

        AddWindowCreateFlags(
            props,
            Border switch
            {
                WindowBorder.Resizable => Sdl.WindowResizable,
                WindowBorder.Fixed => 0ul,
                WindowBorder.Hidden => Sdl.WindowBorderless,
                _ => throw new ArgumentOutOfRangeException(),
            }
                | State switch
                {
                    WindowState.Normal => 0ul,
                    WindowState.Minimized => Sdl.WindowMinimized,
                    WindowState.Maximized => Sdl.WindowMaximized,
                    WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen =>
                        Sdl.WindowFullscreen,
                    _ => throw new ArgumentOutOfRangeException(),
                }
                | (IsVisible ? 0 : Sdl.WindowHidden)
                | (IsTopMost ? Sdl.WindowAlwaysOnTop : 0)
        );

        return;

        // Helper method so this doesn't ruin my ternaries :)
        // This also intentionally does not call Current so we don't unnecessarily realise SdlDisplay objects.
        uint GetDisplayId(ref uint cache)
        {
            if (cache != 0)
            {
                return cache;
            }

            return cache = _display?.Id ?? Sdl.GetPrimaryDisplay();
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public unsafe bool TrySetIcon(WindowIconVariants icon)
    {
        if (!IsSurfaceInitialized)
        {
            DebugPrint("attempted to set icons before window initialisation");
            return false;
        }

        if (icon.Count < 1)
        {
            return Sdl.SetWindowIcon(Handle, nullptr);
        }

        // SAFETY: Defensive checks to ensure we don't stackalloc unsafe amounts.
        ArgumentOutOfRangeException.ThrowIfGreaterThan(icon.Count, 15);
        ArgumentOutOfRangeException.ThrowIfLessThan(icon.Count, 0);
        var surfaces = stackalloc Silk.NET.SDL.Surface*[icon.Count];

        // Use a recursive function to set the icon, as we need to pin each individual icon.
        return SetWindowIcon(Handle, surfaces, ref icon, 0, icon.Count - 1);

        // From SDL docs: No copy is made of the pixel data. Pixel data is not managed automatically; you must free the
        // surface before you free the pixel data. (SDL_CreateSurfaceFrom)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool SetWindowIcon(
            WindowHandle handle,
            Silk.NET.SDL.Surface** surfaces,
            ref WindowIconVariants variants,
            int current,
            int remaining
        )
        {
            ref var icon = ref variants[current];
            fixed (byte* data = icon.Data)
            {
                // Load this icon variant.
                var surface = Sdl.CreateSurfaceFrom(
                    icon.Width,
                    icon.Height,
                    PixelFormat.Rgba32,
                    data,
                    0
                );
                if (surface == nullptr)
                {
                    return false;
                }

                // Set this icon variant as a... variant... of the first variant we encountered. We'll pass that variant
                // down to SDL_SetWindowIcon later.
                if (current != 0 && Sdl.AddSurfaceAlternateImage(surfaces[0], surface) == 0)
                {
                    Sdl.DestroySurface(surface);
                    return false;
                }

                surfaces[current] = surface;

                // Copy of the data is made here, so we're safe to exit our `fixed` blocks now.
                bool ret;
                if (remaining == 0)
                {
                    ret = Sdl.SetWindowIcon(handle, surfaces[0]) == 1;
                }
                else
                {
                    // Load the next icon variant.
                    ret = SetWindowIcon(handle, surfaces, ref variants, current + 1, remaining - 1);
                }

                Sdl.DestroySurface(surface);
                return ret;
            }
        }
    }

    public void OnVisibilityChanged(bool isVisible)
    {
        var wasVisible = _isVisible;
        _isVisible = isVisible;
        if (wasVisible != isVisible)
        {
            DebugPrint("Raising VisibilityChanged...");
            VisibilityChanged?.Invoke(new WindowToggleEvent(surface, isVisible));
        }
    }

    public void OnWindowCoordinatesChanged(Rectangle<float>? requestedClientArea = null)
    {
        var oldBounds = _bounds;
        var oldClientArea = _clientArea;
        Rectangle<float> newBounds;
        Rectangle<float> newClientArea;
        if (requestedClientArea is { } ca)
        {
            newBounds = GetBounds(ca);
            newClientArea = ca;
        }
        else
        {
            newBounds = Bounds;
            newClientArea = _clientArea; // <-- not a typo! Bounds getter calls ClientArea getter and updates this
        }

        _clientArea = newClientArea;
        _bounds = newBounds;
        if (oldBounds == newBounds && oldClientArea == newClientArea)
        {
            return;
        }

        DebugPrint("Raising CoordinatesChanged...");
        CoordinatesChanged?.Invoke(
            new WindowCoordinatesEvent(surface, oldBounds, oldClientArea, newBounds, newClientArea)
        );
    }

    private void PostInitializeWindow() => OnWindowCoordinatesChanged();

    public void OnWindowStateChanged(WindowState? newState = null)
    {
        var oldState = _state;
        _state = newState ?? State;
        if (oldState == _state)
        {
            return;
        }

        DebugPrint("Raising StateChanged due to a detected change...");
        StateChanged?.Invoke(new WindowStateEvent(surface, oldState, _state));
        if (
            oldState is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen
            || _state is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen
        )
        {
            OnVideoModeChanged(); // just in case of exclusive vs windowed differences
        }
    }

    public void OnWindowFocusChanged(bool value)
    {
        DebugPrint("Raising FocusChanged...");
        FocusChanged?.Invoke(new WindowToggleEvent(surface, value));
    }

    public void OnFileDrop(IReadOnlyList<string> droppedFiles)
    {
        DebugPrint("Raising FileDrop...");
        FileDrop?.Invoke(new WindowFileEvent(surface, droppedFiles));
    }
}
