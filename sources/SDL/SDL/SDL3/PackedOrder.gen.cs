// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PackedOrder")]
public enum PackedOrder
{
    [NativeName("SDL_PACKEDORDER_NONE")]
    None = 0,

    [NativeName("SDL_PACKEDORDER_XRGB")]
    Xrgb = 1,

    [NativeName("SDL_PACKEDORDER_RGBX")]
    Rgbx = 2,

    [NativeName("SDL_PACKEDORDER_ARGB")]
    Argb = 3,

    [NativeName("SDL_PACKEDORDER_RGBA")]
    Rgba = 4,

    [NativeName("SDL_PACKEDORDER_XBGR")]
    Xbgr = 5,

    [NativeName("SDL_PACKEDORDER_BGRX")]
    Bgrx = 6,

    [NativeName("SDL_PACKEDORDER_ABGR")]
    Abgr = 7,

    [NativeName("SDL_PACKEDORDER_BGRA")]
    Bgra = 8,
}
