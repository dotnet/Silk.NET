// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

public unsafe partial struct PixelFormat
{
    public PixelFormatEnum Format;
    public Palette* Palette;

    [NativeTypeName("Uint8")]
    public byte BitsPerPixel;

    [NativeTypeName("Uint8")]
    public byte BytesPerPixel;

    [NativeTypeName("Uint8[2]")]
    public _padding_e__FixedBuffer Padding;

    [NativeTypeName("Uint32")]
    public uint Rmask;

    [NativeTypeName("Uint32")]
    public uint Gmask;

    [NativeTypeName("Uint32")]
    public uint Bmask;

    [NativeTypeName("Uint32")]
    public uint Amask;

    [NativeTypeName("Uint8")]
    public byte Rloss;

    [NativeTypeName("Uint8")]
    public byte Gloss;

    [NativeTypeName("Uint8")]
    public byte Bloss;

    [NativeTypeName("Uint8")]
    public byte Aloss;

    [NativeTypeName("Uint8")]
    public byte Rshift;

    [NativeTypeName("Uint8")]
    public byte Gshift;

    [NativeTypeName("Uint8")]
    public byte Bshift;

    [NativeTypeName("Uint8")]
    public byte Ashift;
    public int Refcount;

    [NativeTypeName("struct SDL_PixelFormat *")]
    public PixelFormat* Next;

    [InlineArray(2)]
    public partial struct _padding_e__FixedBuffer
    {
        public byte e0;
    }
}
