// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_GPUPrimitiveType")]
public enum GpuPrimitiveType
{
    [NativeName("SDL_GPU_PRIMITIVETYPE_TRIANGLELIST")]
    Trianglelist = 0,

    [NativeName("SDL_GPU_PRIMITIVETYPE_TRIANGLESTRIP")]
    Trianglestrip = 1,

    [NativeName("SDL_GPU_PRIMITIVETYPE_LINELIST")]
    Linelist = 2,

    [NativeName("SDL_GPU_PRIMITIVETYPE_LINESTRIP")]
    Linestrip = 3,

    [NativeName("SDL_GPU_PRIMITIVETYPE_POINTLIST")]
    Pointlist = 4,
}
