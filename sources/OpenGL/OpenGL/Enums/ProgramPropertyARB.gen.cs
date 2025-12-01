// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramPropertyARB")]
public enum ProgramPropertyARB : uint
{
    [NativeName("GL_DELETE_STATUS")]
    DeleteStatus = unchecked((uint)0x8B80),

    [NativeName("GL_LINK_STATUS")]
    LinkStatus = unchecked((uint)0x8B82),

    [NativeName("GL_VALIDATE_STATUS")]
    ValidateStatus = unchecked((uint)0x8B83),

    [NativeName("GL_INFO_LOG_LENGTH")]
    InfoLogLength = unchecked((uint)0x8B84),

    [NativeName("GL_ATTACHED_SHADERS")]
    AttachedShaders = unchecked((uint)0x8B85),

    [NativeName("GL_ACTIVE_UNIFORMS")]
    ActiveUniforms = unchecked((uint)0x8B86),

    [NativeName("GL_ACTIVE_UNIFORM_MAX_LENGTH")]
    ActiveUniformMaxLength = unchecked((uint)0x8B87),

    [NativeName("GL_ACTIVE_ATTRIBUTES")]
    ActiveAttributes = unchecked((uint)0x8B89),

    [NativeName("GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
    ActiveAttributeMaxLength = unchecked((uint)0x8B8A),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
    TransformFeedbackVaryingMaxLength = unchecked((uint)0x8C76),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
    TransformFeedbackBufferMode = unchecked((uint)0x8C7F),

    [NativeName("GL_TRANSFORM_FEEDBACK_VARYINGS")]
    TransformFeedbackVaryings = unchecked((uint)0x8C83),

    [NativeName("GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
    ActiveUniformBlockMaxNameLength = unchecked((uint)0x8A35),

    [NativeName("GL_ACTIVE_UNIFORM_BLOCKS")]
    ActiveUniformBlocks = unchecked((uint)0x8A36),

    [NativeName("GL_GEOMETRY_VERTICES_OUT")]
    GeometryVerticesOut = unchecked((uint)0x8916),

    [NativeName("GL_GEOMETRY_INPUT_TYPE")]
    GeometryInputType = unchecked((uint)0x8917),

    [NativeName("GL_GEOMETRY_OUTPUT_TYPE")]
    GeometryOutputType = unchecked((uint)0x8918),

    [NativeName("GL_PROGRAM_BINARY_LENGTH")]
    ProgramBinaryLength = unchecked((uint)0x8741),

    [NativeName("GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
    ActiveAtomicCounterBuffers = unchecked((uint)0x92D9),

    [NativeName("GL_COMPUTE_WORK_GROUP_SIZE")]
    ComputeWorkGroupSize = unchecked((uint)0x8267),
}
