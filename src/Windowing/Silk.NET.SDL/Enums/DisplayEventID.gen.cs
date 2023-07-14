// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L185_C9")]
    [NativeName("Name", "SDL_DisplayEventID")]
    public enum DisplayEventID : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_DISPLAYEVENT_NONE")]
        DisplayeventNone = 0x0,
        [Obsolete("Deprecated in favour of \"Orientation\"")]
        [NativeName("Name", "SDL_DISPLAYEVENT_ORIENTATION")]
        DisplayeventOrientation = 0x1,
        [Obsolete("Deprecated in favour of \"Connected\"")]
        [NativeName("Name", "SDL_DISPLAYEVENT_CONNECTED")]
        DisplayeventConnected = 0x2,
        [Obsolete("Deprecated in favour of \"Disconnected\"")]
        [NativeName("Name", "SDL_DISPLAYEVENT_DISCONNECTED")]
        DisplayeventDisconnected = 0x3,
        [Obsolete("Deprecated in favour of \"Moved\"")]
        [NativeName("Name", "SDL_DISPLAYEVENT_MOVED")]
        DisplayeventMoved = 0x4,
        [NativeName("Name", "SDL_DISPLAYEVENT_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_DISPLAYEVENT_ORIENTATION")]
        Orientation = 0x1,
        [NativeName("Name", "SDL_DISPLAYEVENT_CONNECTED")]
        Connected = 0x2,
        [NativeName("Name", "SDL_DISPLAYEVENT_DISCONNECTED")]
        Disconnected = 0x3,
        [NativeName("Name", "SDL_DISPLAYEVENT_MOVED")]
        Moved = 0x4,
    }
}
