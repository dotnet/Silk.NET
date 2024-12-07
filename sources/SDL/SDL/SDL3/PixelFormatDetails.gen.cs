// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.SDL;

public partial struct PixelFormatDetails
{
    public PixelFormat Format;

    [NativeTypeName("Uint8")]
    public byte BitsPerPixel;

    [NativeTypeName("Uint8")]
    public byte BytesPerPixel;

    [NativeTypeName("Uint8[2]")]
    public PixelFormatDetailsPadding Padding;

    [NativeTypeName("Uint32")]
    public uint Rmask;

    [NativeTypeName("Uint32")]
    public uint Gmask;

    [NativeTypeName("Uint32")]
    public uint Bmask;

    [NativeTypeName("Uint32")]
    public uint Amask;

    [NativeTypeName("Uint8")]
    public byte Rbits;

    [NativeTypeName("Uint8")]
    public byte Gbits;

    [NativeTypeName("Uint8")]
    public byte Bbits;

    [NativeTypeName("Uint8")]
    public byte Abits;

    [NativeTypeName("Uint8")]
    public byte Rshift;

    [NativeTypeName("Uint8")]
    public byte Gshift;

    [NativeTypeName("Uint8")]
    public byte Bshift;

    [NativeTypeName("Uint8")]
    public byte Ashift;
}
