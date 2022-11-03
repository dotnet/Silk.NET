// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ColorTableParameterPName")]
    public enum ColorTableParameterPName : int
    {
        [Obsolete("Deprecated in favour of \"Scale\"")]
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        ColorTableScale = 0x80D6,
        [Obsolete("Deprecated in favour of \"Bias\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        ColorTableBias = 0x80D7,
        [Obsolete("Deprecated in favour of \"Format\"")]
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        ColorTableFormat = 0x80D8,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        ColorTableWidth = 0x80D9,
        [Obsolete("Deprecated in favour of \"RedSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        ColorTableRedSize = 0x80DA,
        [Obsolete("Deprecated in favour of \"GreenSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        ColorTableGreenSize = 0x80DB,
        [Obsolete("Deprecated in favour of \"BlueSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        ColorTableBlueSize = 0x80DC,
        [Obsolete("Deprecated in favour of \"AlphaSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        ColorTableAlphaSize = 0x80DD,
        [Obsolete("Deprecated in favour of \"LuminanceSize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        ColorTableLuminanceSize = 0x80DE,
        [Obsolete("Deprecated in favour of \"IntensitySize\"")]
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        ColorTableIntensitySize = 0x80DF,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        Scale = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        Bias = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        Format = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        Width = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        RedSize = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        GreenSize = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        BlueSize = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        AlphaSize = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        LuminanceSize = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        IntensitySize = 0x80DF,
    }
}
