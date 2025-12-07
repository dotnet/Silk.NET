// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum UniformPName : uint
{
    Type = unchecked((uint)0x8A37),
    Size = unchecked((uint)0x8A38),
    NameLength = unchecked((uint)0x8A39),
    BlockIndex = unchecked((uint)0x8A3A),
    Offset = unchecked((uint)0x8A3B),
    ArrayStride = unchecked((uint)0x8A3C),
    MatrixStride = unchecked((uint)0x8A3D),
    IsRowMajor = unchecked((uint)0x8A3E),
    AtomicCounterBufferIndex = unchecked((uint)0x92DA),
}
