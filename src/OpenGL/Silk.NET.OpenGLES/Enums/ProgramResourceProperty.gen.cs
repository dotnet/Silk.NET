// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ProgramResourceProperty")]
    public enum ProgramResourceProperty : int
    {
        [NativeName("Name", "GL_NUM_COMPATIBLE_SUBROUTINES")]
        NumCompatibleSubroutines = 0x8E4A,
        [NativeName("Name", "GL_COMPATIBLE_SUBROUTINES")]
        CompatibleSubroutines = 0x8E4B,
        [NativeName("Name", "GL_UNIFORM")]
        Uniform = 0x92E1,
        [NativeName("Name", "GL_IS_PER_PATCH")]
        IsPerPatch = 0x92E7,
        [NativeName("Name", "GL_NAME_LENGTH")]
        NameLength = 0x92F9,
        [NativeName("Name", "GL_TYPE")]
        Type = 0x92FA,
        [NativeName("Name", "GL_ARRAY_SIZE")]
        ArraySize = 0x92FB,
        [NativeName("Name", "GL_OFFSET")]
        Offset = 0x92FC,
        [NativeName("Name", "GL_BLOCK_INDEX")]
        BlockIndex = 0x92FD,
        [NativeName("Name", "GL_ARRAY_STRIDE")]
        ArrayStride = 0x92FE,
        [NativeName("Name", "GL_MATRIX_STRIDE")]
        MatrixStride = 0x92FF,
        [NativeName("Name", "GL_IS_ROW_MAJOR")]
        IsRowMajor = 0x9300,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_INDEX")]
        AtomicCounterBufferIndex = 0x9301,
        [NativeName("Name", "GL_BUFFER_BINDING")]
        BufferBinding = 0x9302,
        [NativeName("Name", "GL_BUFFER_DATA_SIZE")]
        BufferDataSize = 0x9303,
        [NativeName("Name", "GL_NUM_ACTIVE_VARIABLES")]
        NumActiveVariables = 0x9304,
        [NativeName("Name", "GL_ACTIVE_VARIABLES")]
        ActiveVariables = 0x9305,
        [NativeName("Name", "GL_REFERENCED_BY_VERTEX_SHADER")]
        ReferencedByVertexShader = 0x9306,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
        ReferencedByTessControlShader = 0x9307,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        ReferencedByTessEvaluationShader = 0x9308,
        [NativeName("Name", "GL_REFERENCED_BY_GEOMETRY_SHADER")]
        ReferencedByGeometryShader = 0x9309,
        [NativeName("Name", "GL_REFERENCED_BY_FRAGMENT_SHADER")]
        ReferencedByFragmentShader = 0x930A,
        [NativeName("Name", "GL_REFERENCED_BY_COMPUTE_SHADER")]
        ReferencedByComputeShader = 0x930B,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_SIZE")]
        TopLevelArraySize = 0x930C,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_STRIDE")]
        TopLevelArrayStride = 0x930D,
        [NativeName("Name", "GL_LOCATION")]
        Location = 0x930E,
        [NativeName("Name", "GL_LOCATION_INDEX")]
        LocationIndex = 0x930F,
        [NativeName("Name", "GL_LOCATION_COMPONENT")]
        LocationComponent = 0x934A,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
        TransformFeedbackBufferIndex = 0x934B,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
        TransformFeedbackBufferStride = 0x934C,
    }
}
