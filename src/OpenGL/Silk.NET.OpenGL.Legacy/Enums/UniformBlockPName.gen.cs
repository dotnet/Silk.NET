// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "UniformBlockPName")]
    public enum UniformBlockPName : int
    {
        [Obsolete("Deprecated in favour of \"ReferencedByTessControlShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
        UniformBlockReferencedByTessControlShader = 0x84F0,
        [Obsolete("Deprecated in favour of \"ReferencedByTessEvaluationShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        [Obsolete("Deprecated in favour of \"Binding\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_BINDING")]
        UniformBlockBinding = 0x8A3F,
        [Obsolete("Deprecated in favour of \"DataSize\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_DATA_SIZE")]
        UniformBlockDataSize = 0x8A40,
        [Obsolete("Deprecated in favour of \"NameLength\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_NAME_LENGTH")]
        UniformBlockNameLength = 0x8A41,
        [Obsolete("Deprecated in favour of \"ActiveUniforms\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
        UniformBlockActiveUniforms = 0x8A42,
        [Obsolete("Deprecated in favour of \"ActiveUniformIndices\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
        UniformBlockActiveUniformIndices = 0x8A43,
        [Obsolete("Deprecated in favour of \"ReferencedByVertexShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
        UniformBlockReferencedByVertexShader = 0x8A44,
        [Obsolete("Deprecated in favour of \"ReferencedByGeometryShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
        UniformBlockReferencedByGeometryShader = 0x8A45,
        [Obsolete("Deprecated in favour of \"ReferencedByFragmentShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
        UniformBlockReferencedByFragmentShader = 0x8A46,
        [Obsolete("Deprecated in favour of \"ReferencedByComputeShader\"")]
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
        UniformBlockReferencedByComputeShader = 0x90EC,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
        ReferencedByTessControlShader = 0x84F0,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        ReferencedByTessEvaluationShader = 0x84F1,
        [NativeName("Name", "GL_UNIFORM_BLOCK_BINDING")]
        Binding = 0x8A3F,
        [NativeName("Name", "GL_UNIFORM_BLOCK_DATA_SIZE")]
        DataSize = 0x8A40,
        [NativeName("Name", "GL_UNIFORM_BLOCK_NAME_LENGTH")]
        NameLength = 0x8A41,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
        ActiveUniforms = 0x8A42,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
        ActiveUniformIndices = 0x8A43,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
        ReferencedByVertexShader = 0x8A44,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
        ReferencedByGeometryShader = 0x8A45,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
        ReferencedByFragmentShader = 0x8A46,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
        ReferencedByComputeShader = 0x90EC,
    }
}
