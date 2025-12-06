// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorTableParameterPName")]
public enum ColorTableParameterPName : uint
{
    [NativeName("GL_COLOR_TABLE_SCALE")]
    Scale = 32982,

    [NativeName("GL_COLOR_TABLE_BIAS")]
    Bias = 32983,

    [NativeName("GL_COLOR_TABLE_FORMAT")]
    Format = 32984,

    [NativeName("GL_COLOR_TABLE_WIDTH")]
    Width = 32985,

    [NativeName("GL_COLOR_TABLE_RED_SIZE")]
    RedSize = 32986,

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE")]
    GreenSize = 32987,

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE")]
    BlueSize = 32988,

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE")]
    AlphaSize = 32989,

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE")]
    LuminanceSize = 32990,

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE")]
    IntensitySize = 32991,

    [NativeName("GL_COLOR_TABLE_SCALE_SGI")]
    ScaleSGI = 32982,

    [NativeName("GL_COLOR_TABLE_BIAS_SGI")]
    BiasSGI = 32983,

    [NativeName("GL_COLOR_TABLE_FORMAT_SGI")]
    FormatSGI = 32984,

    [NativeName("GL_COLOR_TABLE_WIDTH_SGI")]
    WidthSGI = 32985,

    [NativeName("GL_COLOR_TABLE_RED_SIZE_SGI")]
    RedSizeSGI = 32986,

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
    GreenSizeSGI = 32987,

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
    BlueSizeSGI = 32988,

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
    AlphaSizeSGI = 32989,

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
    LuminanceSizeSGI = 32990,

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
    IntensitySizeSGI = 32991,
}
