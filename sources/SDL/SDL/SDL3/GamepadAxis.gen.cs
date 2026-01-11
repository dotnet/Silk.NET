// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GamepadAxis")]
public enum GamepadAxis
{
    [NativeName("SDL_GAMEPAD_AXIS_INVALID")]
    Invalid = -1,

    [NativeName("SDL_GAMEPAD_AXIS_LEFTX")]
    Leftx = 0,

    [NativeName("SDL_GAMEPAD_AXIS_LEFTY")]
    Lefty = 1,

    [NativeName("SDL_GAMEPAD_AXIS_RIGHTX")]
    Rightx = 2,

    [NativeName("SDL_GAMEPAD_AXIS_RIGHTY")]
    Righty = 3,

    [NativeName("SDL_GAMEPAD_AXIS_LEFT_TRIGGER")]
    LeftTrigger = 4,

    [NativeName("SDL_GAMEPAD_AXIS_RIGHT_TRIGGER")]
    RightTrigger = 5,

    [NativeName("SDL_GAMEPAD_AXIS_COUNT")]
    Count = 6,
}
