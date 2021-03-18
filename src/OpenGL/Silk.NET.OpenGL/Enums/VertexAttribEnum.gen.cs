// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "VertexAttribEnum")]
    public enum VertexAttribEnum : int
    {
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
        VertexAttribArrayEnabled = 0x8622,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_SIZE")]
        VertexAttribArraySize = 0x8623,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
        VertexAttribArrayStride = 0x8624,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_TYPE")]
        VertexAttribArrayType = 0x8625,
        [NativeName("Name", "GL_CURRENT_VERTEX_ATTRIB")]
        CurrentVertexAttrib = 0x8626,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
        VertexAttribArrayNormalized = 0x886A,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
        VertexAttribArrayBufferBinding = 0x889F,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
        VertexAttribArrayInteger = 0x88FD,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
        VertexAttribArrayDivisor = 0x88FE,
    }
}
