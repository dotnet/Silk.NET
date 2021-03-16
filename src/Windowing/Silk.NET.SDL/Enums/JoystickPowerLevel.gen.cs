// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_joystick_L97_C9")]
    [NativeName("Name", "SDL_JoystickPowerLevel")]
    public enum JoystickPowerLevel : int
    {
        [NativeName("Name", "SDL_JOYSTICK_POWER_UNKNOWN")]
        JoystickPowerUnknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "SDL_JOYSTICK_POWER_EMPTY")]
        JoystickPowerEmpty = 0x0,
        [NativeName("Name", "SDL_JOYSTICK_POWER_LOW")]
        JoystickPowerLow = 0x1,
        [NativeName("Name", "SDL_JOYSTICK_POWER_MEDIUM")]
        JoystickPowerMedium = 0x2,
        [NativeName("Name", "SDL_JOYSTICK_POWER_FULL")]
        JoystickPowerFull = 0x3,
        [NativeName("Name", "SDL_JOYSTICK_POWER_WIRED")]
        JoystickPowerWired = 0x4,
        [NativeName("Name", "SDL_JOYSTICK_POWER_MAX")]
        JoystickPowerMax = 0x5,
    }
}
