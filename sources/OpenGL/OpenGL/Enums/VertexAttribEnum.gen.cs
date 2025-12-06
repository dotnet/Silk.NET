// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexAttribEnum")]
public enum VertexAttribEnum : uint
{
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING")]
    VertexAttribArrayBufferBinding = 34975,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
    VertexAttribArrayEnabled = 34338,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE")]
    VertexAttribArraySize = 34339,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
    VertexAttribArrayStride = 34340,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE")]
    VertexAttribArrayType = 34341,

    [NativeName("GL_CURRENT_VERTEX_ATTRIB")]
    CurrentVertexAttrib = 34342,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
    VertexAttribArrayNormalized = 34922,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
    VertexAttribArrayInteger = 35069,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
    VertexAttribArrayDivisor = 35070,
}
