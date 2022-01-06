// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_power_L42_C9")]
    [NativeName("Name", "SDL_PowerState")]
    public enum PowerState : int
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
