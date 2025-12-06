// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramResourceProperty")]
public enum ProgramResourceProperty : uint
{
    [NativeName("GL_NUM_COMPATIBLE_SUBROUTINES")]
    NumCompatibleSubroutines = 36426,

    [NativeName("GL_COMPATIBLE_SUBROUTINES")]
    CompatibleSubroutines = 36427,

    [NativeName("GL_UNIFORM")]
    Uniform = 37601,

    [NativeName("GL_NAME_LENGTH")]
    NameLength = 37625,

    [NativeName("GL_TYPE")]
    Type = 37626,

    [NativeName("GL_ARRAY_SIZE")]
    ArraySize = 37627,

    [NativeName("GL_OFFSET")]
    Offset = 37628,

    [NativeName("GL_BLOCK_INDEX")]
    BlockIndex = 37629,

    [NativeName("GL_ARRAY_STRIDE")]
    ArrayStride = 37630,

    [NativeName("GL_MATRIX_STRIDE")]
    MatrixStride = 37631,

    [NativeName("GL_IS_ROW_MAJOR")]
    IsRowMajor = 37632,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_INDEX")]
    AtomicCounterBufferIndex = 37633,

    [NativeName("GL_BUFFER_BINDING")]
    BufferBinding = 37634,

    [NativeName("GL_BUFFER_DATA_SIZE")]
    BufferDataSize = 37635,

    [NativeName("GL_NUM_ACTIVE_VARIABLES")]
    NumActiveVariables = 37636,

    [NativeName("GL_ACTIVE_VARIABLES")]
    ActiveVariables = 37637,

    [NativeName("GL_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = 37638,

    [NativeName("GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = 37639,

    [NativeName("GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = 37640,

    [NativeName("GL_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = 37641,

    [NativeName("GL_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = 37642,

    [NativeName("GL_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = 37643,

    [NativeName("GL_TOP_LEVEL_ARRAY_SIZE")]
    TopLevelArraySize = 37644,

    [NativeName("GL_TOP_LEVEL_ARRAY_STRIDE")]
    TopLevelArrayStride = 37645,

    [NativeName("GL_LOCATION")]
    Location = 37646,

    [NativeName("GL_LOCATION_INDEX")]
    LocationIndex = 37647,

    [NativeName("GL_IS_PER_PATCH")]
    IsPerPatch = 37607,

    [NativeName("GL_LOCATION_COMPONENT")]
    LocationComponent = 37706,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
    TransformFeedbackBufferIndex = 37707,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
    TransformFeedbackBufferStride = 37708,
}
