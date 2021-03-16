// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureMagFilter")]
    public enum TextureMagFilter : int
    {
        [NativeName("Name", "GL_NEAREST")]
        Nearest = 0x2600,
        [NativeName("Name", "GL_LINEAR")]
        Linear = 0x2601,
        [NativeName("Name", "GL_LINEAR_DETAIL_SGIS")]
        LinearDetailSgis = 0x8097,
        [NativeName("Name", "GL_LINEAR_DETAIL_ALPHA_SGIS")]
        LinearDetailAlphaSgis = 0x8098,
        [NativeName("Name", "GL_LINEAR_DETAIL_COLOR_SGIS")]
        LinearDetailColorSgis = 0x8099,
        [NativeName("Name", "GL_LINEAR_SHARPEN_SGIS")]
        LinearSharpenSgis = 0x80AD,
        [NativeName("Name", "GL_LINEAR_SHARPEN_ALPHA_SGIS")]
        LinearSharpenAlphaSgis = 0x80AE,
        [NativeName("Name", "GL_LINEAR_SHARPEN_COLOR_SGIS")]
        LinearSharpenColorSgis = 0x80AF,
        [NativeName("Name", "GL_FILTER4_SGIS")]
        Filter4Sgis = 0x8146,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_CEILING_SGIX")]
        PixelTexGenQCeilingSgix = 0x8184,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_ROUND_SGIX")]
        PixelTexGenQRoundSgix = 0x8185,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX")]
        PixelTexGenQFloorSgix = 0x8186,
    }
}
