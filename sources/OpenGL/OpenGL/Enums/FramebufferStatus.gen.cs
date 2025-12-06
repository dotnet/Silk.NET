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
    Undefined = 33305,

    [NativeName("GL_FRAMEBUFFER_COMPLETE")]
    Complete = 36053,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
    IncompleteAttachment = 36054,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
    IncompleteMissingAttachment = 36055,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
    IncompleteDrawBuffer = 36059,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
    IncompleteReadBuffer = 36060,

    [NativeName("GL_FRAMEBUFFER_UNSUPPORTED")]
    Unsupported = 36061,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
    IncompleteMultisample = 36182,

    [NativeName("GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS")]
    IncompleteLayerTargets = 36264,
}
