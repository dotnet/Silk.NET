// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TransformFeedbackPName")]
    public enum TransformFeedbackPName
    {
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START")]
        TransformFeedbackBufferStart = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
        TransformFeedbackBufferSize = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
        TransformFeedbackBufferBinding = 0x8C8F,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PAUSED")]
        TransformFeedbackPaused = 0x8E23,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_ACTIVE")]
        TransformFeedbackActive = 0x8E24,
    }
}
