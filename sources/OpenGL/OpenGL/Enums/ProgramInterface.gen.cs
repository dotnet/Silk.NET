// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramInterface : uint
{
    TransformFeedbackBuffer = unchecked((uint)0x8C8E),
    Uniform = unchecked((uint)0x92E1),
    UniformBlock = unchecked((uint)0x92E2),
    ProgramInput = unchecked((uint)0x92E3),
    ProgramOutput = unchecked((uint)0x92E4),
    BufferVariable = unchecked((uint)0x92E5),
    ShaderStorageBlock = unchecked((uint)0x92E6),
    VertexSubroutine = unchecked((uint)0x92E8),
    TessControlSubroutine = unchecked((uint)0x92E9),
    TessEvaluationSubroutine = unchecked((uint)0x92EA),
    GeometrySubroutine = unchecked((uint)0x92EB),
    FragmentSubroutine = unchecked((uint)0x92EC),
    ComputeSubroutine = unchecked((uint)0x92ED),
    VertexSubroutineUniform = unchecked((uint)0x92EE),
    TessControlSubroutineUniform = unchecked((uint)0x92EF),
    TessEvaluationSubroutineUniform = unchecked((uint)0x92F0),
    GeometrySubroutineUniform = unchecked((uint)0x92F1),
    FragmentSubroutineUniform = unchecked((uint)0x92F2),
    ComputeSubroutineUniform = unchecked((uint)0x92F3),
    TransformFeedbackVarying = unchecked((uint)0x92F4),
}
