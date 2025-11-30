// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramResourceProperty")]
[Transformed]
public enum ProgramResourceProperty : uint
{
    [NativeName("GL_NUM_COMPATIBLE_SUBROUTINES")]
    NumCompatibleSubroutines = unchecked((uint)0x8E4A),

    [NativeName("GL_COMPATIBLE_SUBROUTINES")]
    CompatibleSubroutines = unchecked((uint)0x8E4B),

    [NativeName("GL_UNIFORM")]
    Uniform = unchecked((uint)0x92E1),

    [NativeName("GL_NAME_LENGTH")]
    NameLength = unchecked((uint)0x92F9),

    [NativeName("GL_TYPE")]
    Type = unchecked((uint)0x92FA),

    [NativeName("GL_ARRAY_SIZE")]
    ArraySize = unchecked((uint)0x92FB),

    [NativeName("GL_OFFSET")]
    Offset = unchecked((uint)0x92FC),

    [NativeName("GL_BLOCK_INDEX")]
    BlockIndex = unchecked((uint)0x92FD),

    [NativeName("GL_ARRAY_STRIDE")]
    ArrayStride = unchecked((uint)0x92FE),

    [NativeName("GL_MATRIX_STRIDE")]
    MatrixStride = unchecked((uint)0x92FF),

    [NativeName("GL_IS_ROW_MAJOR")]
    IsRowMajor = unchecked((uint)0x9300),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = unchecked((uint)0x9301),

    [NativeName("GL_BUFFER_BINDING")]
    BufferBinding = unchecked((uint)0x9302),

    [NativeName("GL_BUFFER_DATA_SIZE")]
    BufferDataSize = unchecked((uint)0x9303),

    [NativeName("GL_NUM_ACTIVE_VARIABLES")]
    NumActiveVariables = unchecked((uint)0x9304),

    [NativeName("GL_ACTIVE_VARIABLES")]
    ActiveVariables = unchecked((uint)0x9305),

    [NativeName("GL_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = unchecked((uint)0x9306),

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = unchecked((uint)0x9307),

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = unchecked((uint)0x9308),

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = unchecked((uint)0x9309),

    [NativeName("GL_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = unchecked((uint)0x930A),

    [NativeName("GL_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = unchecked((uint)0x930B),

    [NativeName("GL_TOP_LEVEL_ARRAY_SIZE")]
    TopLevelArraySize = unchecked((uint)0x930C),

    [NativeName("GL_TOP_LEVEL_ARRAY_STRIDE")]
    TopLevelArrayStride = unchecked((uint)0x930D),

    [NativeName("GL_LOCATION")]
    Location = unchecked((uint)0x930E),

    [NativeName("GL_LOCATION_INDEX")]
    LocationIndex = unchecked((uint)0x930F),

    [NativeName("GL_IS_PER_PATCH")]
    IsPerPatch = unchecked((uint)0x92E7),

    [NativeName("GL_LOCATION_COMPONENT")]
    LocationComponent = unchecked((uint)0x934A),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
    TransformFeedbackBufferIndex = unchecked((uint)0x934B),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
    TransformFeedbackBufferStride = unchecked((uint)0x934C),
}
