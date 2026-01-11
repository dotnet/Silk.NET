// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

[NativeName("SDL_PixelFormatDetails")]
public partial struct PixelFormatDetails
{
    [NativeName("format")]
    public PixelFormat Format;

    [NativeName("bits_per_pixel")]
    public byte BitsPerPixel;

    [NativeName("bytes_per_pixel")]
    public byte BytesPerPixel;

    [NativeName("padding")]
    public PixelFormatDetailsPadding Padding;

    [NativeName("Rmask")]
    public uint Rmask;

    [NativeName("Gmask")]
    public uint Gmask;

    [NativeName("Bmask")]
    public uint Bmask;

    [NativeName("Amask")]
    public uint Amask;

    [NativeName("Rbits")]
    public byte Rbits;

    [NativeName("Gbits")]
    public byte Gbits;

    [NativeName("Bbits")]
    public byte Bbits;

    [NativeName("Abits")]
    public byte Abits;

    [NativeName("Rshift")]
    public byte Rshift;

    [NativeName("Gshift")]
    public byte Gshift;

    [NativeName("Bshift")]
    public byte Bshift;

    [NativeName("Ashift")]
    public byte Ashift;
}
