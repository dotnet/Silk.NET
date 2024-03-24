// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L80_C9")]
    [NativeName("Name", "SDL_GameControllerBindType")]
    public enum GameControllerBindType : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_NONE")]
        ControllerBindtypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Button\"")]
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_BUTTON")]
        ControllerBindtypeButton = 0x1,
        [Obsolete("Deprecated in favour of \"Axis\"")]
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_AXIS")]
        ControllerBindtypeAxis = 0x2,
        [Obsolete("Deprecated in favour of \"Hat\"")]
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_HAT")]
        ControllerBindtypeHat = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_BUTTON")]
        Button = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_AXIS")]
        Axis = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_HAT")]
        Hat = 0x3,
    }
}
