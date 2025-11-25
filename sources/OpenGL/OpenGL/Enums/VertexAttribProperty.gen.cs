// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexAttribProperty : uint
{
    VertexAttribArrayBufferBinding = unchecked((uint)0x889F),
    VertexAttribArrayEnabled = unchecked((uint)0x8622),
    VertexAttribArraySize = unchecked((uint)0x8623),
    VertexAttribArrayStride = unchecked((uint)0x8624),
    VertexAttribArrayType = unchecked((uint)0x8625),
    CurrentVertexAttrib = unchecked((uint)0x8626),
    VertexAttribArrayNormalized = unchecked((uint)0x886A),
    VertexAttribArrayInteger = unchecked((uint)0x88FD),
    VertexAttribArrayDivisor = unchecked((uint)0x88FE),
    VertexAttribArrayLong = unchecked((uint)0x874E),
    VertexAttribBinding = unchecked((uint)0x82D4),
    VertexAttribRelativeOffset = unchecked((uint)0x82D5),
    VertexAttribArrayIntegerEXT = unchecked((uint)0x88FD),
}
