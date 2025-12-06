// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramTarget")]
public enum ProgramTarget : uint
{
    [NativeName("GL_FRAGMENT_PROGRAM_ARB")]
    FragmentProgramARB = 34820,

    [NativeName("GL_VERTEX_PROGRAM_ARB")]
    VertexProgramARB = 34336,

    [NativeName("GL_TEXT_FRAGMENT_SHADER_ATI")]
    TextFragmentShaderATI = 33280,

    [NativeName("GL_COMPUTE_PROGRAM_NV")]
    ComputeProgramNV = 37115,

    [NativeName("GL_GEOMETRY_PROGRAM_NV")]
    GeometryProgramNV = 35878,

    [NativeName("GL_TESS_CONTROL_PROGRAM_NV")]
    TessControlProgramNV = 35102,

    [NativeName("GL_TESS_EVALUATION_PROGRAM_NV")]
    TessEvaluationProgramNV = 35103,
}
