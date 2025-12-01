// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PenAxis")]
public enum PenAxis : uint
{
    [NativeName("SDL_PEN_AXIS_PRESSURE")]
    Pressure,

    [NativeName("SDL_PEN_AXIS_XTILT")]
    Xtilt,

    [NativeName("SDL_PEN_AXIS_YTILT")]
    Ytilt,

    [NativeName("SDL_PEN_AXIS_DISTANCE")]
    Distance,

    [NativeName("SDL_PEN_AXIS_ROTATION")]
    Rotation,

    [NativeName("SDL_PEN_AXIS_SLIDER")]
    Slider,

    [NativeName("SDL_PEN_AXIS_TANGENTIAL_PRESSURE")]
    TangentialPressure,

    [NativeName("SDL_PEN_AXIS_COUNT")]
    Count,
}
