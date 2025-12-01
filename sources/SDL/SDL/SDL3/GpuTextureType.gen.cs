// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUTextureType")]
public enum GpuTextureType : uint
{
    [NativeName("SDL_GPU_TEXTURETYPE_2D")]
    Texturetype2D,

    [NativeName("SDL_GPU_TEXTURETYPE_2D_ARRAY")]
    Texturetype2DArray,

    [NativeName("SDL_GPU_TEXTURETYPE_3D")]
    Texturetype3D,

    [NativeName("SDL_GPU_TEXTURETYPE_CUBE")]
    TexturetypeCube,

    [NativeName("SDL_GPU_TEXTURETYPE_CUBE_ARRAY")]
    TexturetypeCubeArray,
}
