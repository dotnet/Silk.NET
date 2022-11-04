// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PixelTexGenModeSGIX")]
    public enum PixelTexGenModeSGIX : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
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
