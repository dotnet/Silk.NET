// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUCompareOp")]
public enum GpuCompareOp : uint
{
    [NativeName("SDL_GPU_COMPAREOP_INVALID")]
    Invalid,

    [NativeName("SDL_GPU_COMPAREOP_NEVER")]
    Never,

    [NativeName("SDL_GPU_COMPAREOP_LESS")]
    Less,

    [NativeName("SDL_GPU_COMPAREOP_EQUAL")]
    Equal,

    [NativeName("SDL_GPU_COMPAREOP_LESS_OR_EQUAL")]
    LessOrEqual,

    [NativeName("SDL_GPU_COMPAREOP_GREATER")]
    Greater,

    [NativeName("SDL_GPU_COMPAREOP_NOT_EQUAL")]
    NotEqual,

    [NativeName("SDL_GPU_COMPAREOP_GREATER_OR_EQUAL")]
    GreaterOrEqual,

    [NativeName("SDL_GPU_COMPAREOP_ALWAYS")]
    Always,
}
