// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "UniformPName")]
    public enum UniformPName : int
    {
        [NativeName("Name", "GL_UNIFORM_TYPE")]
        UniformType = 0x8A37,
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [NativeName("Name", "GL_UNIFORM_BLOCK_INDEX")]
        UniformBlockIndex = 0x8A3A,
        [NativeName("Name", "GL_UNIFORM_OFFSET")]
        UniformOffset = 0x8A3B,
        [NativeName("Name", "GL_UNIFORM_ARRAY_STRIDE")]
        UniformArrayStride = 0x8A3C,
        [NativeName("Name", "GL_UNIFORM_MATRIX_STRIDE")]
        UniformMatrixStride = 0x8A3D,
        [NativeName("Name", "GL_UNIFORM_IS_ROW_MAJOR")]
        UniformIsRowMajor = 0x8A3E,
        [NativeName("Name", "GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
        UniformAtomicCounterBufferIndex = 0x92DA,
    }
}
