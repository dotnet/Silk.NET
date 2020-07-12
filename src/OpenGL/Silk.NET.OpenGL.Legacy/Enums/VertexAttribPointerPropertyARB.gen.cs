// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexAttribPointerPropertyARB")]
    public enum VertexAttribPointerPropertyARB
    {
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER")]
        VertexAttribArrayPointer = 0x8645,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
        VertexAttribArrayPointerArb = 0x8645,
    }
}
