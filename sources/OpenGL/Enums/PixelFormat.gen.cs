// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PixelFormat : uint
{
    UnsignedShort = 0x1403,
    UnsignedInt = 0x1405,
    StencilIndex = 0x1901,
    DepthComponent = 0x1902,
    RED = 0x1903,
    Green = 0x1904,
    BLUE = 0x1905,
    Alpha = 0x1906,
    RGB = 0x1907,
    RGBA = 0x1908,
    BGR = 0x80E0,
    BGRA = 0x80E1,
    RedInteger = 0x8D94,
    GreenInteger = 0x8D95,
    BlueInteger = 0x8D96,
    RgbInteger = 0x8D98,
    RgbaInteger = 0x8D99,
    BgrInteger = 0x8D9A,
    BgraInteger = 0x8D9B,
    DepthStencil = 0x84F9,
    RG = 0x8227,
    RgInteger = 0x8228,
    ColorIndex = 0x1900,
    Luminance = 0x1909,
    LuminanceAlpha = 0x190A,
    AbgrEXT = 0x8000,
    BgrExt = 0x80E0,
    BgraEXT = 0x80E1,
    CmykEXT = 0x800C,
    CmykaEXT = 0x800D,
    Ycrcb422Sgix = 0x81BB,
    Ycrcb444Sgix = 0x81BC,
    BgraIMG = 0x80E1,
    RedExt = 0x1903
}
