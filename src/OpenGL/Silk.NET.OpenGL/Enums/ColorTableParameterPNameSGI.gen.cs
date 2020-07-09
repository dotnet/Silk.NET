// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ColorTableParameterPNameSGI")]
    public enum ColorTableParameterPNameSGI
    {
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        ColorTableScale = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE_SGI")]
        ColorTableScaleSgi = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        ColorTableBias = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS_SGI")]
        ColorTableBiasSgi = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        ColorTableFormat = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT_SGI")]
        ColorTableFormatSgi = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        ColorTableWidth = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH_SGI")]
        ColorTableWidthSgi = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        ColorTableRedSize = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE_SGI")]
        ColorTableRedSizeSgi = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        ColorTableGreenSize = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE_SGI")]
        ColorTableGreenSizeSgi = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        ColorTableBlueSize = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE_SGI")]
        ColorTableBlueSizeSgi = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        ColorTableAlphaSize = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE_SGI")]
        ColorTableAlphaSizeSgi = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        ColorTableLuminanceSize = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE_SGI")]
        ColorTableLuminanceSizeSgi = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        ColorTableIntensitySize = 0x80DF,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE_SGI")]
        ColorTableIntensitySizeSgi = 0x80DF,
    }
}
