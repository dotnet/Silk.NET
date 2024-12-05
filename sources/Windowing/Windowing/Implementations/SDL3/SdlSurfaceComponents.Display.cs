// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceDisplay
{
    [field: AllowNull, MaybeNull]
    public IDisplay Current
    {
        get
        {
            if (!IsSurfaceInitialized && field is { } ret)
            {
                return ret;
            }

            var current = IsSurfaceInitialized
                ? Sdl.GetDisplayForWindow(Handle)
                : Sdl.GetPrimaryDisplay();
            if (current == 0)
            {
                Sdl.ThrowError();
            }

            foreach (var display in _displays ??= CreateDisplays())
            {
                if (display.Id == current)
                {
                    return field = display;
                }
            }

            throw new InvalidOperationException(
                "Mismatch between displays enumerated from the underlying API and the current display reported by "
                    + "the underlying API."
            );
        }
        set
        {
            if (value.Equals(field))
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
            if (!IsSurfaceInitialized)
            {
                Return(sdlDisplay, videoMode);
                return;
            }

            if (videoMode == default) // not fullscreen
            {
                var x = 0;
                var y = 0;
                if (!Sdl.GetWindowPosition(Handle, x.AsRef(), y.AsRef()))
                {
                    Sdl.ThrowError();
                }

                var currentDisplayWorkArea = Current.WorkArea;
                var newDisplayWorkArea = sdlDisplay.WorkArea;
                if (
                    !Sdl.SetWindowPosition(
                        Handle,
                        (int)(x - currentDisplayWorkArea.Origin.X + newDisplayWorkArea.Origin.X),
                        (int)(y - currentDisplayWorkArea.Origin.Y + newDisplayWorkArea.Origin.Y)
                    )
                )
                {
                    Sdl.ThrowError();
                }
            }
            else if (
                !Sdl.SetWindowFullscreenMode(Handle, (Ref<DisplayMode>)sdlDisplay.DisplayModes[0])
            )
            {
                Sdl.ThrowError();
            }

            Return(sdlDisplay, videoMode);
            return;
            void Return(SdlDisplay display, VideoMode vidMode)
            {
                _videoMode = vidMode == default ? vidMode : display.KnownVideoModes![1];
                field = value;
                AvailableVideoModesChanged?.Invoke(
                    new DisplayVideoModeAvailabilityChangeEvent(surface, display)
                );
            }
        }
    }

    private SdlDisplay[]? _displays;

    public IReadOnlyList<IDisplay> Available => _displays ??= CreateDisplays();

    private static SdlDisplay[] CreateDisplays()
    {
        var count = 0;
        var displays = Sdl.GetDisplays(count.AsRef());
        var ret = new SdlDisplay[count];
        for (nuint i = 0; (int)i < count; i++)
        {
            ret[i] = new SdlDisplay(displays[i]);
        }

        Sdl.Free((Ref)displays);
        return ret;
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
            if (_videoMode == value)
            {
                return;
            }

            var display = (SdlDisplay)Current;
            if (!display.KnownVideoModes!.Contains(value))
            {
                throw new ArgumentException(
                    "VideoMode was not one of the valid AvailableVideoModes.",
                    nameof(value)
                );
            }

            if (!IsSurfaceInitialized)
            {
                _videoMode = value;
                return;
            }

            for (var i = 0; i < display.KnownVideoModes!.Count; i++)
            {
                if (display.KnownVideoModes[i] != value)
                {
                    continue;
                }

                if (
                    !Sdl.SetWindowFullscreenMode(
                        Handle,
                        (Ref<DisplayMode>)(i == 0 ? nullptr : display.DisplayModes[i - 1])
                    )
                )
                {
                    Sdl.ThrowError();
                }

                _videoMode = value;
                break;
            }

            throw new InvalidOperationException(
                "Mismatch between display modes enumerated from the underlying API and the current display mode "
                    + "reported by the underlying API."
            );
        }
    }

    public IReadOnlyList<VideoMode> AvailableVideoModes => Current.KnownVideoModes ?? [default];

    public event Action<DisplayChangeEvent>? CurrentDisplayChanged;
    public event Action<DisplayAvailabilityChangeEvent>? AvailableChanged;
    public event Action<DisplayVideoModeAvailabilityChangeEvent>? AvailableVideoModesChanged;

    private void PreInitializeDisplay() { }

    private void InitializeDisplay(uint props) { }
}
