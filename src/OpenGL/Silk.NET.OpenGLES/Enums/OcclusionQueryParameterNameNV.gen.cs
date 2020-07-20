// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "OcclusionQueryParameterNameNV")]
    public enum OcclusionQueryParameterNameNV
    {
        [NativeName("Name", "GL_PIXEL_COUNT_NV")]
        PixelCountNV = 0x8866,
        [NativeName("Name", "GL_PIXEL_COUNT_AVAILABLE_NV")]
        PixelCountAvailableNV = 0x8867,
    }
}
