// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_ColorPrimaries")]
public enum ColorPrimaries : uint
{
    [NativeName("SDL_COLOR_PRIMARIES_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_COLOR_PRIMARIES_BT709")]
    Bt709 = 1,

    [NativeName("SDL_COLOR_PRIMARIES_UNSPECIFIED")]
    Unspecified = 2,

    [NativeName("SDL_COLOR_PRIMARIES_BT470M")]
    BT470M = 4,

    [NativeName("SDL_COLOR_PRIMARIES_BT470BG")]
    Bt470Bg = 5,

    [NativeName("SDL_COLOR_PRIMARIES_BT601")]
    Bt601 = 6,

    [NativeName("SDL_COLOR_PRIMARIES_SMPTE240")]
    Smpte240 = 7,

    [NativeName("SDL_COLOR_PRIMARIES_GENERIC_FILM")]
    GenericFilm = 8,

    [NativeName("SDL_COLOR_PRIMARIES_BT2020")]
    Bt2020 = 9,

    [NativeName("SDL_COLOR_PRIMARIES_XYZ")]
    Xyz = 10,

    [NativeName("SDL_COLOR_PRIMARIES_SMPTE431")]
    Smpte431 = 11,

    [NativeName("SDL_COLOR_PRIMARIES_SMPTE432")]
    Smpte432 = 12,

    [NativeName("SDL_COLOR_PRIMARIES_EBU3213")]
    Ebu3213 = 22,

    [NativeName("SDL_COLOR_PRIMARIES_CUSTOM")]
    Custom = 31,
}
