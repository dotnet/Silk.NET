// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUIndexElementSize")]
public enum GpuIndexElementSize : uint
{
    [NativeName("SDL_GPU_INDEXELEMENTSIZE_16BIT")]
    Indexelementsize16Bit,

    [NativeName("SDL_GPU_INDEXELEMENTSIZE_32BIT")]
    Indexelementsize32Bit,
}
