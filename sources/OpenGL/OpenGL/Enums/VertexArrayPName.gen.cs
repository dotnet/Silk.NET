// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum VertexArrayPName : uint
{
    ArrayEnabled = unchecked((uint)0x8622),
    ArraySize = unchecked((uint)0x8623),
    ArrayStride = unchecked((uint)0x8624),
    ArrayType = unchecked((uint)0x8625),
    ArrayNormalized = unchecked((uint)0x886A),
    ArrayInteger = unchecked((uint)0x88FD),
    ArrayDivisor = unchecked((uint)0x88FE),
    ArrayLong = unchecked((uint)0x874E),
    RelativeOffset = unchecked((uint)0x82D5),
}
