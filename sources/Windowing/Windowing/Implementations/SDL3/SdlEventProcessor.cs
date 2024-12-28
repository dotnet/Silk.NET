// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal static class SdlEventProcessor
{
    private static BreakneckLock _lock;
    private static uint _emptyEvent;
    private static Dictionary<uint, SdlSurface>? _surfaces;

    // Should be called on the event thread, but given that DeliverEvent can be called on any thread, we need to lock.
    public static void AddSurface(uint id, SdlSurface surface)
    {
        var taken = false;
        _lock.Enter(ref taken);
        if (!taken)
        {
            // should never happen
            return;
        }

        (_surfaces ??= []).Add(id, surface);
        _lock.Exit();
    }

    // Should be called on the event thread, but given that DeliverEvent can be called on any thread, we need to lock.
    public static void RemoveSurface(uint id)
    {
        var taken = false;
        _lock.Enter(ref taken);
        if (!taken)
        {
            // should never happen
            return;
        }

        if ((_surfaces?.Remove(id) ?? false) && _surfaces.Count == 0)
        {
            _surfaces = null;
        }

        _lock.Exit();
    }

    // Can be called on any thread
    public static void ContinueEvents()
    {
        var taken = false;
        _lock.Enter(ref taken);
        if (!taken)
        {
            // should never happen
            return;
        }

        if (_emptyEvent == 0)
        {
            _emptyEvent = Sdl.RegisterEvents(1);
        }

        _lock.Exit();
        var @event = new Event { Type = _emptyEvent };
        if (!Sdl.PushEvent(@event.AsRef()))
        {
            Sdl.ThrowError();
        }
    }

    // Can be called on any thread, but for events we recognise we assume that's the event thread
    private static List<string>? _droppedFiles;

    public static unsafe void DeliverEvent(ref Event @event)
    {
        if (_surfaces is null)
        {
            return;
        }

        SdlSurface? surface = null;
        if (
            @event.Type is >= (uint)EventType.WindowFirst and <= (uint)EventType.WindowLast
            && !_surfaces.TryGetValue(@event.Window.WindowID, out surface)
        )
        {
            return;
        }

        var currentDisplay = 0u; // used to omit a SDL_GetDisplayForWindow lookup in a goto case.
        switch (@event.Common.Type)
        {
            // case (uint)EventType.LocaleChanged:
            // case (uint)EventType.SystemThemeChanged:
            // case (uint)EventType.DisplayOrientation:
            // case (uint)EventType.WindowMouseEnter:
            // case (uint)EventType.WindowMouseLeave:
            // case (uint)EventType.WindowHitTest:
            // case (uint)EventType.WindowIccprofChanged:
            // case (uint)EventType.WindowHdrStateChanged:
            // case (uint)EventType.WindowSafeAreaChanged:
            // case (uint)EventType.WindowOccluded:
            // case (uint)EventType.WindowDestroyed:
            // case (uint)EventType.DropText:
            // case (uint)EventType.DropPosition:
            case (uint)EventType.Quit
            or (uint)EventType.Terminating:
            {
                // Treating this as "the root surface(s) is requested to close" - because of the guarantees that
                // IsCloseRequested provides regarding the event also applying to children, see the docs for more info.

                var isRequest =
                    SdlSurfaceComponents.IsWindowEnabled
                    && @event.Common.Type != (uint)EventType.Terminating;
                foreach (var knownSurface in _surfaces.Values)
                {
                    if (knownSurface.Parent is not null)
                    {
                        continue;
                    }

                    if (isRequest)
                    {
                        knownSurface.Window!.IsCloseRequested = true;
                    }
                    else
                    {
                        knownSurface.Terminate();
                    }
                }

                break;
            }
            case (uint)EventType.LowMemory:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.OnLowMemory();
                }

                break;
            }
            case (uint)EventType.WillEnterBackground:
            // case (uint)EventType.DidEnterBackground:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.OnPausing();
                }
                break;
            }
            case (uint)EventType.WillEnterForeground:
            // case (uint)EventType.DidEnterForeground:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.OnResuming();
                }
                break;
            }
            case (uint)EventType.DisplayAdded:
            case (uint)EventType.DisplayRemoved:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.Impl.OnAvailableDisplaysChanged();
                }
                break;
            }
            case (uint)EventType.DisplayMoved:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.Impl.OnDisplayCoordinatesChanged(@event.Display.DisplayID);
                }
                break;
            }
            case (uint)EventType.DisplayDesktopModeChanged:
            case (uint)EventType.DisplayCurrentModeChanged:
            case (uint)EventType.DisplayContentScaleChanged:
            {
                foreach (var knownSurface in _surfaces.Values)
                {
                    knownSurface.Impl.OnPotentialVideoModeChanges(
                        @event.Display.DisplayID,
                        out var isDisplayCurrent,
                        currentDisplay
                    );
                    if (!isDisplayCurrent)
                    {
                        continue;
                    }

                    knownSurface.Impl.OnVideoModeChanged();
                    knownSurface.Impl.OnPotentialScaleChanges();
                }
                break;
            }
            case (uint)EventType.WindowDisplayScaleChanged:
            {
                @event = @event with
                {
                    Display = @event.Display with
                    {
                        DisplayID = currentDisplay = Sdl.GetDisplayForWindow(surface!.Impl.Handle),
                    },
                };
                goto case (uint)EventType.DisplayContentScaleChanged;
            }
            case (uint)EventType.WindowShown when SdlSurfaceComponents.IsWindowEnabled:
            case (uint)EventType.WindowHidden when SdlSurfaceComponents.IsWindowEnabled:
            // case (uint)EventType.WindowExposed:
            {
                surface!.Impl.OnVisibilityChanged(@event.Type == (uint)EventType.WindowShown);
                break;
            }
            case (uint)EventType.WindowMoved when SdlSurfaceComponents.IsWindowEnabled:
            case (uint)EventType.WindowResized when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowCoordinatesChanged();
                break;
            }
            // case (uint)EventType.WindowMetalViewResized:
            case (uint)EventType.WindowPixelSizeChanged:
            {
                surface!.OnDrawableSizeChanged();
                break;
            }
            case (uint)EventType.WindowMinimized when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowStateChanged(WindowState.Minimized);
                break;
            }
            case (uint)EventType.WindowMaximized when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowStateChanged(WindowState.Maximized);
                break;
            }
            case (uint)EventType.WindowRestored when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowStateChanged(WindowState.Normal);
                break;
            }
            case (uint)EventType.WindowFocusGained when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowFocusChanged(true);
                break;
            }
            case (uint)EventType.WindowFocusLost when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.OnWindowFocusChanged(false);
                break;
            }
            case (uint)EventType.WindowCloseRequested when SdlSurfaceComponents.IsWindowEnabled:
            {
                surface!.Impl.IsCloseRequested = true;
                break;
            }
            case (uint)EventType.WindowDisplayChanged:
            {
                surface!.Impl.OnCurrentDisplayChanged();
                break;
            }
            case (uint)EventType.WindowEnterFullscreen:
            case (uint)EventType.WindowLeaveFullscreen:
            {
                // Also takes care of video mode related things.
                surface!.Impl.OnWindowStateChanged();
                break;
            }
            case (uint)EventType.DropBegin:
            {
                _droppedFiles = [];
                break;
            }
            case (uint)EventType.DropFile:
            {
                _droppedFiles?.Add((string)(Ptr<sbyte>)@event.Drop.Data);
                break;
            }
            case (uint)EventType.DropComplete:
            {
                if (
                    _droppedFiles is null
                    || !_surfaces.TryGetValue(@event.Window.WindowID, out surface)
                )
                {
                    _droppedFiles = null;
                    break;
                }

                surface.Impl.OnFileDrop(_droppedFiles);
                break;
            }
            default:
            {
                return;
            }
        }
    }
}
