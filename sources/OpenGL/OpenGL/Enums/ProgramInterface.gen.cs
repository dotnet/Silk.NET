// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramInterface")]
public enum ProgramInterface : uint
{
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = 35982,

    [NativeName("GL_UNIFORM")]
    Uniform = 37601,

    [NativeName("GL_UNIFORM_BLOCK")]
    UniformBlock = 37602,

    [NativeName("GL_PROGRAM_INPUT")]
    ProgramInput = 37603,

    [NativeName("GL_PROGRAM_OUTPUT")]
    ProgramOutput = 37604,

    [NativeName("GL_BUFFER_VARIABLE")]
    BufferVariable = 37605,

    [NativeName("GL_SHADER_STORAGE_BLOCK")]
    ShaderStorageBlock = 37606,

    [NativeName("GL_VERTEX_SUBROUTINE")]
    VertexSubroutine = 37608,

    [NativeName("GL_TESS_CONTROL_SUBROUTINE")]
    TessControlSubroutine = 37609,

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE")]
    TessEvaluationSubroutine = 37610,

    [NativeName("GL_GEOMETRY_SUBROUTINE")]
    GeometrySubroutine = 37611,

    [NativeName("GL_FRAGMENT_SUBROUTINE")]
    FragmentSubroutine = 37612,

    [NativeName("GL_COMPUTE_SUBROUTINE")]
    ComputeSubroutine = 37613,

    [NativeName("GL_VERTEX_SUBROUTINE_UNIFORM")]
    VertexSubroutineUniform = 37614,

    [NativeName("GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
    TessControlSubroutineUniform = 37615,

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
    TessEvaluationSubroutineUniform = 37616,

    [NativeName("GL_GEOMETRY_SUBROUTINE_UNIFORM")]
    GeometrySubroutineUniform = 37617,

    [NativeName("GL_FRAGMENT_SUBROUTINE_UNIFORM")]
    FragmentSubroutineUniform = 37618,

    [NativeName("GL_COMPUTE_SUBROUTINE_UNIFORM")]
    ComputeSubroutineUniform = 37619,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING")]
    TransformFeedbackVarying = 37620,
}
