// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelType")]
[Transformed]
public enum PixelType : uint
{
    [NativeName("GL_BYTE")]
    Byte = unchecked((uint)0x1400),

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = unchecked((uint)0x1401),

    [NativeName("GL_SHORT")]
    Short = unchecked((uint)0x1402),

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = unchecked((uint)0x1403),

    [NativeName("GL_FLOAT")]
    Float = unchecked((uint)0x1406),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4")]
    UnsignedShort4X4X4X4 = unchecked((uint)0x8033),

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1")]
    UnsignedShort5X5X5X1 = unchecked((uint)0x8034),

    [NativeName("GL_UNSIGNED_SHORT_5_6_5")]
    UnsignedShort5X6X5 = unchecked((uint)0x8363),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_OES")]
    UnsignedInt24X8OES = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
    UnsignedShort4X4X4X4RevEXT = unchecked((uint)0x8365),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
    UnsignedShort1X5X5X5RevEXT = unchecked((uint)0x8366),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
    UnsignedShort4X4X4X4RevIMG = unchecked((uint)0x8365),

    [NativeName("GL_INT")]
    Int = unchecked((uint)0x1404),

    [NativeName("GL_BITMAP")]
    Bitmap = unchecked((uint)0x1A00),

    [NativeName("GL_UNSIGNED_BYTE_3_3_2")]
    UnsignedByte3X3X2 = unchecked((uint)0x8032),

    [NativeName("GL_UNSIGNED_INT_8_8_8_8")]
    UnsignedInt8X8X8X8 = unchecked((uint)0x8035),

    [NativeName("GL_UNSIGNED_INT_10_10_10_2")]
    UnsignedInt10X10X10X2 = unchecked((uint)0x8036),

    [NativeName("GL_UNSIGNED_BYTE_2_3_3_REV")]
    UnsignedByte2X3X3Rev = unchecked((uint)0x8362),

    [NativeName("GL_UNSIGNED_SHORT_5_6_5_REV")]
    UnsignedShort5X6X5Rev = unchecked((uint)0x8364),

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV")]
    UnsignedShort4X4X4X4Rev = unchecked((uint)0x8365),

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV")]
    UnsignedShort1X5X5X5Rev = unchecked((uint)0x8366),

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_REV")]
    UnsignedInt8X8X8X8Rev = unchecked((uint)0x8367),

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = unchecked((uint)0x8368),

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV")]
    UnsignedInt5X9X9X9Rev = unchecked((uint)0x8C3E),

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
    Float32UnsignedInt24X8Rev = unchecked((uint)0x8DAD),

    [NativeName("GL_UNSIGNED_INT_24_8")]
    UnsignedInt24X8 = unchecked((uint)0x84FA),

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = unchecked((uint)0x140B),

    [NameAffix("Suffix", "ARB", 0)]
    [NativeName("GL_HALF_FLOAT_ARB")]
    HalfFloatARB = unchecked((uint)0x140B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_HALF_APPLE")]
    HalfAPPLE = unchecked((uint)0x140B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_EXT")]
    UnsignedInt24X8EXT = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
    UnsignedInt10F11F11FRevEXT = unchecked((uint)0x8C3B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_BYTE_3_3_2_EXT")]
    UnsignedByte3X3X2EXT = unchecked((uint)0x8032),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
    UnsignedShort4X4X4X4EXT = unchecked((uint)0x8033),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
    UnsignedShort5X5X5X1EXT = unchecked((uint)0x8034),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_8_8_8_8_EXT")]
    UnsignedInt8X8X8X8EXT = unchecked((uint)0x8035),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_10_10_10_2_EXT")]
    UnsignedInt10X10X10X2EXT = unchecked((uint)0x8036),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
    UnsignedInt5X9X9X9RevEXT = unchecked((uint)0x8C3E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
    Float32UnsignedInt24X8RevNV = unchecked((uint)0x8DAD),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HALF_FLOAT_NV")]
    HalfFloatNV = unchecked((uint)0x140B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_UNSIGNED_INT_24_8_NV")]
    UnsignedInt24X8NV = unchecked((uint)0x84FA),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
    UnsignedInt10F11F11FRevAPPLE = unchecked((uint)0x8C3B),

    [NameAffix("Suffix", "APPLE", 0)]
    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
    UnsignedInt5X9X9X9RevAPPLE = unchecked((uint)0x8C3E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10RevEXT = unchecked((uint)0x8368),
}
