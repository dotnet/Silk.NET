// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramInterface")]
[Transformed]
public enum ProgramInterface : uint
{
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER")]
    TransformFeedbackBuffer = unchecked((uint)0x8C8E),

    [NativeName("GL_UNIFORM")]
    Uniform = unchecked((uint)0x92E1),

    [NativeName("GL_UNIFORM_BLOCK")]
    UniformBlock = unchecked((uint)0x92E2),

    [NativeName("GL_PROGRAM_INPUT")]
    ProgramInput = unchecked((uint)0x92E3),

    [NativeName("GL_PROGRAM_OUTPUT")]
    ProgramOutput = unchecked((uint)0x92E4),

    [NativeName("GL_BUFFER_VARIABLE")]
    BufferVariable = unchecked((uint)0x92E5),

    [NativeName("GL_SHADER_STORAGE_BLOCK")]
    ShaderStorageBlock = unchecked((uint)0x92E6),

    [NativeName("GL_VERTEX_SUBROUTINE")]
    VertexSubroutine = unchecked((uint)0x92E8),

    [NativeName("GL_TESS_CONTROL_SUBROUTINE")]
    TessControlSubroutine = unchecked((uint)0x92E9),

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE")]
    TessEvaluationSubroutine = unchecked((uint)0x92EA),

    [NativeName("GL_GEOMETRY_SUBROUTINE")]
    GeometrySubroutine = unchecked((uint)0x92EB),

    [NativeName("GL_FRAGMENT_SUBROUTINE")]
    FragmentSubroutine = unchecked((uint)0x92EC),

    [NativeName("GL_COMPUTE_SUBROUTINE")]
    ComputeSubroutine = unchecked((uint)0x92ED),

    [NativeName("GL_VERTEX_SUBROUTINE_UNIFORM")]
    VertexSubroutineUniform = unchecked((uint)0x92EE),

    [NativeName("GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
    TessControlSubroutineUniform = unchecked((uint)0x92EF),

    [NativeName("GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
    TessEvaluationSubroutineUniform = unchecked((uint)0x92F0),

    [NativeName("GL_GEOMETRY_SUBROUTINE_UNIFORM")]
    GeometrySubroutineUniform = unchecked((uint)0x92F1),

    [NativeName("GL_FRAGMENT_SUBROUTINE_UNIFORM")]
    FragmentSubroutineUniform = unchecked((uint)0x92F2),

    [NativeName("GL_COMPUTE_SUBROUTINE_UNIFORM")]
    ComputeSubroutineUniform = unchecked((uint)0x92F3),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING")]
    TransformFeedbackVarying = unchecked((uint)0x92F4),
}
