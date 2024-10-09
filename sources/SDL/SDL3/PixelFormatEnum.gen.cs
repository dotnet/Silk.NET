// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.SDL.ArrayOrder;
using static Silk.NET.SDL.BitmapOrder;
using static Silk.NET.SDL.ChromaLocation;
using static Silk.NET.SDL.ColorPrimaries;
using static Silk.NET.SDL.ColorRange;
using static Silk.NET.SDL.ColorType;
using static Silk.NET.SDL.MatrixCoefficients;
using static Silk.NET.SDL.PackedLayout;
using static Silk.NET.SDL.PackedOrder;
using static Silk.NET.SDL.PenAxis;
using static Silk.NET.SDL.PixelType;
using static Silk.NET.SDL.Scancode;
using static Silk.NET.SDL.TransferCharacteristics;

namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum PixelFormatEnum : uint
{
    Unknown,
    Index1Lsb =
        (
            (1 << 28)
            | ((PixelType.Index1) << 24)
            | ((BitmapOrder.Bitmaporder4321) << 20)
            | ((0) << 16)
            | ((1) << 8)
            | ((0) << 0)
        ),
    Index1Msb =
        (
            (1 << 28)
            | ((PixelType.Index1) << 24)
            | ((BitmapOrder.Bitmaporder1234) << 20)
            | ((0) << 16)
            | ((1) << 8)
            | ((0) << 0)
        ),
    Index2Lsb =
        (
            (1 << 28)
            | ((PixelType.Index2) << 24)
            | ((BitmapOrder.Bitmaporder4321) << 20)
            | ((0) << 16)
            | ((2) << 8)
            | ((0) << 0)
        ),
    Index2Msb =
        (
            (1 << 28)
            | ((PixelType.Index2) << 24)
            | ((BitmapOrder.Bitmaporder1234) << 20)
            | ((0) << 16)
            | ((2) << 8)
            | ((0) << 0)
        ),
    Index4Lsb =
        (
            (1 << 28)
            | ((PixelType.Index4) << 24)
            | ((BitmapOrder.Bitmaporder4321) << 20)
            | ((0) << 16)
            | ((4) << 8)
            | ((0) << 0)
        ),
    Index4Msb =
        (
            (1 << 28)
            | ((PixelType.Index4) << 24)
            | ((BitmapOrder.Bitmaporder1234) << 20)
            | ((0) << 16)
            | ((4) << 8)
            | ((0) << 0)
        ),
    Index8 =
        (
            (1 << 28)
            | ((PixelType.Index8) << 24)
            | ((0) << 20)
            | ((0) << 16)
            | ((8) << 8)
            | ((1) << 0)
        ),
    Rgb332 =
        (
            (1 << 28)
            | ((PixelType.Packed8) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout332) << 16)
            | ((8) << 8)
            | ((1) << 0)
        ),
    Xrgb4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((12) << 8)
            | ((2) << 0)
        ),
    Rgb444 = Xrgb4444,
    Xbgr4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xbgr) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((12) << 8)
            | ((2) << 0)
        ),
    Bgr444 = Xbgr4444,
    Xrgb1555 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout1555) << 16)
            | ((15) << 8)
            | ((2) << 0)
        ),
    Rgb555 = Xrgb1555,
    Xbgr1555 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xbgr) << 20)
            | ((PackedLayout.Packedlayout1555) << 16)
            | ((15) << 8)
            | ((2) << 0)
        ),
    Bgr555 = Xbgr1555,
    Argb4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Argb) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Rgba4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Rgba) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Abgr4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Abgr) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Bgra4444 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Bgra) << 20)
            | ((PackedLayout.Packedlayout4444) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Argb1555 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Argb) << 20)
            | ((PackedLayout.Packedlayout1555) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Rgba5551 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Rgba) << 20)
            | ((PackedLayout.Packedlayout5551) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Abgr1555 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Abgr) << 20)
            | ((PackedLayout.Packedlayout1555) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Bgra5551 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Bgra) << 20)
            | ((PackedLayout.Packedlayout5551) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Rgb565 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout565) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Bgr565 =
        (
            (1 << 28)
            | ((PixelType.Packed16) << 24)
            | ((PackedOrder.Xbgr) << 20)
            | ((PackedLayout.Packedlayout565) << 16)
            | ((16) << 8)
            | ((2) << 0)
        ),
    Rgb24 =
        (
            (1 << 28)
            | ((PixelType.Arrayu8) << 24)
            | ((ArrayOrder.Rgb) << 20)
            | ((0) << 16)
            | ((24) << 8)
            | ((3) << 0)
        ),
    Bgr24 =
        (
            (1 << 28)
            | ((PixelType.Arrayu8) << 24)
            | ((ArrayOrder.Bgr) << 20)
            | ((0) << 16)
            | ((24) << 8)
            | ((3) << 0)
        ),
    Xrgb8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((24) << 8)
            | ((4) << 0)
        ),
    Rgbx8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Rgbx) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((24) << 8)
            | ((4) << 0)
        ),
    Xbgr8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Xbgr) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((24) << 8)
            | ((4) << 0)
        ),
    Bgrx8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Bgrx) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((24) << 8)
            | ((4) << 0)
        ),
    Argb8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Argb) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Rgba8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Rgba) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Abgr8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Abgr) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Bgra8888 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Bgra) << 20)
            | ((PackedLayout.Packedlayout8888) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Xrgb2101010 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Xrgb) << 20)
            | ((PackedLayout.Packedlayout2101010) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Xbgr2101010 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Xbgr) << 20)
            | ((PackedLayout.Packedlayout2101010) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Argb2101010 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Argb) << 20)
            | ((PackedLayout.Packedlayout2101010) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Abgr2101010 =
        (
            (1 << 28)
            | ((PixelType.Packed32) << 24)
            | ((PackedOrder.Abgr) << 20)
            | ((PackedLayout.Packedlayout2101010) << 16)
            | ((32) << 8)
            | ((4) << 0)
        ),
    Rgb48 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Rgb) << 20)
            | ((0) << 16)
            | ((48) << 8)
            | ((6) << 0)
        ),
    Bgr48 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Bgr) << 20)
            | ((0) << 16)
            | ((48) << 8)
            | ((6) << 0)
        ),
    Rgba64 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Rgba) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Argb64 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Argb) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Bgra64 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Bgra) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Abgr64 =
        (
            (1 << 28)
            | ((PixelType.Arrayu16) << 24)
            | ((ArrayOrder.Abgr) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Rgb48Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Rgb) << 20)
            | ((0) << 16)
            | ((48) << 8)
            | ((6) << 0)
        ),
    Bgr48Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Bgr) << 20)
            | ((0) << 16)
            | ((48) << 8)
            | ((6) << 0)
        ),
    Rgba64Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Rgba) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Argb64Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Argb) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Bgra64Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Bgra) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Abgr64Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf16) << 24)
            | ((ArrayOrder.Abgr) << 20)
            | ((0) << 16)
            | ((64) << 8)
            | ((8) << 0)
        ),
    Rgb96Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Rgb) << 20)
            | ((0) << 16)
            | ((96) << 8)
            | ((12) << 0)
        ),
    Bgr96Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Bgr) << 20)
            | ((0) << 16)
            | ((96) << 8)
            | ((12) << 0)
        ),
    Rgba128Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Rgba) << 20)
            | ((0) << 16)
            | ((128) << 8)
            | ((16) << 0)
        ),
    Argb128Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Argb) << 20)
            | ((0) << 16)
            | ((128) << 8)
            | ((16) << 0)
        ),
    Bgra128Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Bgra) << 20)
            | ((0) << 16)
            | ((128) << 8)
            | ((16) << 0)
        ),
    Abgr128Float =
        (
            (1 << 28)
            | ((PixelType.Arrayf32) << 24)
            | ((ArrayOrder.Abgr) << 20)
            | ((0) << 16)
            | ((128) << 8)
            | ((16) << 0)
        ),
    Rgba32 = Abgr8888,
    Argb32 = Bgra8888,
    Bgra32 = Argb8888,
    Abgr32 = Rgba8888,
    Rgbx32 = Xbgr8888,
    Xrgb32 = Bgrx8888,
    Bgrx32 = Xrgb8888,
    Xbgr32 = Rgbx8888,
    Yv12 =
        (
            ((uint)((byte)('Y')) << 0)
            | ((uint)((byte)('V')) << 8)
            | ((uint)((byte)('1')) << 16)
            | ((uint)((byte)('2')) << 24)
        ),
    Iyuv =
        (
            ((uint)((byte)('I')) << 0)
            | ((uint)((byte)('Y')) << 8)
            | ((uint)((byte)('U')) << 16)
            | ((uint)((byte)('V')) << 24)
        ),
    Yuy2 =
        (
            ((uint)((byte)('Y')) << 0)
            | ((uint)((byte)('U')) << 8)
            | ((uint)((byte)('Y')) << 16)
            | ((uint)((byte)('2')) << 24)
        ),
    Uyvy =
        (
            ((uint)((byte)('U')) << 0)
            | ((uint)((byte)('Y')) << 8)
            | ((uint)((byte)('V')) << 16)
            | ((uint)((byte)('Y')) << 24)
        ),
    Yvyu =
        (
            ((uint)((byte)('Y')) << 0)
            | ((uint)((byte)('V')) << 8)
            | ((uint)((byte)('Y')) << 16)
            | ((uint)((byte)('U')) << 24)
        ),
    Nv12 =
        (
            ((uint)((byte)('N')) << 0)
            | ((uint)((byte)('V')) << 8)
            | ((uint)((byte)('1')) << 16)
            | ((uint)((byte)('2')) << 24)
        ),
    Nv21 =
        (
            ((uint)((byte)('N')) << 0)
            | ((uint)((byte)('V')) << 8)
            | ((uint)((byte)('2')) << 16)
            | ((uint)((byte)('1')) << 24)
        ),
    P010 =
        (
            ((uint)((byte)('P')) << 0)
            | ((uint)((byte)('0')) << 8)
            | ((uint)((byte)('1')) << 16)
            | ((uint)((byte)('0')) << 24)
        ),
    ExternalOes =
        (
            ((uint)((byte)('O')) << 0)
            | ((uint)((byte)('E')) << 8)
            | ((uint)((byte)('S')) << 16)
            | ((uint)((byte)(' ')) << 24)
        ),
}
