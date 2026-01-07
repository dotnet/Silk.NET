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
    Type = 35383,

    [NativeName("GL_UNIFORM_SIZE")]
    Size = 35384,

    [NativeName("GL_UNIFORM_NAME_LENGTH")]
    NameLength = 35385,

    [NativeName("GL_UNIFORM_BLOCK_INDEX")]
    BlockIndex = 35386,

    [NativeName("GL_UNIFORM_OFFSET")]
    Offset = 35387,

    [NativeName("GL_UNIFORM_ARRAY_STRIDE")]
    ArrayStride = 35388,

    [NativeName("GL_UNIFORM_MATRIX_STRIDE")]
    MatrixStride = 35389,

    [NativeName("GL_UNIFORM_IS_ROW_MAJOR")]
    IsRowMajor = 35390,

    [NativeName("GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = 37594,
}
