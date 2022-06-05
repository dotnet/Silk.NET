// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ShadingRateQCOM")]
    public enum ShadingRateQCOM : int
    {
        [Obsolete("Deprecated in favour of \"Rate1X1PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_QCOM")]
        ShadingRate1X1PixelsQCom = 0x96A6,
        [Obsolete("Deprecated in favour of \"Rate1X2PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_QCOM")]
        ShadingRate1X2PixelsQCom = 0x96A7,
        [Obsolete("Deprecated in favour of \"Rate2X1PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_QCOM")]
        ShadingRate2X1PixelsQCom = 0x96A8,
        [Obsolete("Deprecated in favour of \"Rate2X2PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_QCOM")]
        ShadingRate2X2PixelsQCom = 0x96A9,
        [Obsolete("Deprecated in favour of \"Rate1X4PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_QCOM")]
        ShadingRate1X4PixelsQCom = 0x96AA,
        [Obsolete("Deprecated in favour of \"Rate4X1PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_QCOM")]
        ShadingRate4X1PixelsQCom = 0x96AB,
        [Obsolete("Deprecated in favour of \"Rate4X2PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_QCOM")]
        ShadingRate4X2PixelsQCom = 0x96AC,
        [Obsolete("Deprecated in favour of \"Rate2X4PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_QCOM")]
        ShadingRate2X4PixelsQCom = 0x96AD,
        [Obsolete("Deprecated in favour of \"Rate4X4PixelsQCom\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_QCOM")]
        ShadingRate4X4PixelsQCom = 0x96AE,
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_QCOM")]
        Rate1X1PixelsQCom = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_QCOM")]
        Rate1X2PixelsQCom = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_QCOM")]
        Rate2X1PixelsQCom = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_QCOM")]
        Rate2X2PixelsQCom = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_QCOM")]
        Rate1X4PixelsQCom = 0x96AA,
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_QCOM")]
        Rate4X1PixelsQCom = 0x96AB,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_QCOM")]
        Rate4X2PixelsQCom = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_QCOM")]
        Rate2X4PixelsQCom = 0x96AD,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_QCOM")]
        Rate4X4PixelsQCom = 0x96AE,
    }
}
