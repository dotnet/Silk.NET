// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public unsafe partial struct Surface
{
    [NativeTypeName("SDL_SurfaceFlags")]
    public uint Flags;
    public PixelFormat Format;
    public int W;
    public int H;
    public int Pitch;
    public void* Pixels;
    public int Refcount;
    public void* Reserved;
}
