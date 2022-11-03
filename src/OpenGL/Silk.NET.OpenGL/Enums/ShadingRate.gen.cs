// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ShadingRate")]
    public enum ShadingRate : int
    {
        [Obsolete("Deprecated in favour of \"Rate1X1PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_EXT")]
        ShadingRate1X1PixelsExt = 0x96A6,
        [Obsolete("Deprecated in favour of \"Rate1X2PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_EXT")]
        ShadingRate1X2PixelsExt = 0x96A7,
        [Obsolete("Deprecated in favour of \"Rate2X1PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_EXT")]
        ShadingRate2X1PixelsExt = 0x96A8,
        [Obsolete("Deprecated in favour of \"Rate2X2PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_EXT")]
        ShadingRate2X2PixelsExt = 0x96A9,
        [Obsolete("Deprecated in favour of \"Rate1X4PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_EXT")]
        ShadingRate1X4PixelsExt = 0x96AA,
        [Obsolete("Deprecated in favour of \"Rate4X1PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_EXT")]
        ShadingRate4X1PixelsExt = 0x96AB,
        [Obsolete("Deprecated in favour of \"Rate4X2PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_EXT")]
        ShadingRate4X2PixelsExt = 0x96AC,
        [Obsolete("Deprecated in favour of \"Rate2X4PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_EXT")]
        ShadingRate2X4PixelsExt = 0x96AD,
        [Obsolete("Deprecated in favour of \"Rate4X4PixelsExt\"")]
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_EXT")]
        ShadingRate4X4PixelsExt = 0x96AE,
        [NativeName("Name", "GL_SHADING_RATE_1X1_PIXELS_EXT")]
        Rate1X1PixelsExt = 0x96A6,
        [NativeName("Name", "GL_SHADING_RATE_1X2_PIXELS_EXT")]
        Rate1X2PixelsExt = 0x96A7,
        [NativeName("Name", "GL_SHADING_RATE_2X1_PIXELS_EXT")]
        Rate2X1PixelsExt = 0x96A8,
        [NativeName("Name", "GL_SHADING_RATE_2X2_PIXELS_EXT")]
        Rate2X2PixelsExt = 0x96A9,
        [NativeName("Name", "GL_SHADING_RATE_1X4_PIXELS_EXT")]
        Rate1X4PixelsExt = 0x96AA,
        [NativeName("Name", "GL_SHADING_RATE_4X1_PIXELS_EXT")]
        Rate4X1PixelsExt = 0x96AB,
        [NativeName("Name", "GL_SHADING_RATE_4X2_PIXELS_EXT")]
        Rate4X2PixelsExt = 0x96AC,
        [NativeName("Name", "GL_SHADING_RATE_2X4_PIXELS_EXT")]
        Rate2X4PixelsExt = 0x96AD,
        [NativeName("Name", "GL_SHADING_RATE_4X4_PIXELS_EXT")]
        Rate4X4PixelsExt = 0x96AE,
    }
}
