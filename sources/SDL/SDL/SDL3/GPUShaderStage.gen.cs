// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUShaderStage")]
public enum GPUShaderStage : uint
{
    [NativeName("SDL_GPU_SHADERSTAGE_VERTEX")]
    Vertex = 0,

    [NativeName("SDL_GPU_SHADERSTAGE_FRAGMENT")]
    Fragment = 1,
}
