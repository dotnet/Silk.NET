// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum ProgramResourceProperty
{
    NumCompatibleSubroutines = 0x8E4A,
    CompatibleSubroutines = 0x8E4B,
    Uniform = 0x92E1,
    NameLength = 0x92F9,
    TYPE = 0x92FA,
    ArraySize = 0x92FB,
    Offset = 0x92FC,
    BlockIndex = 0x92FD,
    ArrayStride = 0x92FE,
    MatrixStride = 0x92FF,
    IsRowMajor = 0x9300,
    AtomicCounterBufferIndex = 0x9301,
    BufferBinding = 0x9302,
    BufferDataSize = 0x9303,
    NumActiveVariables = 0x9304,
    ActiveVariables = 0x9305,
    ReferencedByVertexShader = 0x9306,
    ReferencedByTessControlShader = 0x9307,
    ReferencedByTessEvaluationShader = 0x9308,
    ReferencedByGeometryShader = 0x9309,
    ReferencedByFragmentShader = 0x930A,
    ReferencedByComputeShader = 0x930B,
    TopLevelArraySize = 0x930C,
    TopLevelArrayStride = 0x930D,
    Location = 0x930E,
    LocationIndex = 0x930F,
    IsPerPatch = 0x92E7,
    LocationComponent = 0x934A,
    TransformFeedbackBufferIndex = 0x934B,
    TransformFeedbackBufferStride = 0x934C
}
