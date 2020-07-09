// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PixelTexGenModeSGIX")]
    public enum PixelTexGenModeSGIX
    {
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_CEILING_SGIX")]
        PixelTexGenQCeilingSgix = 0x8184,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_ROUND_SGIX")]
        PixelTexGenQRoundSgix = 0x8185,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX")]
        PixelTexGenQFloorSgix = 0x8186,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX")]
        PixelTexGenAlphaLSSgix = 0x8189,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX")]
        PixelTexGenAlphaMSSgix = 0x818A,
    }
}
