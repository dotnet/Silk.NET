// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ProgramPropertyARB")]
    public enum ProgramPropertyARB
    {
        [NativeName("Name", "GL_COMPUTE_WORK_GROUP_SIZE")]
        ComputeWorkGroupSize = 0x8267,
        [NativeName("Name", "GL_PROGRAM_BINARY_LENGTH")]
        ProgramBinaryLength = 0x8741,
        [NativeName("Name", "GL_GEOMETRY_VERTICES_OUT")]
        GeometryVerticesOut = 0x8916,
        [NativeName("Name", "GL_GEOMETRY_INPUT_TYPE")]
        GeometryInputType = 0x8917,
        [NativeName("Name", "GL_GEOMETRY_OUTPUT_TYPE")]
        GeometryOutputType = 0x8918,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
        ActiveUniformBlockMaxNameLength = 0x8A35,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCKS")]
        ActiveUniformBlocks = 0x8A36,
        [NativeName("Name", "GL_DELETE_STATUS")]
        DeleteStatus = 0x8B80,
        [NativeName("Name", "GL_LINK_STATUS")]
        LinkStatus = 0x8B82,
        [NativeName("Name", "GL_VALIDATE_STATUS")]
        ValidateStatus = 0x8B83,
        [NativeName("Name", "GL_INFO_LOG_LENGTH")]
        InfoLogLength = 0x8B84,
        [NativeName("Name", "GL_ATTACHED_SHADERS")]
        AttachedShaders = 0x8B85,
        [NativeName("Name", "GL_ACTIVE_UNIFORMS")]
        ActiveUniforms = 0x8B86,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_MAX_LENGTH")]
        ActiveUniformMaxLength = 0x8B87,
        [NativeName("Name", "GL_ACTIVE_ATTRIBUTES")]
        ActiveAttributes = 0x8B89,
        [NativeName("Name", "GL_ACTIVE_ATTRIBUTE_MAX_LENGTH")]
        ActiveAttributeMaxLength = 0x8B8A,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH")]
        TransformFeedbackVaryingMaxLength = 0x8C76,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_MODE")]
        TransformFeedbackBufferMode = 0x8C7F,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYINGS")]
        TransformFeedbackVaryings = 0x8C83,
        [NativeName("Name", "GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
        ActiveAtomicCounterBuffers = 0x92D9,
    }
}
