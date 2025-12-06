// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GamepadButtonLabel")]
public enum GamepadButtonLabel : uint
{
    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_A")]
    A = 1,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_B")]
    B = 2,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_X")]
    X = 3,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_Y")]
    Y = 4,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_CROSS")]
    Cross = 5,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_CIRCLE")]
    Circle = 6,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_SQUARE")]
    Square = 7,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE")]
    Triangle = 8,
}
