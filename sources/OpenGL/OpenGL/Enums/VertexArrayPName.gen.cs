// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexArrayPName")]
[Transformed]
public enum VertexArrayPName : uint
{
    [NativeName("GL_VERTEX_ATTRIB_ARRAY_ENABLED")]
    ArrayEnabled = unchecked((uint)0x8622),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_SIZE")]
    ArraySize = unchecked((uint)0x8623),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_STRIDE")]
    ArrayStride = unchecked((uint)0x8624),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_TYPE")]
    ArrayType = unchecked((uint)0x8625),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_NORMALIZED")]
    ArrayNormalized = unchecked((uint)0x886A),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_INTEGER")]
    ArrayInteger = unchecked((uint)0x88FD),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_DIVISOR")]
    ArrayDivisor = unchecked((uint)0x88FE),

    [NativeName("GL_VERTEX_ATTRIB_ARRAY_LONG")]
    ArrayLong = unchecked((uint)0x874E),

    [NativeName("GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
    RelativeOffset = unchecked((uint)0x82D5),
}
