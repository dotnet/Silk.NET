// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GamepadButton")]
public enum GamepadButton
{
    [NativeName("SDL_GAMEPAD_BUTTON_INVALID")]
    Invalid = -1,

    [NativeName("SDL_GAMEPAD_BUTTON_SOUTH")]
    South,

    [NativeName("SDL_GAMEPAD_BUTTON_EAST")]
    East,

    [NativeName("SDL_GAMEPAD_BUTTON_WEST")]
    West,

    [NativeName("SDL_GAMEPAD_BUTTON_NORTH")]
    North,

    [NativeName("SDL_GAMEPAD_BUTTON_BACK")]
    Back,

    [NativeName("SDL_GAMEPAD_BUTTON_GUIDE")]
    Guide,

    [NativeName("SDL_GAMEPAD_BUTTON_START")]
    Start,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_STICK")]
    LeftStick,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_STICK")]
    RightStick,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_SHOULDER")]
    LeftShoulder,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER")]
    RightShoulder,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_UP")]
    DpadUp,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_DOWN")]
    DpadDown,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_LEFT")]
    DpadLeft,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_RIGHT")]
    DpadRight,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC1")]
    Misc1,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1")]
    RightPaddle1,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_PADDLE1")]
    LeftPaddle1,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2")]
    RightPaddle2,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_PADDLE2")]
    LeftPaddle2,

    [NativeName("SDL_GAMEPAD_BUTTON_TOUCHPAD")]
    Touchpad,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC2")]
    Misc2,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC3")]
    Misc3,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC4")]
    Misc4,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC5")]
    Misc5,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC6")]
    Misc6,

    [NativeName("SDL_GAMEPAD_BUTTON_COUNT")]
    Count,
}
