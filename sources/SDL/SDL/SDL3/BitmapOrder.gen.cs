// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;

namespace Silk.NET.SDL;

[NativeName("SDL_BitmapOrder")]
public enum BitmapOrder : uint
{
    [NativeName("SDL_BITMAPORDER_NONE")]
    BitmaporderNone = 0,

    [NativeName("SDL_BITMAPORDER_4321")]
    Bitmaporder4321 = 1,

    [NativeName("SDL_BITMAPORDER_1234")]
    Bitmaporder1234 = 2,
}
