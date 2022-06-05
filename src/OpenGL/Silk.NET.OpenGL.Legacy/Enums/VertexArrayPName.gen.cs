// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "VertexArrayPName")]
    public enum VertexArrayPName : int
    {
        [Obsolete("Deprecated in favour of \"RelativeOffset\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        VertexAttribRelativeOffset = 0x82D5,
        [Obsolete("Deprecated in favour of \"ArrayEnabled\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
        VertexAttribArrayEnabled = 0x8622,
        [Obsolete("Deprecated in favour of \"ArraySize\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_SIZE")]
        VertexAttribArraySize = 0x8623,
        [Obsolete("Deprecated in favour of \"ArrayStride\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
        VertexAttribArrayStride = 0x8624,
        [Obsolete("Deprecated in favour of \"ArrayType\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_TYPE")]
        VertexAttribArrayType = 0x8625,
        [Obsolete("Deprecated in favour of \"ArrayLong\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_LONG")]
        VertexAttribArrayLong = 0x874E,
        [Obsolete("Deprecated in favour of \"ArrayNormalized\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
        VertexAttribArrayNormalized = 0x886A,
        [Obsolete("Deprecated in favour of \"ArrayInteger\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
        VertexAttribArrayInteger = 0x88FD,
        [Obsolete("Deprecated in favour of \"ArrayDivisor\"")]
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
        VertexAttribArrayDivisor = 0x88FE,
        [NativeName("Name", "GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        RelativeOffset = 0x82D5,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
        ArrayEnabled = 0x8622,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_SIZE")]
        ArraySize = 0x8623,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
        ArrayStride = 0x8624,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_TYPE")]
        ArrayType = 0x8625,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_LONG")]
        ArrayLong = 0x874E,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
        ArrayNormalized = 0x886A,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
        ArrayInteger = 0x88FD,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
        ArrayDivisor = 0x88FE,
    }
}
