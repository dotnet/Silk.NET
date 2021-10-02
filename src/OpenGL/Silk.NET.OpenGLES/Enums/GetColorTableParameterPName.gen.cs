// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "GetColorTableParameterPName")]
    public enum GetColorTableParameterPName : int
    {
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        ColorTableScale = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        ColorTableBias = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        ColorTableFormat = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        ColorTableWidth = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        ColorTableRedSize = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        ColorTableGreenSize = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        ColorTableBlueSize = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        ColorTableAlphaSize = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        ColorTableLuminanceSize = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        ColorTableIntensitySize = 0x80DF,
    }
}
