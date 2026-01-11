// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUCompareOp")]
public enum GPUCompareOp
{
    [NativeName("SDL_GPU_COMPAREOP_INVALID")]
    Invalid = 0,

    [NativeName("SDL_GPU_COMPAREOP_NEVER")]
    Never = 1,

    [NativeName("SDL_GPU_COMPAREOP_LESS")]
    Less = 2,

    [NativeName("SDL_GPU_COMPAREOP_EQUAL")]
    Equal = 3,

    [NativeName("SDL_GPU_COMPAREOP_LESS_OR_EQUAL")]
    LessOrEqual = 4,

    [NativeName("SDL_GPU_COMPAREOP_GREATER")]
    Greater = 5,

    [NativeName("SDL_GPU_COMPAREOP_NOT_EQUAL")]
    NotEqual = 6,

    [NativeName("SDL_GPU_COMPAREOP_GREATER_OR_EQUAL")]
    GreaterOrEqual = 7,

    [NativeName("SDL_GPU_COMPAREOP_ALWAYS")]
    Always = 8,
}
