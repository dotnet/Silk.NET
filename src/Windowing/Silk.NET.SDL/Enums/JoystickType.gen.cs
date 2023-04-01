// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_joystick_L88_C9")]
    [NativeName("Name", "SDL_JoystickType")]
    public enum JoystickType : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_UNKNOWN")]
        JoystickTypeUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"Gamecontroller\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GAMECONTROLLER")]
        JoystickTypeGamecontroller = 0x1,
        [Obsolete("Deprecated in favour of \"Wheel\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_WHEEL")]
        JoystickTypeWheel = 0x2,
        [Obsolete("Deprecated in favour of \"ArcadeStick\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_STICK")]
        JoystickTypeArcadeStick = 0x3,
        [Obsolete("Deprecated in favour of \"FlightStick\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_FLIGHT_STICK")]
        JoystickTypeFlightStick = 0x4,
        [Obsolete("Deprecated in favour of \"DancePad\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DANCE_PAD")]
        JoystickTypeDancePad = 0x5,
        [Obsolete("Deprecated in favour of \"Guitar\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GUITAR")]
        JoystickTypeGuitar = 0x6,
        [Obsolete("Deprecated in favour of \"DrumKit\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DRUM_KIT")]
        JoystickTypeDrumKit = 0x7,
        [Obsolete("Deprecated in favour of \"ArcadePad\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_PAD")]
        JoystickTypeArcadePad = 0x8,
        [Obsolete("Deprecated in favour of \"Throttle\"")]
        [NativeName("Name", "SDL_JOYSTICK_TYPE_THROTTLE")]
        JoystickTypeThrottle = 0x9,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GAMECONTROLLER")]
        Gamecontroller = 0x1,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_WHEEL")]
        Wheel = 0x2,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_STICK")]
        ArcadeStick = 0x3,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_FLIGHT_STICK")]
        FlightStick = 0x4,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DANCE_PAD")]
        DancePad = 0x5,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_GUITAR")]
        Guitar = 0x6,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_DRUM_KIT")]
        DrumKit = 0x7,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_ARCADE_PAD")]
        ArcadePad = 0x8,
        [NativeName("Name", "SDL_JOYSTICK_TYPE_THROTTLE")]
        Throttle = 0x9,
    }
}
