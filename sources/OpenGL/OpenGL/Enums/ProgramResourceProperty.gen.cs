// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramResourceProperty : uint
{
    NumCompatibleSubroutines = unchecked((uint)0x8E4A),
    CompatibleSubroutines = unchecked((uint)0x8E4B),
    Uniform = unchecked((uint)0x92E1),
    NameLength = unchecked((uint)0x92F9),
    Type = unchecked((uint)0x92FA),
    ArraySize = unchecked((uint)0x92FB),
    Offset = unchecked((uint)0x92FC),
    BlockIndex = unchecked((uint)0x92FD),
    ArrayStride = unchecked((uint)0x92FE),
    MatrixStride = unchecked((uint)0x92FF),
    IsRowMajor = unchecked((uint)0x9300),
    AtomicCounterBufferIndex = unchecked((uint)0x9301),
    BufferBinding = unchecked((uint)0x9302),
    BufferDataSize = unchecked((uint)0x9303),
    NumActiveVariables = unchecked((uint)0x9304),
    ActiveVariables = unchecked((uint)0x9305),
    ReferencedByVertexShader = unchecked((uint)0x9306),
    ReferencedByTessControlShader = unchecked((uint)0x9307),
    ReferencedByTessEvaluationShader = unchecked((uint)0x9308),
    ReferencedByGeometryShader = unchecked((uint)0x9309),
    ReferencedByFragmentShader = unchecked((uint)0x930A),
    ReferencedByComputeShader = unchecked((uint)0x930B),
    TopLevelArraySize = unchecked((uint)0x930C),
    TopLevelArrayStride = unchecked((uint)0x930D),
    Location = unchecked((uint)0x930E),
    LocationIndex = unchecked((uint)0x930F),
    IsPerPatch = unchecked((uint)0x92E7),
    LocationComponent = unchecked((uint)0x934A),
    TransformFeedbackBufferIndex = unchecked((uint)0x934B),
    TransformFeedbackBufferStride = unchecked((uint)0x934C),
}
