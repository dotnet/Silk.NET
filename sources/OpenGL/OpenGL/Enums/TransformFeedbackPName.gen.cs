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
    BufferStart = unchecked((uint)0x8C84),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE")]
    BufferSize = unchecked((uint)0x8C85),

    [NativeName("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING")]
    BufferBinding = unchecked((uint)0x8C8F),

    [NativeName("GL_TRANSFORM_FEEDBACK_ACTIVE")]
    Active = unchecked((uint)0x8E24),

    [NativeName("GL_TRANSFORM_FEEDBACK_PAUSED")]
    Paused = unchecked((uint)0x8E23),
}
