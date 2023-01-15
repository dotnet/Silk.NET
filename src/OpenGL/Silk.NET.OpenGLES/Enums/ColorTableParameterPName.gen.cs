// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ColorTableParameterPName")]
    public enum ColorTableParameterPName : int
    {
        [Obsolete("Deprecated in favour of \"Scale\"")]
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        ColorTableScale = 0x80D6,
        [Obsolete("Deprecated in favour of \"ScaleSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_SCALE_SGI")]
        ColorTableScaleSgi = 0x80D6,
        [Obsolete("Deprecated in favour of \"Bias\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        ColorTableBias = 0x80D7,
        [Obsolete("Deprecated in favour of \"BiasSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BIAS_SGI")]
        ColorTableBiasSgi = 0x80D7,
        [Obsolete("Deprecated in favour of \"Format\"")]
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        ColorTableFormat = 0x80D8,
        [Obsolete("Deprecated in favour of \"FormatSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT_SGI")]
        ColorTableFormatSgi = 0x80D8,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        ColorTableWidth = 0x80D9,
        [Obsolete("Deprecated in favour of \"WidthSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH_SGI")]
        ColorTableWidthSgi = 0x80D9,
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        ColorTableRedSize = 0x80DA,
        [Obsolete("Deprecated in favour of \"RedSizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE_SGI")]
        ColorTableRedSizeSgi = 0x80DA,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        ColorTableGreenSize = 0x80DB,
        [Obsolete("Deprecated in favour of \"GreenSizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE_SGI")]
        ColorTableGreenSizeSgi = 0x80DB,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        ColorTableBlueSize = 0x80DC,
        [Obsolete("Deprecated in favour of \"BlueSizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE_SGI")]
        ColorTableBlueSizeSgi = 0x80DC,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        ColorTableAlphaSize = 0x80DD,
        [Obsolete("Deprecated in favour of \"AlphaSizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
        ColorTableAlphaSizeSgi = 0x80DD,
        [Obsolete("Deprecated in favour of \"LuminanceSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        ColorTableLuminanceSize = 0x80DE,
        [Obsolete("Deprecated in favour of \"LuminanceSizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
        ColorTableLuminanceSizeSgi = 0x80DE,
        [Obsolete("Deprecated in favour of \"IntensitySize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        ColorTableIntensitySize = 0x80DF,
        [Obsolete("Deprecated in favour of \"IntensitySizeSgi\"")]
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
        ColorTableIntensitySizeSgi = 0x80DF,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        Scale = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE_SGI")]
        ScaleSgi = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        Bias = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS_SGI")]
        BiasSgi = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        Format = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT_SGI")]
        FormatSgi = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        Width = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH_SGI")]
        WidthSgi = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        RedSize = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE_SGI")]
        RedSizeSgi = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        GreenSize = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE_SGI")]
        GreenSizeSgi = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        BlueSize = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE_SGI")]
        BlueSizeSgi = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        AlphaSize = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
        AlphaSizeSgi = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        LuminanceSize = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
        LuminanceSizeSgi = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        IntensitySize = 0x80DF,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
        IntensitySizeSgi = 0x80DF,
    }
}
