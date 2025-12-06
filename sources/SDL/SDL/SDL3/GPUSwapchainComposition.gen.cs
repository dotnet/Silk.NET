// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUSwapchainComposition")]
public enum GPUSwapchainComposition : uint
{
    [NativeName("SDL_GPU_SWAPCHAINCOMPOSITION_SDR")]
    Sdr = 0,

    [NativeName("SDL_GPU_SWAPCHAINCOMPOSITION_SDR_LINEAR")]
    SdrLinear = 1,

    [NativeName("SDL_GPU_SWAPCHAINCOMPOSITION_HDR_EXTENDED_LINEAR")]
    HdrExtendedLinear = 2,

    [NativeName("SDL_GPU_SWAPCHAINCOMPOSITION_HDR10_ST2084")]
    Hdr10St2084 = 3,
}
