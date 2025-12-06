// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PixelType")]
public enum PixelType
{
    [NativeName("SDL_PIXELTYPE_UNKNOWN")]
    Unknown = 0,

    [NativeName("SDL_PIXELTYPE_INDEX1")]
    Index1 = 1,

    [NativeName("SDL_PIXELTYPE_INDEX4")]
    Index4 = 2,

    [NativeName("SDL_PIXELTYPE_INDEX8")]
    Index8 = 3,

    [NativeName("SDL_PIXELTYPE_PACKED8")]
    Packed8 = 4,

    [NativeName("SDL_PIXELTYPE_PACKED16")]
    Packed16 = 5,

    [NativeName("SDL_PIXELTYPE_PACKED32")]
    Packed32 = 6,

    [NativeName("SDL_PIXELTYPE_ARRAYU8")]
    Arrayu8 = 7,

    [NativeName("SDL_PIXELTYPE_ARRAYU16")]
    Arrayu16 = 8,

    [NativeName("SDL_PIXELTYPE_ARRAYU32")]
    Arrayu32 = 9,

    [NativeName("SDL_PIXELTYPE_ARRAYF16")]
    Arrayf16 = 10,

    [NativeName("SDL_PIXELTYPE_ARRAYF32")]
    Arrayf32 = 11,

    [NativeName("SDL_PIXELTYPE_INDEX2")]
    Index2 = 12,
}
