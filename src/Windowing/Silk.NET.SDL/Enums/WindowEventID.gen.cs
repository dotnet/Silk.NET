// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L154_C9")]
    [NativeName("Name", "SDL_WindowEventID")]
    public enum WindowEventID : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_NONE")]
        WindoweventNone = 0x0,
        [Obsolete("Deprecated in favour of \"Shown\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_SHOWN")]
        WindoweventShown = 0x1,
        [Obsolete("Deprecated in favour of \"Hidden\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_HIDDEN")]
        WindoweventHidden = 0x2,
        [Obsolete("Deprecated in favour of \"Exposed\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_EXPOSED")]
        WindoweventExposed = 0x3,
        [Obsolete("Deprecated in favour of \"Moved\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_MOVED")]
        WindoweventMoved = 0x4,
        [Obsolete("Deprecated in favour of \"Resized\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_RESIZED")]
        WindoweventResized = 0x5,
        [Obsolete("Deprecated in favour of \"SizeChanged\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_SIZE_CHANGED")]
        WindoweventSizeChanged = 0x6,
        [Obsolete("Deprecated in favour of \"Minimized\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_MINIMIZED")]
        WindoweventMinimized = 0x7,
        [Obsolete("Deprecated in favour of \"Maximized\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_MAXIMIZED")]
        WindoweventMaximized = 0x8,
        [Obsolete("Deprecated in favour of \"Restored\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_RESTORED")]
        WindoweventRestored = 0x9,
        [Obsolete("Deprecated in favour of \"Enter\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_ENTER")]
        WindoweventEnter = 0xA,
        [Obsolete("Deprecated in favour of \"Leave\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_LEAVE")]
        WindoweventLeave = 0xB,
        [Obsolete("Deprecated in favour of \"FocusGained\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_GAINED")]
        WindoweventFocusGained = 0xC,
        [Obsolete("Deprecated in favour of \"FocusLost\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_LOST")]
        WindoweventFocusLost = 0xD,
        [Obsolete("Deprecated in favour of \"Close\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_CLOSE")]
        WindoweventClose = 0xE,
        [Obsolete("Deprecated in favour of \"TakeFocus\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_TAKE_FOCUS")]
        WindoweventTakeFocus = 0xF,
        [Obsolete("Deprecated in favour of \"HitTest\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_HIT_TEST")]
        WindoweventHitTest = 0x10,
        [Obsolete("Deprecated in favour of \"IccprofChanged\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_ICCPROF_CHANGED")]
        WindoweventIccprofChanged = 0x11,
        [Obsolete("Deprecated in favour of \"DisplayChanged\"")]
        [NativeName("Name", "SDL_WINDOWEVENT_DISPLAY_CHANGED")]
        WindoweventDisplayChanged = 0x12,
        [NativeName("Name", "SDL_WINDOWEVENT_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_WINDOWEVENT_SHOWN")]
        Shown = 0x1,
        [NativeName("Name", "SDL_WINDOWEVENT_HIDDEN")]
        Hidden = 0x2,
        [NativeName("Name", "SDL_WINDOWEVENT_EXPOSED")]
        Exposed = 0x3,
        [NativeName("Name", "SDL_WINDOWEVENT_MOVED")]
        Moved = 0x4,
        [NativeName("Name", "SDL_WINDOWEVENT_RESIZED")]
        Resized = 0x5,
        [NativeName("Name", "SDL_WINDOWEVENT_SIZE_CHANGED")]
        SizeChanged = 0x6,
        [NativeName("Name", "SDL_WINDOWEVENT_MINIMIZED")]
        Minimized = 0x7,
        [NativeName("Name", "SDL_WINDOWEVENT_MAXIMIZED")]
        Maximized = 0x8,
        [NativeName("Name", "SDL_WINDOWEVENT_RESTORED")]
        Restored = 0x9,
        [NativeName("Name", "SDL_WINDOWEVENT_ENTER")]
        Enter = 0xA,
        [NativeName("Name", "SDL_WINDOWEVENT_LEAVE")]
        Leave = 0xB,
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_GAINED")]
        FocusGained = 0xC,
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_LOST")]
        FocusLost = 0xD,
        [NativeName("Name", "SDL_WINDOWEVENT_CLOSE")]
        Close = 0xE,
        [NativeName("Name", "SDL_WINDOWEVENT_TAKE_FOCUS")]
        TakeFocus = 0xF,
        [NativeName("Name", "SDL_WINDOWEVENT_HIT_TEST")]
        HitTest = 0x10,
        [NativeName("Name", "SDL_WINDOWEVENT_ICCPROF_CHANGED")]
        IccprofChanged = 0x11,
        [NativeName("Name", "SDL_WINDOWEVENT_DISPLAY_CHANGED")]
        DisplayChanged = 0x12,
    }
}
