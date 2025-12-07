// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GamepadType")]
public enum GamepadType
{
    [NativeName("SDL_GAMEPAD_TYPE_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_GAMEPAD_TYPE_STANDARD")]
    Standard = 1,

    [NativeName("SDL_GAMEPAD_TYPE_XBOX360")]
    Xbox360 = 2,

    [NativeName("SDL_GAMEPAD_TYPE_XBOXONE")]
    Xboxone = 3,

    [NativeName("SDL_GAMEPAD_TYPE_PS3")]
    Ps3 = 4,

    [NativeName("SDL_GAMEPAD_TYPE_PS4")]
    Ps4 = 5,

    [NativeName("SDL_GAMEPAD_TYPE_PS5")]
    Ps5 = 6,

    [NativeName("SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_PRO")]
    NintendoSwitchPro = 7,

    [NativeName("SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_LEFT")]
    NintendoSwitchJoyconLeft = 8,

    [NativeName("SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT")]
    NintendoSwitchJoyconRight = 9,

    [NativeName("SDL_GAMEPAD_TYPE_NINTENDO_SWITCH_JOYCON_PAIR")]
    NintendoSwitchJoyconPair = 10,

    [NativeName("SDL_GAMEPAD_TYPE_COUNT")]
    Count = 11,
}
