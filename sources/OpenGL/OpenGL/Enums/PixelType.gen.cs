// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelType")]
public enum PixelType : uint
{
    [NativeName("GL_BYTE")]
    Byte = 5120,

    [NativeName("GL_UNSIGNED_BYTE")]
    UnsignedByte = 5121,

    [NativeName("GL_SHORT")]
    Short = 5122,

    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = 5123,

    [NativeName("GL_INT")]
    Int = 5124,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_FLOAT")]
    Float = 5126,

    [NativeName("GL_BITMAP")]
    Bitmap = 6656,

    [NativeName("GL_UNSIGNED_BYTE_3_3_2")]
    UnsignedByte3X3X2 = 32818,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4")]
    UnsignedShort4X4X4X4 = 32819,

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1")]
    UnsignedShort5X5X5X1 = 32820,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8")]
    UnsignedInt8X8X8X8 = 32821,

    [NativeName("GL_UNSIGNED_INT_10_10_10_2")]
    UnsignedInt10X10X10X2 = 32822,

    [NativeName("GL_UNSIGNED_BYTE_2_3_3_REV")]
    UnsignedByte2X3X3Rev = 33634,

    [NativeName("GL_UNSIGNED_SHORT_5_6_5")]
    UnsignedShort5X6X5 = 33635,

    [NativeName("GL_UNSIGNED_SHORT_5_6_5_REV")]
    UnsignedShort5X6X5Rev = 33636,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV")]
    UnsignedShort4X4X4X4Rev = 33637,

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV")]
    UnsignedShort1X5X5X5Rev = 33638,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_REV")]
    UnsignedInt8X8X8X8Rev = 33639,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV")]
    UnsignedInt2X10X10X10Rev = 33640,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV")]
    UnsignedInt10F11F11FRev = 35899,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV")]
    UnsignedInt5X9X9X9Rev = 35902,

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
    Float32UnsignedInt24X8Rev = 36269,

    [NativeName("GL_UNSIGNED_INT_24_8")]
    UnsignedInt24X8 = 34042,

    [NativeName("GL_HALF_FLOAT")]
    HalfFloat = 5131,

    [NativeName("GL_HALF_FLOAT_ARB")]
    HalfFloatARB = 5131,

    [NativeName("GL_HALF_APPLE")]
    HalfAPPLE = 5131,

    [NativeName("GL_UNSIGNED_INT_24_8_EXT")]
    UnsignedInt24X8EXT = 34042,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
    UnsignedInt10F11F11FRevEXT = 35899,

    [NativeName("GL_UNSIGNED_BYTE_3_3_2_EXT")]
    UnsignedByte3X3X2EXT = 32818,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
    UnsignedShort4X4X4X4EXT = 32819,

    [NativeName("GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
    UnsignedShort5X5X5X1EXT = 32820,

    [NativeName("GL_UNSIGNED_INT_8_8_8_8_EXT")]
    UnsignedInt8X8X8X8EXT = 32821,

    [NativeName("GL_UNSIGNED_INT_10_10_10_2_EXT")]
    UnsignedInt10X10X10X2EXT = 32822,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
    UnsignedInt5X9X9X9RevEXT = 35902,

    [NativeName("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
    Float32UnsignedInt24X8RevNV = 36269,

    [NativeName("GL_HALF_FLOAT_NV")]
    HalfFloatNV = 5131,

    [NativeName("GL_UNSIGNED_INT_24_8_NV")]
    UnsignedInt24X8NV = 34042,

    [NativeName("GL_UNSIGNED_INT_24_8_OES")]
    UnsignedInt24X8OES = 34042,

    [NativeName("GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
    UnsignedInt10F11F11FRevAPPLE = 35899,

    [NativeName("GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
    UnsignedInt5X9X9X9RevAPPLE = 35902,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
    UnsignedShort4X4X4X4RevEXT = 33637,

    [NativeName("GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
    UnsignedShort1X5X5X5RevEXT = 33638,

    [NativeName("GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
    UnsignedInt2X10X10X10RevEXT = 33640,

    [NativeName("GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
    UnsignedShort4X4X4X4RevIMG = 33637,
}
