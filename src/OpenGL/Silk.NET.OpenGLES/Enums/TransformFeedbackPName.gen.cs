// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TransformFeedbackPName")]
    public enum TransformFeedbackPName : int
    {
        [Obsolete("Deprecated in favour of \"BufferStart\"")]
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START")]
        TransformFeedbackBufferStart = 0x8C84,
        [Obsolete("Deprecated in favour of \"BufferSize\"")]
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
        TransformFeedbackBufferSize = 0x8C85,
        [Obsolete("Deprecated in favour of \"BufferBinding\"")]
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
        TransformFeedbackBufferBinding = 0x8C8F,
        [Obsolete("Deprecated in favour of \"Paused\"")]
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PAUSED")]
        TransformFeedbackPaused = 0x8E23,
        [Obsolete("Deprecated in favour of \"Active\"")]
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_ACTIVE")]
        TransformFeedbackActive = 0x8E24,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_START")]
        BufferStart = 0x8C84,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
        BufferSize = 0x8C85,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
        BufferBinding = 0x8C8F,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_PAUSED")]
        Paused = 0x8E23,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_ACTIVE")]
        Active = 0x8E24,
    }
}
