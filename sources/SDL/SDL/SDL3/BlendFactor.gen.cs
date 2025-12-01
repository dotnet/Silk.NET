// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_BlendFactor")]
public enum BlendFactor : uint
{
    [NativeName("SDL_BLENDFACTOR_ZERO")]
    Zero = 0x1,

    [NativeName("SDL_BLENDFACTOR_ONE")]
    One = 0x2,

    [NativeName("SDL_BLENDFACTOR_SRC_COLOR")]
    SrcColor = 0x3,

    [NativeName("SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = 0x4,

    [NativeName("SDL_BLENDFACTOR_SRC_ALPHA")]
    SrcAlpha = 0x5,

    [NativeName("SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = 0x6,

    [NativeName("SDL_BLENDFACTOR_DST_COLOR")]
    DstColor = 0x7,

    [NativeName("SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = 0x8,

    [NativeName("SDL_BLENDFACTOR_DST_ALPHA")]
    DstAlpha = 0x9,

    [NativeName("SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = 0xA,
}
