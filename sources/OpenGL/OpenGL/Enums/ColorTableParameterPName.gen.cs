// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ColorTableParameterPName")]
[Transformed]
public enum ColorTableParameterPName : uint
{
    [NativeName("GL_COLOR_TABLE_SCALE")]
    Scale = unchecked((uint)0x80D6),

    [NativeName("GL_COLOR_TABLE_BIAS")]
    Bias = unchecked((uint)0x80D7),

    [NativeName("GL_COLOR_TABLE_FORMAT")]
    Format = unchecked((uint)0x80D8),

    [NativeName("GL_COLOR_TABLE_WIDTH")]
    Width = unchecked((uint)0x80D9),

    [NativeName("GL_COLOR_TABLE_RED_SIZE")]
    RedSize = unchecked((uint)0x80DA),

    [NativeName("GL_COLOR_TABLE_GREEN_SIZE")]
    GreenSize = unchecked((uint)0x80DB),

    [NativeName("GL_COLOR_TABLE_BLUE_SIZE")]
    BlueSize = unchecked((uint)0x80DC),

    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE")]
    AlphaSize = unchecked((uint)0x80DD),

    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE")]
    LuminanceSize = unchecked((uint)0x80DE),

    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE")]
    IntensitySize = unchecked((uint)0x80DF),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_SCALE_SGI")]
    Scalesgi = unchecked((uint)0x80D6),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_BIAS_SGI")]
    Biassgi = unchecked((uint)0x80D7),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_FORMAT_SGI")]
    Formatsgi = unchecked((uint)0x80D8),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_WIDTH_SGI")]
    Widthsgi = unchecked((uint)0x80D9),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_RED_SIZE_SGI")]
    RedSizesgi = unchecked((uint)0x80DA),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_GREEN_SIZE_SGI")]
    GreenSizesgi = unchecked((uint)0x80DB),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_BLUE_SIZE_SGI")]
    BlueSizesgi = unchecked((uint)0x80DC),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
    AlphaSizesgi = unchecked((uint)0x80DD),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
    LuminanceSizesgi = unchecked((uint)0x80DE),

    [NameAffix("Suffix", "SGI", 0)]
    [NativeName("GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
    IntensitySizesgi = unchecked((uint)0x80DF),
}
