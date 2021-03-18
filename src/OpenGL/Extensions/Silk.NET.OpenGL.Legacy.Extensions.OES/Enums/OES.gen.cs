// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    [NativeName("Name", "GLenum")]
    public enum OES : int
    {
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_PALETTE4_RGB8_OES")]
        Palette4Rgb8Oes = 0x8B90,
        [NativeName("Name", "GL_PALETTE4_RGBA8_OES")]
        Palette4Rgba8Oes = 0x8B91,
        [NativeName("Name", "GL_PALETTE4_R5_G6_B5_OES")]
        Palette4R5G6B5Oes = 0x8B92,
        [NativeName("Name", "GL_PALETTE4_RGBA4_OES")]
        Palette4Rgba4Oes = 0x8B93,
        [NativeName("Name", "GL_PALETTE4_RGB5_A1_OES")]
        Palette4Rgb5A1Oes = 0x8B94,
        [NativeName("Name", "GL_PALETTE8_RGB8_OES")]
        Palette8Rgb8Oes = 0x8B95,
        [NativeName("Name", "GL_PALETTE8_RGBA8_OES")]
        Palette8Rgba8Oes = 0x8B96,
        [NativeName("Name", "GL_PALETTE8_R5_G6_B5_OES")]
        Palette8R5G6B5Oes = 0x8B97,
        [NativeName("Name", "GL_PALETTE8_RGBA4_OES")]
        Palette8Rgba4Oes = 0x8B98,
        [NativeName("Name", "GL_PALETTE8_RGB5_A1_OES")]
        Palette8Rgb5A1Oes = 0x8B99,
        [NativeName("Name", "GL_FIXED_OES")]
        FixedOes = 0x140C,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_TYPE_OES")]
        ImplementationColorReadTypeOes = 0x8B9A,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES")]
        ImplementationColorReadFormatOes = 0x8B9B,
    }
}
