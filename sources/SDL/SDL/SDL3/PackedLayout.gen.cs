// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PackedLayout")]
public enum PackedLayout : uint
{
    [NativeName("SDL_PACKEDLAYOUT_NONE")]
    PackedlayoutNone,

    [NativeName("SDL_PACKEDLAYOUT_332")]
    Packedlayout332,

    [NativeName("SDL_PACKEDLAYOUT_4444")]
    Packedlayout4444,

    [NativeName("SDL_PACKEDLAYOUT_1555")]
    Packedlayout1555,

    [NativeName("SDL_PACKEDLAYOUT_5551")]
    Packedlayout5551,

    [NativeName("SDL_PACKEDLAYOUT_565")]
    Packedlayout565,

    [NativeName("SDL_PACKEDLAYOUT_8888")]
    Packedlayout8888,

    [NativeName("SDL_PACKEDLAYOUT_2101010")]
    Packedlayout2101010,

    [NativeName("SDL_PACKEDLAYOUT_1010102")]
    Packedlayout1010102,
}
