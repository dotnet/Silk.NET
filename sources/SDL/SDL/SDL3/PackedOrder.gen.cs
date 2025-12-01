// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PackedOrder")]
public enum PackedOrder : uint
{
    [NativeName("SDL_PACKEDORDER_NONE")]
    None,

    [NativeName("SDL_PACKEDORDER_XRGB")]
    Xrgb,

    [NativeName("SDL_PACKEDORDER_RGBX")]
    Rgbx,

    [NativeName("SDL_PACKEDORDER_ARGB")]
    Argb,

    [NativeName("SDL_PACKEDORDER_RGBA")]
    Rgba,

    [NativeName("SDL_PACKEDORDER_XBGR")]
    Xbgr,

    [NativeName("SDL_PACKEDORDER_BGRX")]
    Bgrx,

    [NativeName("SDL_PACKEDORDER_ABGR")]
    Abgr,

    [NativeName("SDL_PACKEDORDER_BGRA")]
    Bgra,
}
