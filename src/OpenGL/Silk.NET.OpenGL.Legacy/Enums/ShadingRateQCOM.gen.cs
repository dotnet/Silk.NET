// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ShadingRateQCOM")]
    public enum ShadingRateQCOM
    {
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_QCOM")]
        ShadingRate1X1PixelsQCom = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_QCOM")]
        ShadingRate1X2PixelsQCom = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_QCOM")]
        ShadingRate2X1PixelsQCom = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_QCOM")]
        ShadingRate2X2PixelsQCom = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_QCOM")]
        ShadingRate1X4PixelsQCom = 0x96AA,
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_QCOM")]
        ShadingRate4X1PixelsQCom = 0x96AB,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_QCOM")]
        ShadingRate4X2PixelsQCom = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_QCOM")]
        ShadingRate2X4PixelsQCom = 0x96AD,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_QCOM")]
        ShadingRate4X4PixelsQCom = 0x96AE,
    }
}
