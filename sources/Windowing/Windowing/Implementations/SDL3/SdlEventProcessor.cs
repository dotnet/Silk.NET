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
    public static void DeliverEvent(ref Event @event)
    {
        switch (@event.Common.Type)
        {
            case (uint)EventType.Quit:
            case (uint)EventType.LowMemory:
            case (uint)EventType.Terminating:
            case (uint)EventType.WillEnterBackground:
            case (uint)EventType.DidEnterBackground:
            case (uint)EventType.WillEnterForeground:
            case (uint)EventType.DidEnterForeground:
            {
                break;
            }
            case (uint)EventType.LocaleChanged:
                break;
            case (uint)EventType.SystemThemeChanged:
                break;
            case (uint)EventType.DisplayOrientation:
                break;
            case (uint)EventType.DisplayAdded:
                break;
            case (uint)EventType.DisplayRemoved:
                break;
            case (uint)EventType.DisplayMoved:
                break;
            case (uint)EventType.DisplayDesktopModeChanged:
                break;
            case (uint)EventType.DisplayCurrentModeChanged:
                break;
            case (uint)EventType.DisplayContentScaleChanged:
                break;
            case (uint)EventType.WindowShown:
                break;
            case (uint)EventType.WindowHidden:
                break;
            case (uint)EventType.WindowExposed:
                break;
            case (uint)EventType.WindowMoved:
                break;
            case (uint)EventType.WindowResized:
                break;
            case (uint)EventType.WindowPixelSizeChanged:
                break;
            case (uint)EventType.WindowMetalViewResized:
                break;
            case (uint)EventType.WindowMinimized:
                break;
            case (uint)EventType.WindowMaximized:
                break;
            case (uint)EventType.WindowRestored:
                break;
            case (uint)EventType.WindowMouseEnter:
                break;
            case (uint)EventType.WindowMouseLeave:
                break;
            case (uint)EventType.WindowFocusGained:
                break;
            case (uint)EventType.WindowFocusLost:
                break;
            case (uint)EventType.WindowCloseRequested:
            {
                if (
                    (_surfaces?.TryGetValue(@event.Window.WindowID, out var surface) ?? false)
                    && surface.Window is { } window
                )
                {
                    window.IsCloseRequested = true;
                }
                break;
            }
            case (uint)EventType.WindowHitTest:
                break;
            case (uint)EventType.WindowIccprofChanged:
                break;
            case (uint)EventType.WindowDisplayChanged:
                break;
            case (uint)EventType.WindowDisplayScaleChanged:
                break;
            case (uint)EventType.WindowSafeAreaChanged:
                break;
            case (uint)EventType.WindowOccluded:
                break;
            case (uint)EventType.WindowEnterFullscreen:
                break;
            case (uint)EventType.WindowLeaveFullscreen:
                break;
            case (uint)EventType.WindowDestroyed:
                break;
            case (uint)EventType.WindowHdrStateChanged:
                break;
            case (uint)EventType.DropFile:
                break;
            case (uint)EventType.DropText:
                break;
            case (uint)EventType.DropBegin:
                break;
            case (uint)EventType.DropComplete:
                break;
            case (uint)EventType.DropPosition:
                break;
            default:
            {
                return;
            }
        }
    }
}
