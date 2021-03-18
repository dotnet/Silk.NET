// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TransformFeedbackPName")]
    public enum TransformFeedbackPName : int
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
