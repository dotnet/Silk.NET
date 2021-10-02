// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "UniformBlockPName")]
    public enum UniformBlockPName : int
    {
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
        UniformBlockReferencedByTessControlShader = 0x84F0,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        [NativeName("Name", "GL_UNIFORM_BLOCK_BINDING")]
        UniformBlockBinding = 0x8A3F,
        [NativeName("Name", "GL_UNIFORM_BLOCK_DATA_SIZE")]
        UniformBlockDataSize = 0x8A40,
        [NativeName("Name", "GL_UNIFORM_BLOCK_NAME_LENGTH")]
        UniformBlockNameLength = 0x8A41,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
        UniformBlockActiveUniforms = 0x8A42,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
        UniformBlockActiveUniformIndices = 0x8A43,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
        UniformBlockReferencedByVertexShader = 0x8A44,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
        UniformBlockReferencedByGeometryShader = 0x8A45,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
        UniformBlockReferencedByFragmentShader = 0x8A46,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
        UniformBlockReferencedByComputeShader = 0x90EC,
    }
}
