// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexAttribProperty : uint
{
    VertexAttribArrayBufferBinding = 0x889F,
    VertexAttribArrayEnabled = 0x8622,
    VertexAttribArraySize = 0x8623,
    VertexAttribArrayStride = 0x8624,
    VertexAttribArrayType = 0x8625,
    CurrentVertexAttrib = 0x8626,
    VertexAttribArrayNormalized = 0x886A,
    VertexAttribArrayInteger = 0x88FD,
    VertexAttribArrayDivisor = 0x88FE,
    VertexAttribArrayLong = 0x874E,
    VertexAttribBinding = 0x82D4,
    VertexAttribRelativeOffset = 0x82D5,
    VertexAttribArrayIntegerEXT = 0x88FD
}
