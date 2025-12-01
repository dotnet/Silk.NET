// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

[NativeName("SDL_ArrayOrder")]
public enum ArrayOrder : uint
{
    [NativeName("SDL_ARRAYORDER_NONE")]
    None,

    [NativeName("SDL_ARRAYORDER_RGB")]
    Rgb,

    [NativeName("SDL_ARRAYORDER_RGBA")]
    Rgba,

    [NativeName("SDL_ARRAYORDER_ARGB")]
    Argb,

    [NativeName("SDL_ARRAYORDER_BGR")]
    Bgr,

    [NativeName("SDL_ARRAYORDER_BGRA")]
    Bgra,

    [NativeName("SDL_ARRAYORDER_ABGR")]
    Abgr,
}
