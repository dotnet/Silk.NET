// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGL.Legacy
{
    public enum ProgramPropertyARB
    {
        ComputeWorkGroupSize = 0x8267,
        ProgramBinaryLength = 0x8741,
        GeometryVerticesOut = 0x8916,
        GeometryInputType = 0x8917,
        GeometryOutputType = 0x8918,
        ActiveUniformBlockMaxNameLength = 0x8A35,
        ActiveUniformBlocks = 0x8A36,
        DeleteStatus = 0x8B80,
        LinkStatus = 0x8B82,
        ValidateStatus = 0x8B83,
        InfoLogLength = 0x8B84,
        AttachedShaders = 0x8B85,
        ActiveUniforms = 0x8B86,
        ActiveUniformMaxLength = 0x8B87,
        ActiveAttributes = 0x8B89,
        ActiveAttributeMaxLength = 0x8B8A,
        TransformFeedbackVaryingMaxLength = 0x8C76,
        TransformFeedbackBufferMode = 0x8C7F,
        TransformFeedbackVaryings = 0x8C83,
        ActiveAtomicCounterBuffers = 0x92D9,
    }
}
