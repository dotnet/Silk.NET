// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_power_L42_C9")]
    [NativeName("Name", "SDL_PowerState")]
    public enum PowerState
    {
        [NativeName("Name", "SDL_POWERSTATE_UNKNOWN")]
        PowerstateUnknown = 0x0,
        [NativeName("Name", "SDL_POWERSTATE_ON_BATTERY")]
        PowerstateOnBattery = 0x1,
        [NativeName("Name", "SDL_POWERSTATE_NO_BATTERY")]
        PowerstateNoBattery = 0x2,
        [NativeName("Name", "SDL_POWERSTATE_CHARGING")]
        PowerstateCharging = 0x3,
        [NativeName("Name", "SDL_POWERSTATE_CHARGED")]
        PowerstateCharged = 0x4,
    }
}
