// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUFilter")]
public enum GPUFilter : uint
{
    [NativeName("SDL_GPU_FILTER_NEAREST")]
    Nearest = 0,

    [NativeName("SDL_GPU_FILTER_LINEAR")]
    Linear = 1,
}
