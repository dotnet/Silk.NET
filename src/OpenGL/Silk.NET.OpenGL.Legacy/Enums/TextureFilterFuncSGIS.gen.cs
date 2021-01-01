// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureFilterFuncSGIS")]
    public enum TextureFilterFuncSGIS : int
    {
        [NativeName("Name", "GL_FILTER4_SGIS")]
        Filter4Sgis = 0x8146,
    }
}
