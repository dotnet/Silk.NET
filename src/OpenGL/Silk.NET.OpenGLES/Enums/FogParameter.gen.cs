// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FogParameter")]
    public enum FogParameter : int
    {
        [NativeName("Name", "GL_FOG_INDEX")]
        FogIndex = 0xB61,
        [NativeName("Name", "GL_FOG_DENSITY")]
        FogDensity = 0xB62,
        [NativeName("Name", "GL_FOG_START")]
        FogStart = 0xB63,
        [NativeName("Name", "GL_FOG_END")]
        FogEnd = 0xB64,
        [NativeName("Name", "GL_FOG_MODE")]
        FogMode = 0xB65,
        [NativeName("Name", "GL_FOG_COLOR")]
        FogColor = 0xB66,
        [NativeName("Name", "GL_FOG_OFFSET_VALUE_SGIX")]
        FogOffsetValueSgix = 0x8199,
    }
}
