// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TransformFeedbackPName")]
public enum TransformFeedbackPName : uint
{
    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_START")]
    BufferStart = 35972,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    BufferSize = 35973,

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    BufferBinding = 35983,

    [NativeName("GL_TRANSFORM_FEEDBACK_ACTIVE")]
    Active = 36388,

    [NativeName("GL_TRANSFORM_FEEDBACK_PAUSED")]
    Paused = 36387,
}
