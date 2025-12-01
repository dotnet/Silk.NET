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
    Unknown,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_A")]
    A,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_B")]
    B,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_X")]
    X,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_Y")]
    Y,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_CROSS")]
    Cross,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_CIRCLE")]
    Circle,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_SQUARE")]
    Square,

    [NativeName("SDL_GAMEPAD_BUTTON_LABEL_TRIANGLE")]
    Triangle,
}
