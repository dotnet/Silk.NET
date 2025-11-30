// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UniformBlockPName")]
[Transformed]
public enum UniformBlockPName : uint
{
    [NativeName("GL_UNIFORM_BLOCK_BINDING")]
    Binding = unchecked((uint)0x8A3F),

    [NativeName("GL_UNIFORM_BLOCK_DATA_SIZE")]
    DataSize = unchecked((uint)0x8A40),

    [NativeName("GL_UNIFORM_BLOCK_NAME_LENGTH")]
    NameLength = unchecked((uint)0x8A41),

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
    ActiveUniforms = unchecked((uint)0x8A42),

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
    ActiveUniformIndices = unchecked((uint)0x8A43),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = unchecked((uint)0x8A44),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = unchecked((uint)0x8A45),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = unchecked((uint)0x8A46),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = unchecked((uint)0x84F0),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = unchecked((uint)0x84F1),

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = unchecked((uint)0x90EC),
}
