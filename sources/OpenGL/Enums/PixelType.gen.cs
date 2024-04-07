// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelType : uint
{
    BYTE = 0x1400,
    UnsignedByte = 0x1401,
    Short = 0x1402,
    UnsignedShort = 0x1403,
    INT = 0x1404,
    UnsignedInt = 0x1405,
    Float = 0x1406,
    UnsignedByte3X3X2 = 0x8032,
    UnsignedShort4X4X4X4 = 0x8033,
    UnsignedShort5X5X5X1 = 0x8034,
    UnsignedInt8X8X8X8 = 0x8035,
    UnsignedInt10X10X10X2 = 0x8036,
    UnsignedByte2X3X3Rev = 0x8362,
    UnsignedShort5X6X5 = 0x8363,
    UnsignedShort5X6X5Rev = 0x8364,
    UnsignedShort4X4X4X4Rev = 0x8365,
    UnsignedShort1X5X5X5Rev = 0x8366,
    UnsignedInt8X8X8X8Rev = 0x8367,
    UnsignedInt2X10X10X10Rev = 0x8368,
    UnsignedInt10F11F11FRev = 0x8C3B,
    UnsignedInt5X9X9X9Rev = 0x8C3E,
    Float32UnsignedInt24X8Rev = 0x8DAD,
    UnsignedInt24X8 = 0x84FA,
    HalfFloat = 0x140B,
    Float32UnsignedInt24X8RevNV = 0x8DAD,
    Bitmap = 0x1A00,
    HalfFloatARB = 0x140B,
    HalfApple = 0x140B,
    UnsignedInt24X8EXT = 0x84FA,
    UnsignedInt10F11F11FRevEXT = 0x8C3B,
    UnsignedByte3X3X2EXT = 0x8032,
    UnsignedShort4X4X4X4EXT = 0x8033,
    UnsignedShort5X5X5X1EXT = 0x8034,
    UnsignedInt8X8X8X8EXT = 0x8035,
    UnsignedInt10X10X10X2EXT = 0x8036,
    UnsignedInt5X9X9X9RevEXT = 0x8C3E,
    HalfFloatNV = 0x140B,
    UnsignedInt24X8NV = 0x84FA,
    UnsignedInt24X8OES = 0x84FA,
    UnsignedShort4X4X4X4RevEXT = 0x8365,
    UnsignedShort1X5X5X5RevEXT = 0x8366,
    UnsignedShort4X4X4X4RevIMG = 0x8365,
    UnsignedInt10F11F11FRevApple = 0x8C3B,
    UnsignedInt5X9X9X9RevApple = 0x8C3E,
    UnsignedInt2X10X10X10RevEXT = 0x8368
}
