// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L182_C9")]
    [NativeName("Name", "SDL_DisplayEventID")]
    public enum DisplayEventID : int
    {
        [NativeName("Name", "SDL_DISPLAYEVENT_NONE")]
        DisplayeventNone = 0x0,
        [NativeName("Name", "SDL_DISPLAYEVENT_ORIENTATION")]
        DisplayeventOrientation = 0x1,
        [NativeName("Name", "SDL_DISPLAYEVENT_CONNECTED")]
        DisplayeventConnected = 0x2,
        [NativeName("Name", "SDL_DISPLAYEVENT_DISCONNECTED")]
        DisplayeventDisconnected = 0x3,
    }
}
