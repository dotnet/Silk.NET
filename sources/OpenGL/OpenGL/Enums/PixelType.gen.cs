// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelType : uint
{
    Byte = unchecked((uint)0x1400),
    UnsignedByte = unchecked((uint)0x1401),
    Short = unchecked((uint)0x1402),
    UnsignedShort = unchecked((uint)0x1403),
    Int = unchecked((uint)0x1404),
    UnsignedInt = unchecked((uint)0x1405),
    Float = unchecked((uint)0x1406),
    Bitmap = unchecked((uint)0x1A00),
    UnsignedByte3X3X2 = unchecked((uint)0x8032),
    UnsignedShort4X4X4X4 = unchecked((uint)0x8033),
    UnsignedShort5X5X5X1 = unchecked((uint)0x8034),
    UnsignedInt8X8X8X8 = unchecked((uint)0x8035),
    UnsignedInt10X10X10X2 = unchecked((uint)0x8036),
    UnsignedByte2X3X3Rev = unchecked((uint)0x8362),
    UnsignedShort5X6X5 = unchecked((uint)0x8363),
    UnsignedShort5X6X5Rev = unchecked((uint)0x8364),
    UnsignedShort4X4X4X4Rev = unchecked((uint)0x8365),
    UnsignedShort1X5X5X5Rev = unchecked((uint)0x8366),
    UnsignedInt8X8X8X8Rev = unchecked((uint)0x8367),
    UnsignedInt2X10X10X10Rev = unchecked((uint)0x8368),
    UnsignedInt10F11F11FRev = unchecked((uint)0x8C3B),
    UnsignedInt5X9X9X9Rev = unchecked((uint)0x8C3E),
    Float32UnsignedInt24X8Rev = unchecked((uint)0x8DAD),
    UnsignedInt24X8 = unchecked((uint)0x84FA),
    HalfFloat = unchecked((uint)0x140B),
    HalfFloatARB = unchecked((uint)0x140B),
    HalfApple = unchecked((uint)0x140B),
    UnsignedInt24X8EXT = unchecked((uint)0x84FA),
    UnsignedInt10F11F11FRevEXT = unchecked((uint)0x8C3B),
    UnsignedByte3X3X2EXT = unchecked((uint)0x8032),
    UnsignedShort4X4X4X4EXT = unchecked((uint)0x8033),
    UnsignedShort5X5X5X1EXT = unchecked((uint)0x8034),
    UnsignedInt8X8X8X8EXT = unchecked((uint)0x8035),
    UnsignedInt10X10X10X2EXT = unchecked((uint)0x8036),
    UnsignedInt5X9X9X9RevEXT = unchecked((uint)0x8C3E),
    Float32UnsignedInt24X8RevNV = unchecked((uint)0x8DAD),
    HalfFloatNV = unchecked((uint)0x140B),
    UnsignedInt24X8NV = unchecked((uint)0x84FA),
    UnsignedInt24X8OES = unchecked((uint)0x84FA),
    UnsignedInt10F11F11FRevApple = unchecked((uint)0x8C3B),
    UnsignedInt5X9X9X9RevApple = unchecked((uint)0x8C3E),
    UnsignedShort4X4X4X4RevEXT = unchecked((uint)0x8365),
    UnsignedShort1X5X5X5RevEXT = unchecked((uint)0x8366),
    UnsignedInt2X10X10X10RevEXT = unchecked((uint)0x8368),
    UnsignedShort4X4X4X4RevIMG = unchecked((uint)0x8365),
}
