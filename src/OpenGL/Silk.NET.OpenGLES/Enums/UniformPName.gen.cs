// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "UniformPName")]
    public enum UniformPName : int
    {
        [Obsolete("Deprecated in favour of \"Type\"")]
        [NativeName("Name", "GL_UNIFORM_TYPE")]
        UniformType = 0x8A37,
        [Obsolete("Deprecated in favour of \"Size\"")]
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [Obsolete("Deprecated in favour of \"NameLength\"")]
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [Obsolete("Deprecated in favour of \"BlockIndex\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_INDEX")]
        UniformBlockIndex = 0x8A3A,
        [Obsolete("Deprecated in favour of \"Offset\"")]
        [NativeName("Name", "GL_UNIFORM_OFFSET")]
        UniformOffset = 0x8A3B,
        [Obsolete("Deprecated in favour of \"ArrayStride\"")]
        [NativeName("Name", "GL_UNIFORM_ARRAY_STRIDE")]
        UniformArrayStride = 0x8A3C,
        [Obsolete("Deprecated in favour of \"MatrixStride\"")]
        [NativeName("Name", "GL_UNIFORM_MATRIX_STRIDE")]
        UniformMatrixStride = 0x8A3D,
        [Obsolete("Deprecated in favour of \"IsRowMajor\"")]
        [NativeName("Name", "GL_UNIFORM_IS_ROW_MAJOR")]
        UniformIsRowMajor = 0x8A3E,
        [Obsolete("Deprecated in favour of \"AtomicCounterBufferIndex\"")]
        [NativeName("Name", "GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
        UniformAtomicCounterBufferIndex = 0x92DA,
        [NativeName("Name", "GL_UNIFORM_TYPE")]
        Type = 0x8A37,
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        Size = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        NameLength = 0x8A39,
        [NativeName("Name", "GL_UNIFORM_BLOCK_INDEX")]
        BlockIndex = 0x8A3A,
        [NativeName("Name", "GL_UNIFORM_OFFSET")]
        Offset = 0x8A3B,
        [NativeName("Name", "GL_UNIFORM_ARRAY_STRIDE")]
        ArrayStride = 0x8A3C,
        [NativeName("Name", "GL_UNIFORM_MATRIX_STRIDE")]
        MatrixStride = 0x8A3D,
        [NativeName("Name", "GL_UNIFORM_IS_ROW_MAJOR")]
        IsRowMajor = 0x8A3E,
        [NativeName("Name", "GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
        AtomicCounterBufferIndex = 0x92DA,
    }
}
