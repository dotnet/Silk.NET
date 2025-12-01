// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUStencilOp")]
public enum GpuStencilOp : uint
{
    [NativeName("SDL_GPU_STENCILOP_INVALID")]
    Invalid,

    [NativeName("SDL_GPU_STENCILOP_KEEP")]
    Keep,

    [NativeName("SDL_GPU_STENCILOP_ZERO")]
    Zero,

    [NativeName("SDL_GPU_STENCILOP_REPLACE")]
    Replace,

    [NativeName("SDL_GPU_STENCILOP_INCREMENT_AND_CLAMP")]
    IncrementAndClamp,

    [NativeName("SDL_GPU_STENCILOP_DECREMENT_AND_CLAMP")]
    DecrementAndClamp,

    [NativeName("SDL_GPU_STENCILOP_INVERT")]
    Invert,

    [NativeName("SDL_GPU_STENCILOP_INCREMENT_AND_WRAP")]
    IncrementAndWrap,

    [NativeName("SDL_GPU_STENCILOP_DECREMENT_AND_WRAP")]
    DecrementAndWrap,
}
