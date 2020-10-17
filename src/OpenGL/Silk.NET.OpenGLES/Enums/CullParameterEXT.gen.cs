// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "CullParameterEXT")]
    public enum CullParameterEXT
    {
        [NativeName("Name", "GL_CULL_VERTEX_EYE_POSITION_EXT")]
        CullVertexEyePositionExt = 0x81AB,
        [NativeName("Name", "GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
        CullVertexObjectPositionExt = 0x81AC,
    }
}
