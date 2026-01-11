// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUBlendOp")]
public enum GPUBlendOp : uint
{
    [NativeName("SDL_GPU_BLENDOP_INVALID")]
    Invalid = 0,

    [NativeName("SDL_GPU_BLENDOP_ADD")]
    Add = 1,

    [NativeName("SDL_GPU_BLENDOP_SUBTRACT")]
    Subtract = 2,

    [NativeName("SDL_GPU_BLENDOP_REVERSE_SUBTRACT")]
    ReverseSubtract = 3,

    [NativeName("SDL_GPU_BLENDOP_MIN")]
    Min = 4,

    [NativeName("SDL_GPU_BLENDOP_MAX")]
    Max = 5,
}
