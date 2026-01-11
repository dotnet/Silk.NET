// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUPresentMode")]
public enum GpuPresentMode
{
    [NativeName("SDL_GPU_PRESENTMODE_VSYNC")]
    Vsync = 0,

    [NativeName("SDL_GPU_PRESENTMODE_IMMEDIATE")]
    Immediate = 1,

    [NativeName("SDL_GPU_PRESENTMODE_MAILBOX")]
    Mailbox = 2,
}
