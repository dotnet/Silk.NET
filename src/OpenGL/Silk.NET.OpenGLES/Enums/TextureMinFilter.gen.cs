// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureMinFilter")]
    public enum TextureMinFilter : int
    {
        [NativeName("Name", "GL_NEAREST")]
        Nearest = 0x2600,
        [NativeName("Name", "GL_LINEAR")]
        Linear = 0x2601,
        [NativeName("Name", "GL_NEAREST_MIPMAP_NEAREST")]
        NearestMipmapNearest = 0x2700,
        [NativeName("Name", "GL_LINEAR_MIPMAP_NEAREST")]
        LinearMipmapNearest = 0x2701,
        [NativeName("Name", "GL_NEAREST_MIPMAP_LINEAR")]
        NearestMipmapLinear = 0x2702,
        [NativeName("Name", "GL_LINEAR_MIPMAP_LINEAR")]
        LinearMipmapLinear = 0x2703,
        [NativeName("Name", "GL_FILTER4_SGIS")]
        Filter4Sgis = 0x8146,
        [NativeName("Name", "GL_LINEAR_CLIPMAP_LINEAR_SGIX")]
        LinearClipmapLinearSgix = 0x8170,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_CEILING_SGIX")]
        PixelTexGenQCeilingSgix = 0x8184,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_ROUND_SGIX")]
        PixelTexGenQRoundSgix = 0x8185,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX")]
        PixelTexGenQFloorSgix = 0x8186,
        [NativeName("Name", "GL_NEAREST_CLIPMAP_NEAREST_SGIX")]
        NearestClipmapNearestSgix = 0x844D,
        [NativeName("Name", "GL_NEAREST_CLIPMAP_LINEAR_SGIX")]
        NearestClipmapLinearSgix = 0x844E,
        [NativeName("Name", "GL_LINEAR_CLIPMAP_NEAREST_SGIX")]
        LinearClipmapNearestSgix = 0x844F,
    }
}
