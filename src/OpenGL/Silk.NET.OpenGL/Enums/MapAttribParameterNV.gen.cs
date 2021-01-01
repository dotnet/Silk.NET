// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "MapAttribParameterNV")]
    public enum MapAttribParameterNV : int
    {
        [NativeName("Name", "GL_MAP_ATTRIB_U_ORDER_NV")]
        MapAttribUOrderNV = 0x86C3,
        [NativeName("Name", "GL_MAP_ATTRIB_V_ORDER_NV")]
        MapAttribVOrderNV = 0x86C4,
    }
}
