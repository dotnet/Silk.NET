// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramPropertyARB")]
public enum ProgramProperty : uint
{
    [NativeName("GL_DELETE_STATUS")]
    DeleteStatus = 35712,

    [NativeName("GL_LINK_STATUS")]
    LinkStatus = 35714,

    [NativeName("GL_VALIDATE_STATUS")]
    ValidateStatus = 35715,

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = 35716,

    [NativeName("GL_ATTACHED_SHADERS")]
    AttachedShaders = 35717,

    [NativeName("GL_ACTIVE_UNIFORMS")]
    ActiveUniforms = 35718,

    [NativeName("GL_ACTIVE_UNIFORM_MAX_LENGTH")]
    ActiveUniformMaxLength = 35719,

    [NativeName("GL_ACTIVE_ATTRIBUTES")]
    ActiveAttributes = 35721,

    [NativeName("GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
    ActiveAttributeMaxLength = 35722,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
    TransformFeedbackVaryingMaxLength = 35958,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
    TransformFeedbackBufferMode = 35967,

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS")]
    TransformFeedbackVaryings = 35971,

    [NativeName("GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
    ActiveUniformBlockMaxNameLength = 35381,

    [NativeName("GL_ACTIVE_UNIFORM_BLOCKS")]
    ActiveUniformBlocks = 35382,

    [NativeName("GL_GEOMETRY_VERTICES_OUT")]
    GeometryVerticesOut = 35094,

    [NativeName("GL_GEOMETRY_INPUT_TYPE")]
    GeometryInputType = 35095,

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE")]
    GeometryOutputType = 35096,

    [NativeName("GL_PROGRAM_BINARY_LENGTH")]
    ProgramBinaryLength = 34625,

    [NativeName("GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
    ActiveAtomicCounterBuffers = 37593,

    [NativeName("GL_COMPUTE_WORK_GROUP_SIZE")]
    ComputeWorkGroupSize = 33383,
}
