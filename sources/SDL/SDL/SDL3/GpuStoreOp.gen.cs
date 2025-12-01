// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUStoreOp")]
public enum GpuStoreOp : uint
{
    [NativeName("SDL_GPU_STOREOP_STORE")]
    Store,

    [NativeName("SDL_GPU_STOREOP_DONT_CARE")]
    DontCare,

    [NativeName("SDL_GPU_STOREOP_RESOLVE")]
    Resolve,

    [NativeName("SDL_GPU_STOREOP_RESOLVE_AND_STORE")]
    ResolveAndStore,
}
