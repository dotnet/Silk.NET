// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureWrapMode")]
    public enum TextureWrapMode
    {
        [NativeName("Name", "GL_LINEAR_MIPMAP_LINEAR")]
        LinearMipmapLinear = 0x2703,
        [NativeName("Name", "GL_REPEAT")]
        Repeat = 0x2901,
        [NativeName("Name", "GL_CLAMP_TO_BORDER")]
        ClampToBorder = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_ARB")]
        ClampToBorderArb = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_NV")]
        ClampToBorderNV = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_SGIS")]
        ClampToBorderSgis = 0x812D,
        [NativeName("Name", "GL_CLAMP_TO_EDGE")]
        ClampToEdge = 0x812F,
        [NativeName("Name", "GL_CLAMP_TO_EDGE_SGIS")]
        ClampToEdgeSgis = 0x812F,
        [NativeName("Name", "GL_MIRRORED_REPEAT")]
        MirroredRepeat = 0x8370,
    }
}
