// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUSampleCount")]
public enum GpuSampleCount
{
    [NativeName("SDL_GPU_SAMPLECOUNT_1")]
    Samplecount1 = 0,

    [NativeName("SDL_GPU_SAMPLECOUNT_2")]
    Samplecount2 = 1,

    [NativeName("SDL_GPU_SAMPLECOUNT_4")]
    Samplecount4 = 2,

    [NativeName("SDL_GPU_SAMPLECOUNT_8")]
    Samplecount8 = 3,
}
