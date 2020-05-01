// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum PixelFormat
    {
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
        ColorIndex = 0x1900,
        StencilIndex = 0x1901,
        DepthComponent = 0x1902,
        Red = 0x1903,
        RedExt = 0x1903,
        Green = 0x1904,
        Blue = 0x1905,
        Alpha = 0x1906,
        Rgb = 0x1907,
        Rgba = 0x1908,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        AbgrExt = 0x8000,
        CmykExt = 0x800C,
        CmykaExt = 0x800D,
        Bgr = 0x80E0,
        Bgra = 0x80E1,
        Ycrcb422Sgix = 0x81BB,
        Ycrcb444Sgix = 0x81BC,
        RG = 0x8227,
        RGInteger = 0x8228,
        DepthStencil = 0x84F9,
        RedInteger = 0x8D94,
        GreenInteger = 0x8D95,
        BlueInteger = 0x8D96,
        RgbInteger = 0x8D98,
        RgbaInteger = 0x8D99,
        BgrInteger = 0x8D9A,
        BgraInteger = 0x8D9B,
    }
}
