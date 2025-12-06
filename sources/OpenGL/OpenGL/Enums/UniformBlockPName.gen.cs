// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("UniformBlockPName")]
public enum UniformBlockPName : uint
{
    [NativeName("GL_UNIFORM_BLOCK_BINDING")]
    Binding = 35391,

    [NativeName("GL_UNIFORM_BLOCK_DATA_SIZE")]
    DataSize = 35392,

    [NativeName("GL_UNIFORM_BLOCK_NAME_LENGTH")]
    NameLength = 35393,

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
    ActiveUniforms = 35394,

    [NativeName("GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
    ActiveUniformIndices = 35395,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = 35396,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = 35397,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = 35398,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = 34032,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = 34033,

    [NativeName("GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = 37100,
}
