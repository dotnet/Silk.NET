// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelFormat")]
[Transformed]
public enum PixelFormat : uint
{
    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = unchecked((uint)0x1403),

    [NativeName("GL_ALPHA")]
    Alpha = unchecked((uint)0x1906),

    [NativeName("GL_RGB")]
    Rgb = unchecked((uint)0x1907),

    [NativeName("GL_RGBA")]
    Rgba = unchecked((uint)0x1908),

    [NativeName("GL_LUMINANCE")]
    Luminance = unchecked((uint)0x1909),

    [NativeName("GL_LUMINANCE_ALPHA")]
    LuminanceAlpha = unchecked((uint)0x190A),

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = unchecked((uint)0x1405),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGRA_EXT")]
    BgraEXT = unchecked((uint)0x80E1),

    [NameAffix("Suffix", "IMG", 0)]
    [NativeName("GL_BGRA_IMG")]
    BgraIMG = unchecked((uint)0x80E1),

    [NativeName("GL_STENCIL_INDEX")]
    StencilIndex = unchecked((uint)0x1901),

    [NativeName("GL_DEPTH_COMPONENT")]
    DepthComponent = unchecked((uint)0x1902),

    [NativeName("GL_RED")]
    Red = unchecked((uint)0x1903),

    [NativeName("GL_GREEN")]
    Green = unchecked((uint)0x1904),

    [NativeName("GL_BLUE")]
    Blue = unchecked((uint)0x1905),

    [NativeName("GL_COLOR_INDEX")]
    ColorIndex = unchecked((uint)0x1900),

    [NativeName("GL_BGR")]
    Bgr = unchecked((uint)0x80E0),

    [NativeName("GL_BGRA")]
    Bgra = unchecked((uint)0x80E1),

    [NativeName("GL_RED_INTEGER")]
    RedInteger = unchecked((uint)0x8D94),

    [NativeName("GL_GREEN_INTEGER")]
    GreenInteger = unchecked((uint)0x8D95),

    [NativeName("GL_BLUE_INTEGER")]
    BlueInteger = unchecked((uint)0x8D96),

    [NativeName("GL_RGB_INTEGER")]
    RgbInteger = unchecked((uint)0x8D98),

    [NativeName("GL_RGBA_INTEGER")]
    RgbaInteger = unchecked((uint)0x8D99),

    [NativeName("GL_BGR_INTEGER")]
    BgrInteger = unchecked((uint)0x8D9A),

    [NativeName("GL_BGRA_INTEGER")]
    BgraInteger = unchecked((uint)0x8D9B),

    [NativeName("GL_DEPTH_STENCIL")]
    DepthStencil = unchecked((uint)0x84F9),

    [NativeName("GL_RG")]
    Rg = unchecked((uint)0x8227),

    [NativeName("GL_RG_INTEGER")]
    RgInteger = unchecked((uint)0x8228),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_ABGR_EXT")]
    AbgrEXT = unchecked((uint)0x8000),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_BGR_EXT")]
    BgrEXT = unchecked((uint)0x80E0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CMYK_EXT")]
    CmykEXT = unchecked((uint)0x800C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_CMYKA_EXT")]
    CmykaEXT = unchecked((uint)0x800D),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCB_422_SGIX")]
    Ycrcb422SGIX = unchecked((uint)0x81BB),

    [NameAffix("Suffix", "SGIX", 0)]
    [NativeName("GL_YCRCB_444_SGIX")]
    Ycrcb444SGIX = unchecked((uint)0x81BC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_RED_EXT")]
    RedEXT = unchecked((uint)0x1903),
}
