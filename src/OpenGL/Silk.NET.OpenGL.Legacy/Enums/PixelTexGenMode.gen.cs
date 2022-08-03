// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "PixelTexGenMode")]
    public enum PixelTexGenMode : int
    {
        [NativeName("Name", "GL_RGB")]
        Rgb = 0x1907,
        [NativeName("Name", "GL_RGBA")]
        Rgba = 0x1908,
        [System.Obsolete]
        [NativeName("Name", "GL_LUMINANCE")]
        Luminance = 0x1909,
        [System.Obsolete]
        [NativeName("Name", "GL_LUMINANCE_ALPHA")]
        LuminanceAlpha = 0x190A,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_LS_SGIX")]
        PixelTexGenAlphaLSSgix = 0x8189,
        [NativeName("Name", "GL_PIXEL_TEX_GEN_ALPHA_MS_SGIX")]
        PixelTexGenAlphaMSSgix = 0x818A,
    }
}
