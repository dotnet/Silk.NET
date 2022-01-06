// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L73_C9")]
    [NativeName("Name", "SDL_GameControllerBindType")]
    public enum GameControllerBindType : int
    {
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_NONE")]
        ControllerBindtypeNone = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_BUTTON")]
        ControllerBindtypeButton = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_AXIS")]
        ControllerBindtypeAxis = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_BINDTYPE_HAT")]
        ControllerBindtypeHat = 0x3,
    }
}
