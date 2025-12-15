// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_power_L42_C9")]
    [NativeName("Name", "SDL_PowerState")]
    public enum PowerState : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_POWERSTATE_UNKNOWN")]
        PowerstateUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"OnBattery\"")]
        [NativeName("Name", "SDL_POWERSTATE_ON_BATTERY")]
        PowerstateOnBattery = 0x1,
        [Obsolete("Deprecated in favour of \"NoBattery\"")]
        [NativeName("Name", "SDL_POWERSTATE_NO_BATTERY")]
        PowerstateNoBattery = 0x2,
        [Obsolete("Deprecated in favour of \"Charging\"")]
        [NativeName("Name", "SDL_POWERSTATE_CHARGING")]
        PowerstateCharging = 0x3,
        [Obsolete("Deprecated in favour of \"Charged\"")]
        [NativeName("Name", "SDL_POWERSTATE_CHARGED")]
        PowerstateCharged = 0x4,
        [NativeName("Name", "SDL_POWERSTATE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_POWERSTATE_ON_BATTERY")]
        OnBattery = 0x1,
        [NativeName("Name", "SDL_POWERSTATE_NO_BATTERY")]
        NoBattery = 0x2,
        [NativeName("Name", "SDL_POWERSTATE_CHARGING")]
        Charging = 0x3,
        [NativeName("Name", "SDL_POWERSTATE_CHARGED")]
        Charged = 0x4,
    }
}
