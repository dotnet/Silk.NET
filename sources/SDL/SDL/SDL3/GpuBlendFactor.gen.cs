// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBlendFactor")]
public enum GpuBlendFactor : uint
{
    [NativeName("SDL_GPU_BLENDFACTOR_INVALID")]
    Invalid,

    [NativeName("SDL_GPU_BLENDFACTOR_ZERO")]
    Zero,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE")]
    One,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_COLOR")]
    SrcColor,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_COLOR")]
    OneMinusSrcColor,

    [NativeName("SDL_GPU_BLENDFACTOR_DST_COLOR")]
    DstColor,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_COLOR")]
    OneMinusDstColor,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_ALPHA")]
    SrcAlpha,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_SRC_ALPHA")]
    OneMinusSrcAlpha,

    [NativeName("SDL_GPU_BLENDFACTOR_DST_ALPHA")]
    DstAlpha,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_DST_ALPHA")]
    OneMinusDstAlpha,

    [NativeName("SDL_GPU_BLENDFACTOR_CONSTANT_COLOR")]
    ConstantColor,

    [NativeName("SDL_GPU_BLENDFACTOR_ONE_MINUS_CONSTANT_COLOR")]
    OneMinusConstantColor,

    [NativeName("SDL_GPU_BLENDFACTOR_SRC_ALPHA_SATURATE")]
    SrcAlphaSaturate,
}
