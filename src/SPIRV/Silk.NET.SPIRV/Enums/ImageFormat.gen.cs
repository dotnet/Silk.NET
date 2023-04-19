// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvImageFormat_")]
    public enum ImageFormat : int
    {
        [NativeName("Name", "SpvImageFormatUnknown")]
        Unknown = 0x0,
        [NativeName("Name", "SpvImageFormatRgba32f")]
        Rgba32f = 0x1,
        [NativeName("Name", "SpvImageFormatRgba16f")]
        Rgba16f = 0x2,
        [NativeName("Name", "SpvImageFormatR32f")]
        R32f = 0x3,
        [NativeName("Name", "SpvImageFormatRgba8")]
        Rgba8 = 0x4,
        [NativeName("Name", "SpvImageFormatRgba8Snorm")]
        Rgba8Snorm = 0x5,
        [NativeName("Name", "SpvImageFormatRg32f")]
        Rg32f = 0x6,
        [NativeName("Name", "SpvImageFormatRg16f")]
        Rg16f = 0x7,
        [NativeName("Name", "SpvImageFormatR11fG11fB10f")]
        R11fG11fB10f = 0x8,
        [NativeName("Name", "SpvImageFormatR16f")]
        R16f = 0x9,
        [NativeName("Name", "SpvImageFormatRgba16")]
        Rgba16 = 0xA,
        [NativeName("Name", "SpvImageFormatRgb10A2")]
        Rgb10A2 = 0xB,
        [NativeName("Name", "SpvImageFormatRg16")]
        Rg16 = 0xC,
        [NativeName("Name", "SpvImageFormatRg8")]
        Rg8 = 0xD,
        [NativeName("Name", "SpvImageFormatR16")]
        R16 = 0xE,
        [NativeName("Name", "SpvImageFormatR8")]
        R8 = 0xF,
        [NativeName("Name", "SpvImageFormatRgba16Snorm")]
        Rgba16Snorm = 0x10,
        [NativeName("Name", "SpvImageFormatRg16Snorm")]
        Rg16Snorm = 0x11,
        [NativeName("Name", "SpvImageFormatRg8Snorm")]
        Rg8Snorm = 0x12,
        [NativeName("Name", "SpvImageFormatR16Snorm")]
        R16Snorm = 0x13,
        [NativeName("Name", "SpvImageFormatR8Snorm")]
        R8Snorm = 0x14,
        [NativeName("Name", "SpvImageFormatRgba32i")]
        Rgba32i = 0x15,
        [NativeName("Name", "SpvImageFormatRgba16i")]
        Rgba16i = 0x16,
        [NativeName("Name", "SpvImageFormatRgba8i")]
        Rgba8i = 0x17,
        [NativeName("Name", "SpvImageFormatR32i")]
        R32i = 0x18,
        [NativeName("Name", "SpvImageFormatRg32i")]
        Rg32i = 0x19,
        [NativeName("Name", "SpvImageFormatRg16i")]
        Rg16i = 0x1A,
        [NativeName("Name", "SpvImageFormatRg8i")]
        Rg8i = 0x1B,
        [NativeName("Name", "SpvImageFormatR16i")]
        R16i = 0x1C,
        [NativeName("Name", "SpvImageFormatR8i")]
        R8i = 0x1D,
        [NativeName("Name", "SpvImageFormatRgba32ui")]
        Rgba32ui = 0x1E,
        [NativeName("Name", "SpvImageFormatRgba16ui")]
        Rgba16ui = 0x1F,
        [NativeName("Name", "SpvImageFormatRgba8ui")]
        Rgba8ui = 0x20,
        [NativeName("Name", "SpvImageFormatR32ui")]
        R32ui = 0x21,
        [NativeName("Name", "SpvImageFormatRgb10a2ui")]
        Rgb10a2ui = 0x22,
        [NativeName("Name", "SpvImageFormatRg32ui")]
        Rg32ui = 0x23,
        [NativeName("Name", "SpvImageFormatRg16ui")]
        Rg16ui = 0x24,
        [NativeName("Name", "SpvImageFormatRg8ui")]
        Rg8ui = 0x25,
        [NativeName("Name", "SpvImageFormatR16ui")]
        R16ui = 0x26,
        [NativeName("Name", "SpvImageFormatR8ui")]
        R8ui = 0x27,
        [NativeName("Name", "SpvImageFormatR64ui")]
        R64ui = 0x28,
        [NativeName("Name", "SpvImageFormatR64i")]
        R64i = 0x29,
        [NativeName("Name", "SpvImageFormatMax")]
        Max = 0x7FFFFFFF,
    }
}
