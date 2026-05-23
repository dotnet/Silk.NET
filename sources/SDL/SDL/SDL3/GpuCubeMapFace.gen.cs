// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUCubeMapFace")]
public enum GpuCubeMapFace
{
    [NativeName("SDL_GPU_CUBEMAPFACE_POSITIVEX")]
    Positivex = 0,

    [NativeName("SDL_GPU_CUBEMAPFACE_NEGATIVEX")]
    Negativex = 1,

    [NativeName("SDL_GPU_CUBEMAPFACE_POSITIVEY")]
    Positivey = 2,

    [NativeName("SDL_GPU_CUBEMAPFACE_NEGATIVEY")]
    Negativey = 3,

    [NativeName("SDL_GPU_CUBEMAPFACE_POSITIVEZ")]
    Positivez = 4,

    [NativeName("SDL_GPU_CUBEMAPFACE_NEGATIVEZ")]
    Negativez = 5,
}
