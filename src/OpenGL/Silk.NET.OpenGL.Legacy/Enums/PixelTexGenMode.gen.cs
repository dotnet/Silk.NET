// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelTexGenMode")]
    public enum PixelTexGenMode
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
        [NativeName("Name", "GL_LUMINANCE")]
        Luminance = 0x1909,
        [NativeName("Name", "GL_LUMINANCE_ALPHA")]
        LuminanceAlpha = 0x190A,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_REPLACE_SGIX")]
        PixelTexGenAlphaReplaceSgix = 0x8187,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_NO_REPLACE_SGIX")]
        PixelTexGenAlphaNoReplaceSgix = 0x8188,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX")]
        PixelTexGenAlphaLSSgix = 0x8189,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX")]
        PixelTexGenAlphaMSSgix = 0x818A,
    }
}
