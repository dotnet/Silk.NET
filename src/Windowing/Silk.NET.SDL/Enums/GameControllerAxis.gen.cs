// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L302_C9")]
    [NativeName("Name", "SDL_GameControllerAxis")]
    public enum GameControllerAxis : int
    {
        [NativeName("Name", "SDL_CONTROLLER_AXIS_INVALID")]
        ControllerAxisInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTX")]
        ControllerAxisLeftx = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTY")]
        ControllerAxisLefty = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTX")]
        ControllerAxisRightx = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTY")]
        ControllerAxisRighty = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERLEFT")]
        ControllerAxisTriggerleft = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERRIGHT")]
        ControllerAxisTriggerright = 0x5,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_MAX")]
        ControllerAxisMax = 0x6,
    }
}
