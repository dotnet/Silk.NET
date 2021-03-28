// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_joystick_L85_C9")]
    [NativeName("Name", "SDL_JoystickType")]
    public enum JoystickType : int
    {
        [NativeName("Name", "SDL_JOYSTICK_TYPE_UNKNOWN")]
        JoystickTypeUnknown = 0x0,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GAMECONTROLLER")]
        JoystickTypeGamecontroller = 0x1,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_WHEEL")]
        JoystickTypeWheel = 0x2,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_STICK")]
        JoystickTypeArcadeStick = 0x3,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_FLIGHT_STICK")]
        JoystickTypeFlightStick = 0x4,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DANCE_PAD")]
        JoystickTypeDancePad = 0x5,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GUITAR")]
        JoystickTypeGuitar = 0x6,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DRUM_KIT")]
        JoystickTypeDrumKit = 0x7,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_PAD")]
        JoystickTypeArcadePad = 0x8,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_THROTTLE")]
        JoystickTypeThrottle = 0x9,
    }
}
