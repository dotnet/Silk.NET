// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L145_C9")]
    [NativeName("Name", "SDL_WindowEventID")]
    public enum WindowEventID
    {
        [NativeName("Name", "SDL_WINDOWEVENT_NONE")]
        WindoweventNone = 0x0,
        [NativeName("Name", "SDL_WINDOWEVENT_SHOWN")]
        WindoweventShown = 0x1,
        [NativeName("Name", "SDL_WINDOWEVENT_HIDDEN")]
        WindoweventHidden = 0x2,
        [NativeName("Name", "SDL_WINDOWEVENT_EXPOSED")]
        WindoweventExposed = 0x3,
        [NativeName("Name", "SDL_WINDOWEVENT_MOVED")]
        WindoweventMoved = 0x4,
        [NativeName("Name", "SDL_WINDOWEVENT_RESIZED")]
        WindoweventResized = 0x5,
        [NativeName("Name", "SDL_WINDOWEVENT_SIZE_CHANGED")]
        WindoweventSizeChanged = 0x6,
        [NativeName("Name", "SDL_WINDOWEVENT_MINIMIZED")]
        WindoweventMinimized = 0x7,
        [NativeName("Name", "SDL_WINDOWEVENT_MAXIMIZED")]
        WindoweventMaximized = 0x8,
        [NativeName("Name", "SDL_WINDOWEVENT_RESTORED")]
        WindoweventRestored = 0x9,
        [NativeName("Name", "SDL_WINDOWEVENT_ENTER")]
        WindoweventEnter = 0xA,
        [NativeName("Name", "SDL_WINDOWEVENT_LEAVE")]
        WindoweventLeave = 0xB,
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_GAINED")]
        WindoweventFocusGained = 0xC,
        [NativeName("Name", "SDL_WINDOWEVENT_FOCUS_LOST")]
        WindoweventFocusLost = 0xD,
        [NativeName("Name", "SDL_WINDOWEVENT_CLOSE")]
        WindoweventClose = 0xE,
        [NativeName("Name", "SDL_WINDOWEVENT_TAKE_FOCUS")]
        WindoweventTakeFocus = 0xF,
        [NativeName("Name", "SDL_WINDOWEVENT_HIT_TEST")]
        WindoweventHitTest = 0x10,
    }
}
