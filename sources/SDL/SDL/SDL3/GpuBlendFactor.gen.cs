// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBlendFactor")]
public enum GpuBlendFactor
{
    [NativeName("SDL_GPU_BLENDFACTOR_INVALID")]
    Invalid = 0,

    [NativeName("SDL_GPU_BLENDFACTOR_ZERO")]
    Zero = 1,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE")]
    One = 2,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_COLOR")]
    SrcColor = 3,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor = 4,

    [NativeName("SDL_GPU_BLENDFACTOR_DST_COLOR")]
    DstColor = 5,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor = 6,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_ALPHA")]
    SrcAlpha = 7,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha = 8,

    [NativeName("SDL_GPU_BLENDFACTOR_DST_ALPHA")]
    DstAlpha = 9,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha = 10,

    [NativeName("SDL_GPU_BLENDFACTOR_CONSTANT_COLOR")]
    ConstantColor = 11,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor = 12,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate = 13,
}
