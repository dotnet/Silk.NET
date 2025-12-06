// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PixelFormat")]
public enum PixelFormat : uint
{
    [NativeName("GL_UNSIGNED_SHORT")]
    UnsignedShort = 5123,

    [NativeName("GL_ALPHA")]
    Alpha = 6406,

    [NativeName("GL_RGB")]
    Rgb = 6407,

    [NativeName("GL_RGBA")]
    Rgba = 6408,

    [NativeName("GL_LUMINANCE")]
    Luminance = 6409,

    [NativeName("GL_LUMINANCE_ALPHA")]
    LuminanceAlpha = 6410,

    [NativeName("GL_UNSIGNED_INT")]
    UnsignedInt = 5125,

    [NativeName("GL_BGRA_EXT")]
    BgraEXT = 32993,

    [NativeName("GL_BGRA_IMG")]
    BgraIMG = 32993,

    [NativeName("GL_STENCIL_INDEX")]
    StencilIndex = 6401,

    [NativeName("GL_DEPTH_COMPONENT")]
    DepthComponent = 6402,

    [NativeName("GL_RED")]
    Red = 6403,

    [NativeName("GL_GREEN")]
    Green = 6404,

    [NativeName("GL_BLUE")]
    Blue = 6405,

    [NativeName("GL_COLOR_INDEX")]
    ColorIndex = 6400,

    [NativeName("GL_BGR")]
    Bgr = 32992,

    [NativeName("GL_BGRA")]
    Bgra = 32993,

    [NativeName("GL_RED_INTEGER")]
    RedInteger = 36244,

    [NativeName("GL_GREEN_INTEGER")]
    GreenInteger = 36245,

    [NativeName("GL_BLUE_INTEGER")]
    BlueInteger = 36246,

    [NativeName("GL_RGB_INTEGER")]
    RgbInteger = 36248,

    [NativeName("GL_RGBA_INTEGER")]
    RgbaInteger = 36249,

    [NativeName("GL_BGR_INTEGER")]
    BgrInteger = 36250,

    [NativeName("GL_BGRA_INTEGER")]
    BgraInteger = 36251,

    [NativeName("GL_DEPTH_STENCIL")]
    DepthStencil = 34041,

    [NativeName("GL_RG")]
    Rg = 33319,

    [NativeName("GL_RG_INTEGER")]
    RgInteger = 33320,

    [NativeName("GL_ABGR_EXT")]
    AbgrEXT = 32768,

    [NativeName("GL_BGR_EXT")]
    BgrEXT = 32992,

    [NativeName("GL_CMYK_EXT")]
    CmykEXT = 32780,

    [NativeName("GL_CMYKA_EXT")]
    CmykaEXT = 32781,

    [NativeName("GL_YCRCB_422_SGIX")]
    Ycrcb422SGIX = 33211,

    [NativeName("GL_YCRCB_444_SGIX")]
    Ycrcb444SGIX = 33212,

    [NativeName("GL_RED_EXT")]
    RedEXT = 6403,
}
