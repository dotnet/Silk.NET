// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UniformPName")]
public enum UniformPName : uint
{
    [NativeName("GL_UNIFORM_TYPE")]
    Type = unchecked((uint)0x8A37),

    [NativeName("GL_UNIFORM_SIZE")]
    Size = unchecked((uint)0x8A38),

    [NativeName("GL_UNIFORM_NAME_LENGTH")]
    NameLength = unchecked((uint)0x8A39),

    [NativeName("GL_UNIFORM_BLOCK_INDEX")]
    BlockIndex = unchecked((uint)0x8A3A),

    [NativeName("GL_UNIFORM_OFFSET")]
    Offset = unchecked((uint)0x8A3B),

    [NativeName("GL_UNIFORM_ARRAY_STRIDE")]
    ArrayStride = unchecked((uint)0x8A3C),

    [NativeName("GL_UNIFORM_MATRIX_STRIDE")]
    MatrixStride = unchecked((uint)0x8A3D),

    [NativeName("GL_UNIFORM_IS_ROW_MAJOR")]
    IsRowMajor = unchecked((uint)0x8A3E),

    [NativeName("GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = unchecked((uint)0x92DA),
}
