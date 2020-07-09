// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexProvokingMode")]
    public enum VertexProvokingMode
    {
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION")]
        FirstVertexConvention = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION")]
        LastVertexConvention = 0x8E4E,
    }
}
