// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_gamecontroller_L620_C9")]
    [NativeName("Name", "SDL_GameControllerAxis")]
    public enum GameControllerAxis : int
    {
        [Obsolete("Deprecated in favour of \"Invalid\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_INVALID")]
        ControllerAxisInvalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Leftx\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTX")]
        ControllerAxisLeftx = 0x0,
        [Obsolete("Deprecated in favour of \"Lefty\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTY")]
        ControllerAxisLefty = 0x1,
        [Obsolete("Deprecated in favour of \"Rightx\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTX")]
        ControllerAxisRightx = 0x2,
        [Obsolete("Deprecated in favour of \"Righty\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTY")]
        ControllerAxisRighty = 0x3,
        [Obsolete("Deprecated in favour of \"Triggerleft\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERLEFT")]
        ControllerAxisTriggerleft = 0x4,
        [Obsolete("Deprecated in favour of \"Triggerright\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERRIGHT")]
        ControllerAxisTriggerright = 0x5,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "SDL_CONTROLLER_AXIS_MAX")]
        ControllerAxisMax = 0x6,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_INVALID")]
        Invalid = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTX")]
        Leftx = 0x0,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_LEFTY")]
        Lefty = 0x1,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTX")]
        Rightx = 0x2,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_RIGHTY")]
        Righty = 0x3,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERLEFT")]
        Triggerleft = 0x4,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_TRIGGERRIGHT")]
        Triggerright = 0x5,
        [NativeName("Name", "SDL_CONTROLLER_AXIS_MAX")]
        Max = 0x6,
    }
}
