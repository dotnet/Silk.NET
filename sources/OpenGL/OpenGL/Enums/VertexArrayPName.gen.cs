// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexArrayPName")]
public enum VertexArrayPName : uint
{
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
    ArrayEnabled = 34338,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE")]
    ArraySize = 34339,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
    ArrayStride = 34340,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE")]
    ArrayType = 34341,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
    ArrayNormalized = 34922,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
    ArrayInteger = 35069,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
    ArrayDivisor = 35070,

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LONG")]
    ArrayLong = 34638,

    [NativeName("GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    RelativeOffset = 33493,
}
