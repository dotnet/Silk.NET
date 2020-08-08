// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L70_C9")]
    [NativeName("Name", "SDL_GameControllerBindType")]
    public enum GameControllerBindType
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
