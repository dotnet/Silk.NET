// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FramebufferStatus")]
public enum FramebufferStatus : uint
{
    [NativeName("GL_FRAMEBUFFER_UNDEFINED")]
    Undefined = unchecked((uint)0x8219),

    [NativeName("GL_FRAMEBUFFER_COMPLETE")]
    Complete = unchecked((uint)0x8CD5),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
    IncompleteAttachment = unchecked((uint)0x8CD6),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
    IncompleteMissingAttachment = unchecked((uint)0x8CD7),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
    IncompleteDrawBuffer = unchecked((uint)0x8CDB),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
    IncompleteReadBuffer = unchecked((uint)0x8CDC),

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED")]
    Unsupported = unchecked((uint)0x8CDD),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
    IncompleteMultisample = unchecked((uint)0x8D56),

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
    IncompleteLayerTargets = unchecked((uint)0x8DA8),
}
