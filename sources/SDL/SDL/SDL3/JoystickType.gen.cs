// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_JoystickType")]
public enum JoystickType : uint
{
    [NativeName("SDL_JOYSTICK_TYPE_UNKNOWN")]
    Unknown,

    [NativeName("SDL_JOYSTICK_TYPE_GAMEPAD")]
    Gamepad,

    [NativeName("SDL_JOYSTICK_TYPE_WHEEL")]
    Wheel,

    [NativeName("SDL_JOYSTICK_TYPE_ARCADE_STICK")]
    ArcadeStick,

    [NativeName("SDL_JOYSTICK_TYPE_FLIGHT_STICK")]
    FlightStick,

    [NativeName("SDL_JOYSTICK_TYPE_DANCE_PAD")]
    DancePad,

    [NativeName("SDL_JOYSTICK_TYPE_GUITAR")]
    Guitar,

    [NativeName("SDL_JOYSTICK_TYPE_DRUM_KIT")]
    DrumKit,

    [NativeName("SDL_JOYSTICK_TYPE_ARCADE_PAD")]
    ArcadePad,

    [NativeName("SDL_JOYSTICK_TYPE_THROTTLE")]
    Throttle,

    [NativeName("SDL_JOYSTICK_TYPE_COUNT")]
    Count,
}
