// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelTexGenModeSGIX")]
    public enum PixelTexGenModeSGIX : int
    {
        [Obsolete("Deprecated in favour of \"QCeilingSgix\"")]
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_CEILING_SGIX")]
        PixelTexGenQCeilingSgix = 0x8184,
        [Obsolete("Deprecated in favour of \"QRoundSgix\"")]
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_ROUND_SGIX")]
        PixelTexGenQRoundSgix = 0x8185,
        [Obsolete("Deprecated in favour of \"QFloorSgix\"")]
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX")]
        PixelTexGenQFloorSgix = 0x8186,
        [Obsolete("Deprecated in favour of \"AlphaLSSgix\"")]
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX")]
        PixelTexGenAlphaLSSgix = 0x8189,
        [Obsolete("Deprecated in favour of \"AlphaMSSgix\"")]
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX")]
        PixelTexGenAlphaMSSgix = 0x818A,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_CEILING_SGIX")]
        QCeilingSgix = 0x8184,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_ROUND_SGIX")]
        QRoundSgix = 0x8185,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX")]
        QFloorSgix = 0x8186,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX")]
        AlphaLSSgix = 0x8189,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX")]
        AlphaMSSgix = 0x818A,
    }
}
