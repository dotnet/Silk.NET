// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelType")]
    public enum PixelType : int
    {
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_UNSIGNED_BYTE")]
        UnsignedByte = 0x1401,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_HALF_FLOAT")]
        HalfFloat = 0x140B,
        [NativeName("Name", "GL_HALF_FLOAT_ARB")]
        HalfFloatArb = 0x140B,
        [NativeName("Name", "GL_HALF_FLOAT_NV")]
        HalfFloatNV = 0x140B,
        [NativeName("Name", "GL_HALF_APPLE")]
        HalfApple = 0x140B,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_BITMAP")]
        Bitmap = 0x1A00,
        [NativeName("Name", "GL_UNSIGNED_BYTE_3_3_2")]
        UnsignedByte332 = 0x8032,
        [NativeName("Name", "GL_UNSIGNED_BYTE_3_3_2_EXT")]
        UnsignedByte332Ext = 0x8032,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4")]
        UnsignedShort4444 = 0x8033,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_EXT")]
        UnsignedShort4444Ext = 0x8033,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_5_5_1")]
        UnsignedShort5551 = 0x8034,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_5_5_1_EXT")]
        UnsignedShort5551Ext = 0x8034,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_8_8")]
        UnsignedInt8888 = 0x8035,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_8_8_EXT")]
        UnsignedInt8888Ext = 0x8035,
        [NativeName("Name", "GL_UNSIGNED_INT_10_10_10_2")]
        UnsignedInt1010102 = 0x8036,
        [NativeName("Name", "GL_UNSIGNED_INT_10_10_10_2_EXT")]
        UnsignedInt1010102Ext = 0x8036,
        [NativeName("Name", "GL_UNSIGNED_BYTE_2_3_3_REV")]
        UnsignedByte233Rev = 0x8362,
        [NativeName("Name", "GL_UNSIGNED_BYTE_2_3_3_REV_EXT")]
        UnsignedByte233RevExt = 0x8362,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_6_5")]
        UnsignedShort565 = 0x8363,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_6_5_EXT")]
        UnsignedShort565Ext = 0x8363,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_6_5_REV")]
        UnsignedShort565Rev = 0x8364,
        [NativeName("Name", "GL_UNSIGNED_SHORT_5_6_5_REV_EXT")]
        UnsignedShort565RevExt = 0x8364,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_REV")]
        UnsignedShort4444Rev = 0x8365,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT")]
        UnsignedShort4444RevExt = 0x8365,
        [NativeName("Name", "GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG")]
        UnsignedShort4444RevImg = 0x8365,
        [NativeName("Name", "GL_UNSIGNED_SHORT_1_5_5_5_REV")]
        UnsignedShort1555Rev = 0x8366,
        [NativeName("Name", "GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT")]
        UnsignedShort1555RevExt = 0x8366,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_8_8_REV")]
        UnsignedInt8888Rev = 0x8367,
        [NativeName("Name", "GL_UNSIGNED_INT_8_8_8_8_REV_EXT")]
        UnsignedInt8888RevExt = 0x8367,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV")]
        UnsignedInt2101010Rev = 0x8368,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV_EXT")]
        UnsignedInt2101010RevExt = 0x8368,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8")]
        UnsignedInt248 = 0x84FA,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_EXT")]
        UnsignedInt248Ext = 0x84FA,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_NV")]
        UnsignedInt248NV = 0x84FA,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8_OES")]
        UnsignedInt248Oes = 0x84FA,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV")]
        UnsignedInt10f11f11fRev = 0x8C3B,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV_APPLE")]
        UnsignedInt10f11f11fRevApple = 0x8C3B,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
        UnsignedInt10f11f11fRevExt = 0x8C3B,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV")]
        UnsignedInt5999Rev = 0x8C3E,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV_APPLE")]
        UnsignedInt5999RevApple = 0x8C3E,
        [NativeName("Name", "GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
        UnsignedInt5999RevExt = 0x8C3E,
        [NativeName("Name", "GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
        Float32UnsignedInt248Rev = 0x8DAD,
        [NativeName("Name", "GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
        Float32UnsignedInt248RevNV = 0x8DAD,
    }
}
