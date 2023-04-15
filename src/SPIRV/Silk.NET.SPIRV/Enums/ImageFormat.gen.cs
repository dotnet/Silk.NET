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
        FormatUnknown = 0x0,
        [NativeName("Name", "SpvImageFormatRgba32f")]
        FormatRgba32f = 0x1,
        [NativeName("Name", "SpvImageFormatRgba16f")]
        FormatRgba16f = 0x2,
        [NativeName("Name", "SpvImageFormatR32f")]
        FormatR32f = 0x3,
        [NativeName("Name", "SpvImageFormatRgba8")]
        FormatRgba8 = 0x4,
        [NativeName("Name", "SpvImageFormatRgba8Snorm")]
        FormatRgba8Snorm = 0x5,
        [NativeName("Name", "SpvImageFormatRg32f")]
        FormatRg32f = 0x6,
        [NativeName("Name", "SpvImageFormatRg16f")]
        FormatRg16f = 0x7,
        [NativeName("Name", "SpvImageFormatR11fG11fB10f")]
        FormatR11fG11fB10f = 0x8,
        [NativeName("Name", "SpvImageFormatR16f")]
        FormatR16f = 0x9,
        [NativeName("Name", "SpvImageFormatRgba16")]
        FormatRgba16 = 0xA,
        [NativeName("Name", "SpvImageFormatRgb10A2")]
        FormatRgb10A2 = 0xB,
        [NativeName("Name", "SpvImageFormatRg16")]
        FormatRg16 = 0xC,
        [NativeName("Name", "SpvImageFormatRg8")]
        FormatRg8 = 0xD,
        [NativeName("Name", "SpvImageFormatR16")]
        FormatR16 = 0xE,
        [NativeName("Name", "SpvImageFormatR8")]
        FormatR8 = 0xF,
        [NativeName("Name", "SpvImageFormatRgba16Snorm")]
        FormatRgba16Snorm = 0x10,
        [NativeName("Name", "SpvImageFormatRg16Snorm")]
        FormatRg16Snorm = 0x11,
        [NativeName("Name", "SpvImageFormatRg8Snorm")]
        FormatRg8Snorm = 0x12,
        [NativeName("Name", "SpvImageFormatR16Snorm")]
        FormatR16Snorm = 0x13,
        [NativeName("Name", "SpvImageFormatR8Snorm")]
        FormatR8Snorm = 0x14,
        [NativeName("Name", "SpvImageFormatRgba32i")]
        FormatRgba32i = 0x15,
        [NativeName("Name", "SpvImageFormatRgba16i")]
        FormatRgba16i = 0x16,
        [NativeName("Name", "SpvImageFormatRgba8i")]
        FormatRgba8i = 0x17,
        [NativeName("Name", "SpvImageFormatR32i")]
        FormatR32i = 0x18,
        [NativeName("Name", "SpvImageFormatRg32i")]
        FormatRg32i = 0x19,
        [NativeName("Name", "SpvImageFormatRg16i")]
        FormatRg16i = 0x1A,
        [NativeName("Name", "SpvImageFormatRg8i")]
        FormatRg8i = 0x1B,
        [NativeName("Name", "SpvImageFormatR16i")]
        FormatR16i = 0x1C,
        [NativeName("Name", "SpvImageFormatR8i")]
        FormatR8i = 0x1D,
        [NativeName("Name", "SpvImageFormatRgba32ui")]
        FormatRgba32ui = 0x1E,
        [NativeName("Name", "SpvImageFormatRgba16ui")]
        FormatRgba16ui = 0x1F,
        [NativeName("Name", "SpvImageFormatRgba8ui")]
        FormatRgba8ui = 0x20,
        [NativeName("Name", "SpvImageFormatR32ui")]
        FormatR32ui = 0x21,
        [NativeName("Name", "SpvImageFormatRgb10a2ui")]
        FormatRgb10a2ui = 0x22,
        [NativeName("Name", "SpvImageFormatRg32ui")]
        FormatRg32ui = 0x23,
        [NativeName("Name", "SpvImageFormatRg16ui")]
        FormatRg16ui = 0x24,
        [NativeName("Name", "SpvImageFormatRg8ui")]
        FormatRg8ui = 0x25,
        [NativeName("Name", "SpvImageFormatR16ui")]
        FormatR16ui = 0x26,
        [NativeName("Name", "SpvImageFormatR8ui")]
        FormatR8ui = 0x27,
        [NativeName("Name", "SpvImageFormatR64ui")]
        FormatR64ui = 0x28,
        [NativeName("Name", "SpvImageFormatR64i")]
        FormatR64i = 0x29,
        [NativeName("Name", "SpvImageFormatMax")]
        FormatMax = 0x7FFFFFFF,
    }
}
