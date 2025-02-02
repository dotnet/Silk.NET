// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceDisplay
{
    private SdlDisplay? _display;
    private bool CanPositionDetermineDisplay =>
        IsWindowEnabled
        && _state is not (WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen);

    private bool IsDisplayDeterminedByPosition =>
        CanPositionDetermineDisplay && ClientArea is not ({ Origin.X: -1 } or { Origin.Y: -1 });

    public IDisplay Current
    {
        get
        {
            // If Window decoration is not supported, then the display field is the exclusive determinant of the
            // display. Note that if the surface is initialized we defer to SDL to get the most accurate result.
            if (!IsSurfaceInitialized && !IsDisplayDeterminedByPosition && _display is { } ret)
            {
                return ret;
            }

            uint current;
            if (IsSurfaceInitialized)
            {
                // Get the most up-to-date value.
                current = Sdl.GetDisplayForWindow(Handle);
            }
            else if (IsDisplayDeterminedByPosition)
            {
                // Determine the display from the requested position. -1 indicates "don't care" for which _display is
                // the determinant.
                var ca = ClientArea;
                var rect = new Rect
                {
                    X = (int)ca.Origin.X,
                    Y = (int)ca.Origin.Y,
                    W = (int)ca.Size.X,
                    H = (int)ca.Size.Y,
                };
                current = Sdl.GetDisplayForRect(rect.AsRef());
            }
            else
            {
                current = Sdl.GetPrimaryDisplay();
            }

            if (current == 0)
            {
                Sdl.ThrowError();
            }

            foreach (var display in _displays ??= CreateDisplays())
            {
                if (display.Id == current)
                {
                    return _display = display;
                }
            }

            throw new InvalidOperationException(
                "Mismatch between displays enumerated from the underlying API and the current display reported by "
                    + "the underlying API."
            );
        }
        set
        {
            var current = Current;
            if (value.Equals(current))
            {
                return;
            }

            SdlDisplay? sdlDisplay = null;
            foreach (var display in _displays ??= CreateDisplays())
            {
                if (display.Equals(value))
                {
                    // in case value was from another surface, see IDisplay docs for more info.
                    // vv----------------------------------------------------------------------
                    value = sdlDisplay = display;
                    break;
                }
            }

            if (sdlDisplay is null)
            {
                throw new ArgumentException(
                    "Display was not one of the Available displays (or that of a related surface).",
                    nameof(value)
                );
            }

            var videoMode = VideoMode;
            if (!IsSurfaceInitialized && !IsDisplayDeterminedByPosition)
            {
                Return(sdlDisplay, videoMode);
                return;
            }

            if (videoMode == default) // not fullscreen
            {
                GetPosition(out var x, out var y);
                var currentDisplayWorkArea = current.WorkArea;
                var newDisplayWorkArea = sdlDisplay.WorkArea;
                SetPosition(
                    (int)(x - currentDisplayWorkArea.Origin.X + newDisplayWorkArea.Origin.X),
                    (int)(y - currentDisplayWorkArea.Origin.Y + newDisplayWorkArea.Origin.Y)
                );
            }
            else if (
                IsSurfaceInitialized
                && !Sdl.SetWindowFullscreenMode(
                    Handle,
                    (Ref<DisplayMode>)sdlDisplay.DisplayModes[0]
                )
            )
            {
                Sdl.ThrowError();
            }

            Return(sdlDisplay, videoMode);
            return;
            void Return(SdlDisplay display, VideoMode vidMode)
            {
                // If the video mode indicates that we are not exclusive fullscreen, then we keep it as it is.
                // Otherwise, we have just changed display and have changed to the first known exclusive video mode.
                _videoMode = vidMode == default ? vidMode : display.KnownVideoModes![1];
                var oldDisplay = _display;
                _display = display;

                // if oldDisplay is null, we don't have enough confidence to raise an event.
                if (!(oldDisplay?.Equals(display) ?? true))
                {
                    DebugPrint("Raising CurrentDisplayChanged due to a programmatic change...");
                    CurrentDisplayChanged?.Invoke(new DisplayChangeEvent(surface, display));
                }

                if (
                    _state
                    is not (WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen)
                )
                {
                    return;
                }

                DebugPrint(
                    "Raising AvailableVideoModes due to current fullscreen display changing..."
                );
                AvailableVideoModesChanged?.Invoke(
                    new DisplayVideoModeAvailabilityChangeEvent(surface, display)
                );
            }

            void GetPosition(out int x, out int y)
            {
                (x, y) = (0, 0);
                if (!IsSurfaceInitialized)
                {
                    var ca = ClientArea;
                    (x, y) = ((int)ca.Origin.X, (int)ca.Origin.Y);
                    return;
                }

                if (!Sdl.GetWindowPosition(Handle, x.AsRef(), y.AsRef()))
                {
                    Sdl.ThrowError();
                }
            }

            void SetPosition(int x, int y)
            {
                if (!IsSurfaceInitialized)
                {
                    ClientArea = ClientArea with { Origin = new Vector2D<float>(x, y) };
                    return;
                }

                if (!Sdl.SetWindowPosition(Handle, x, y))
                {
                    Sdl.ThrowError();
                }
            }
        }
    }

    private SdlDisplay[]? _displays;

    public IReadOnlyList<IDisplay> Available => _displays ??= CreateDisplays();

    private SdlDisplay[] CreateDisplays(SdlDisplay[]? reuse = null)
    {
        var count = 0;
        var displays = Sdl.GetDisplays(count.AsRef());
        var ret = new SdlDisplay?[count];
        for (nuint i = 0; (int)i < count; i++)
        {
            var id = displays[i];
            if (reuse is not null)
            {
                foreach (var display in reuse)
                {
                    if (display.Id == id)
                    {
                        ret[i] = display;
                        break;
                    }
                }
            }
            ret[i] ??= new SdlDisplay(surface, id);
        }

        Sdl.Free((Ref)displays);
        return ret!;
    }

    private VideoMode _videoMode;

    public VideoMode VideoMode
    {
        get
        {
            if (!IsSurfaceInitialized)
            {
                return _videoMode;
            }

            var displayMode = Sdl.GetWindowFullscreenMode(Handle);
            if (displayMode == nullptr)
            {
                return default;
            }

            var display = (SdlDisplay)Current;
            for (var i = 0; i < display.DisplayModes.Length; i++)
            {
                if (display.DisplayModes[i] == displayMode)
                {
                    return _videoMode = display.KnownVideoModes![i + 1];
                }
            }

            throw new InvalidOperationException(
                "Mismatch between display modes enumerated from the underlying API and the current display mode "
                    + "reported by the underlying API."
            );
        }
        set
        {
            var currentState = State;
            if (
                currentState
                is not (WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen)
            )
            {
                if (value != default)
                {
                    ThrowBadVideoMode(nameof(value));
                }

                return;
            }

            if ((_videoMode = VideoMode) == value)
            {
                return;
            }

            var display = (SdlDisplay)Current;
            var displayMode = GetDisplayMode(display, in value);
            SetState(
                currentState,
                value == default ? WindowState.WindowedFullscreen : WindowState.ExclusiveFullscreen,
                (value, displayMode),
                display
            );
        }
    }

    private static void ThrowBadVideoMode(string? arg) =>
        throw new ArgumentException(
            "The given video mode is not one of the AvailableVideoModes.",
            arg
        );

    private Ptr<DisplayMode> GetDisplayMode(SdlDisplay display, in VideoMode value)
    {
        Ptr<DisplayMode> displayMode = nullptr;
        var found = false;
        for (var i = 0; i < display.KnownVideoModes?.Count; i++)
        {
            if (display.KnownVideoModes[i] != value)
            {
                continue;
            }

            if (i > 0)
            {
                displayMode = display.DisplayModes[i - 1];
            }

            found = true;
            break;
        }

        if (!found)
        {
            ThrowBadVideoMode(nameof(value));
        }

        return displayMode;
    }

    public IReadOnlyList<VideoMode> AvailableVideoModes =>
        State is not (WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen)
            ? [default]
            : Current.KnownVideoModes ?? [default];

    public event Action<DisplayChangeEvent>? CurrentDisplayChanged;
    public event Action<DisplayAvailabilityChangeEvent>? AvailableChanged;
    public event Action<DisplayVideoModeAvailabilityChangeEvent>? AvailableVideoModesChanged;
    public event Action<VideoModeChangeEvent>? VideoModeChanged;

    internal void OnAvailableDisplaysChanged()
    {
        if (_displays is not null)
        {
            // Recreate _displays if it's already created (as this indicates the user is interested in the display
            // component). If not, we'll do this next time the user accesses display information. This prevents needless
            // work and allocation for something the user may not be interested in.
            _displays = CreateDisplays(_displays);
        }

        DebugPrint("Raising AvailableChanged...");
        AvailableChanged?.Invoke(new DisplayAvailabilityChangeEvent(surface));
    }

    internal void OnDisplayCoordinatesChanged(uint id)
    {
        if (_displays is null)
        {
            // User doesn't care.
            return;
        }

        foreach (var display in _displays)
        {
            if (display.Id != id)
            {
                continue;
            }

            display.OnCoordinatesChanged();
            break;
        }
    }

    // Called for either a desktop mode change or a current mode change. Neither is used to directly raise an event,
    // rather this is used as an indicator that the known video modes might've changed to try and raise
    // KnownVideoModesChanged.
    internal void OnPotentialVideoModeChanges(uint id, out bool isCurrent, uint currentDisplay = 0)
    {
        var current = currentDisplay == 0 ? Sdl.GetDisplayForWindow(Handle) : currentDisplay;
        isCurrent = current == id;
        if (_displays is null)
        {
            // User doesn't care.
            return;
        }

        foreach (var display in _displays)
        {
            if (display.Id != id)
            {
                continue;
            }

            if (
                display.OnModeChanged()
                && isCurrent
                && _state is WindowState.ExclusiveFullscreen or WindowState.WindowedFullscreen
            )
            {
                DebugPrint(
                    "Raising AvailableVideoModesChanged due to a detected change of KnownVideoModes in the current "
                        + "fullscreen display..."
                );
                AvailableVideoModesChanged?.Invoke(
                    new DisplayVideoModeAvailabilityChangeEvent(surface, display)
                );
            }

            break;
        }
    }

    public void OnVideoModeChanged()
    {
        var oldVideoMode = _videoMode;
        var newVideoMode = VideoMode;
        if (oldVideoMode != newVideoMode)
        {
            DebugPrint("Raising VideoModeChanged due to a detected change...");
            VideoModeChanged?.Invoke(new VideoModeChangeEvent(surface, newVideoMode));
        }
    }

    public void OnCurrentDisplayChanged() =>
        CurrentDisplayChanged?.Invoke(new DisplayChangeEvent(surface, Current));

    private void PostInitializeDisplay()
    {
        if (
            _state == WindowState.ExclusiveFullscreen
            && !Sdl.SetWindowFullscreenMode(
                Handle,
                (Ref<DisplayMode>)GetDisplayMode((SdlDisplay)Current, in _videoMode)
            )
        )
        {
            Sdl.ThrowError();
        }
    }
}
