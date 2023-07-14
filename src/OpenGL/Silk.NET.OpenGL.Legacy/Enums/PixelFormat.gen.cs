// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelFormat")]
    public enum PixelFormat : int
    {
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_COLOR_INDEX")]
        ColorIndex = 0x1900,
        [NativeName("Name", "GL_STENCIL_INDEX")]
        StencilIndex = 0x1901,
        [NativeName("Name", "GL_DEPTH_COMPONENT")]
        DepthComponent = 0x1902,
        [NativeName("Name", "GL_RED")]
        Red = 0x1903,
        [NativeName("Name", "GL_RED_EXT")]
        RedExt = 0x1903,
        [NativeName("Name", "GL_GREEN")]
        Green = 0x1904,
        [NativeName("Name", "GL_BLUE")]
        Blue = 0x1905,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE")]
        Luminance = 0x1909,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LUMINANCE_ALPHA")]
        LuminanceAlpha = 0x190A,
        [NativeName("Name", "GL_ABGR_EXT")]
        AbgrExt = 0x8000,
        [NativeName("Name", "GL_CMYK_EXT")]
        CmykExt = 0x800C,
        [NativeName("Name", "GL_CMYKA_EXT")]
        CmykaExt = 0x800D,
        [NativeName("Name", "GL_BGR")]
        Bgr = 0x80E0,
        [NativeName("Name", "GL_BGR_EXT")]
        BgrExt = 0x80E0,
        [NativeName("Name", "GL_BGRA")]
        Bgra = 0x80E1,
        [NativeName("Name", "GL_BGRA_EXT")]
        BgraExt = 0x80E1,
        [NativeName("Name", "GL_BGRA_IMG")]
        BgraImg = 0x80E1,
        [NativeName("Name", "GL_YCRCB_422_SGIX")]
        Ycrcb422Sgix = 0x81BB,
        [NativeName("Name", "GL_YCRCB_444_SGIX")]
        Ycrcb444Sgix = 0x81BC,
        [NativeName("Name", "GL_RG")]
        RG = 0x8227,
        [NativeName("Name", "GL_RG_INTEGER")]
        RGInteger = 0x8228,
        [NativeName("Name", "GL_DEPTH_STENCIL")]
        DepthStencil = 0x84F9,
        [NativeName("Name", "GL_RED_INTEGER")]
        RedInteger = 0x8D94,
        [NativeName("Name", "GL_GREEN_INTEGER")]
        GreenInteger = 0x8D95,
        [NativeName("Name", "GL_BLUE_INTEGER")]
        BlueInteger = 0x8D96,
        [NativeName("Name", "GL_RGB_INTEGER")]
        RgbInteger = 0x8D98,
        [NativeName("Name", "GL_RGBA_INTEGER")]
        RgbaInteger = 0x8D99,
        [NativeName("Name", "GL_BGR_INTEGER")]
        BgrInteger = 0x8D9A,
        [NativeName("Name", "GL_BGRA_INTEGER")]
        BgraInteger = 0x8D9B,
    }
}
