// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelFormat : uint
{
    UnsignedShort = unchecked((uint)0x1403),
    UnsignedInt = unchecked((uint)0x1405),
    StencilIndex = unchecked((uint)0x1901),
    DepthComponent = unchecked((uint)0x1902),
    Red = unchecked((uint)0x1903),
    Green = unchecked((uint)0x1904),
    Blue = unchecked((uint)0x1905),
    Alpha = unchecked((uint)0x1906),
    Rgb = unchecked((uint)0x1907),
    Rgba = unchecked((uint)0x1908),
    ColorIndex = unchecked((uint)0x1900),
    Luminance = unchecked((uint)0x1909),
    LuminanceAlpha = unchecked((uint)0x190A),
    Bgr = unchecked((uint)0x80E0),
    Bgra = unchecked((uint)0x80E1),
    RedInteger = unchecked((uint)0x8D94),
    GreenInteger = unchecked((uint)0x8D95),
    BlueInteger = unchecked((uint)0x8D96),
    RgbInteger = unchecked((uint)0x8D98),
    RgbaInteger = unchecked((uint)0x8D99),
    BgrInteger = unchecked((uint)0x8D9A),
    BgraInteger = unchecked((uint)0x8D9B),
    DepthStencil = unchecked((uint)0x84F9),
    Rg = unchecked((uint)0x8227),
    RgInteger = unchecked((uint)0x8228),
    AbgrEXT = unchecked((uint)0x8000),
    BgrEXT = unchecked((uint)0x80E0),
    BgraEXT = unchecked((uint)0x80E1),
    CmykEXT = unchecked((uint)0x800C),
    CmykaEXT = unchecked((uint)0x800D),
    Ycrcb422Sgix = unchecked((uint)0x81BB),
    Ycrcb444Sgix = unchecked((uint)0x81BC),
    RedEXT = unchecked((uint)0x1903),
    BgraIMG = unchecked((uint)0x80E1),
}
