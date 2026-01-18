// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_Surface")]
public unsafe partial struct Surface
{
    [NativeName("flags")]
    public uint Flags;

    [NativeName("format")]
    public PixelFormat Format;

    [NativeName("w")]
    public int W;

    [NativeName("h")]
    public int H;

    [NativeName("pitch")]
    public int Pitch;

    [NativeName("pixels")]
    public void* Pixels;

    [NativeName("refcount")]
    public int Refcount;

    [NativeName("reserved")]
    public void* Reserved;
}
