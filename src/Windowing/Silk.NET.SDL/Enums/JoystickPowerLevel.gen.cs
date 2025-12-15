// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_joystick_L102_C9")]
    [NativeName("Name", "SDL_JoystickPowerLevel")]
    public enum JoystickPowerLevel : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_UNKNOWN")]
        JoystickPowerUnknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"Empty\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_EMPTY")]
        JoystickPowerEmpty = 0x0,
        [Obsolete("Deprecated in favour of \"Low\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_LOW")]
        JoystickPowerLow = 0x1,
        [Obsolete("Deprecated in favour of \"Medium\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_MEDIUM")]
        JoystickPowerMedium = 0x2,
        [Obsolete("Deprecated in favour of \"Full\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_FULL")]
        JoystickPowerFull = 0x3,
        [Obsolete("Deprecated in favour of \"Wired\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_WIRED")]
        JoystickPowerWired = 0x4,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "SDL_JOYSTICK_POWER_MAX")]
        JoystickPowerMax = 0x5,
        [NativeName("Name", "SDL_JOYSTICK_POWER_UNKNOWN")]
        Unknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_JOYSTICK_POWER_EMPTY")]
        Empty = 0x0,
        [NativeName("Name", "SDL_JOYSTICK_POWER_LOW")]
        Low = 0x1,
        [NativeName("Name", "SDL_JOYSTICK_POWER_MEDIUM")]
        Medium = 0x2,
        [NativeName("Name", "SDL_JOYSTICK_POWER_FULL")]
        Full = 0x3,
        [NativeName("Name", "SDL_JOYSTICK_POWER_WIRED")]
        Wired = 0x4,
        [NativeName("Name", "SDL_JOYSTICK_POWER_MAX")]
        Max = 0x5,
    }
}
