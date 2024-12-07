// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceWindow
{
    public Rectangle<float> Bounds
    {
        get
        {
            var ca = ClientArea;
            if (!IsSurfaceInitialized)
            {
                return ca;
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
                Sdl.ThrowError();
            }

            return new Rectangle<float>(
                ca.Origin.X - left,
                ca.Origin.Y + top,
                ca.Size.X + left + right,
                ca.Size.Y + top + bottom
            );
        }
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
        }
    }

    public Rectangle<float> ClientArea
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
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

            return field = new Rectangle<float>(x, y, width, height);
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if (
                !Sdl.SetWindowPosition(Handle, (int)value.Origin.X, (int)value.Origin.Y)
                || !Sdl.SetWindowSize(Handle, (int)value.Size.X, (int)value.Size.Y)
            )
            {
                Sdl.ThrowError();
            }

            field = value;
        }
    } = new(-1, -1, 640, 480);

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
                DebugPrint("Raising CloseRequested");
                CloseRequested?.Invoke(new WindowToggleEvent(surface, true));
            }
        }
    }

    public bool IsVisible
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return field;
            }

            return field = (Sdl.GetWindowFlags(Handle) & Sdl.WindowHidden) == 0;
        }
        set
        {
            if (!IsSurfaceInitialized)
            {
                field = value;
                return;
            }

            if ((value && !Sdl.ShowWindow(Handle)) || (!value && !Sdl.HideWindow(Handle)))
            {
                Sdl.ThrowError();
            }
        }
    } = true;

    public event Action<WindowToggleEvent>? CloseRequested;

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

    private ulong _stateFlags;

    public WindowState State
    {
        get
        {
            var flags = IsSurfaceInitialized
                ? _stateFlags = Sdl.GetWindowFlags(Handle)
                : _stateFlags;
            return (flags & Sdl.WindowFullscreen) != 0
                ? (IsSurfaceInitialized && Sdl.GetWindowFullscreenMode(Handle) == nullptr)
                || (!IsSurfaceInitialized && VideoMode == default)
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
        if (current == value && exclusiveMode is null)
        {
            return;
        }

        var newStateFlags = value switch
        {
            WindowState.Normal => 0ul,
            WindowState.Minimized => Sdl.WindowMinimized,
            WindowState.Maximized => Sdl.WindowMaximized,
            WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen =>
                Sdl.WindowFullscreen,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };

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
            _stateFlags = newStateFlags;
            _videoMode = newVideoMode;
            return;
        }

        var goingFullscreen =
            value is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen;
        if (
            (
                current is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen
                    != goingFullscreen
                && !Sdl.SetWindowFullscreen(Handle, goingFullscreen)
            )
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

        _stateFlags = newStateFlags;
        _videoMode = newVideoMode;
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
        )
        {
            Sdl.ThrowError();
        }

        // TODO borders
        if (
            !Sdl.SetNumberProperty(
                props,
                Sdl.PropWindowCreateFlagsNumber,
                Sdl.GetNumberProperty(props, Sdl.PropWindowCreateFlagsNumber, 0)
                    | (long)Sdl.WindowResizable
            )
        )
        {
            Sdl.ThrowError();
        }

        if (!IsWindowEnabled)
        {
            return;
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
}
