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
    South = 0,

    [NativeName("SDL_GAMEPAD_BUTTON_EAST")]
    East = 1,

    [NativeName("SDL_GAMEPAD_BUTTON_WEST")]
    West = 2,

    [NativeName("SDL_GAMEPAD_BUTTON_NORTH")]
    North = 3,

    [NativeName("SDL_GAMEPAD_BUTTON_BACK")]
    Back = 4,

    [NativeName("SDL_GAMEPAD_BUTTON_GUIDE")]
    Guide = 5,

    [NativeName("SDL_GAMEPAD_BUTTON_START")]
    Start = 6,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_STICK")]
    LeftStick = 7,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_STICK")]
    RightStick = 8,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_SHOULDER")]
    LeftShoulder = 9,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_SHOULDER")]
    RightShoulder = 10,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_UP")]
    DpadUp = 11,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_DOWN")]
    DpadDown = 12,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_LEFT")]
    DpadLeft = 13,

    [NativeName("SDL_GAMEPAD_BUTTON_DPAD_RIGHT")]
    DpadRight = 14,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC1")]
    Misc1 = 15,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_PADDLE1")]
    RightPaddle1 = 16,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_PADDLE1")]
    LeftPaddle1 = 17,

    [NativeName("SDL_GAMEPAD_BUTTON_RIGHT_PADDLE2")]
    RightPaddle2 = 18,

    [NativeName("SDL_GAMEPAD_BUTTON_LEFT_PADDLE2")]
    LeftPaddle2 = 19,

    [NativeName("SDL_GAMEPAD_BUTTON_TOUCHPAD")]
    Touchpad = 20,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC2")]
    Misc2 = 21,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC3")]
    Misc3 = 22,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC4")]
    Misc4 = 23,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC5")]
    Misc5 = 24,

    [NativeName("SDL_GAMEPAD_BUTTON_MISC6")]
    Misc6 = 25,

    [NativeName("SDL_GAMEPAD_BUTTON_COUNT")]
    Count = 26,
}
