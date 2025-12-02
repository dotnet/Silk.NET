// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("FramebufferTarget")]
public enum FramebufferTarget : uint
{
    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_FRAMEBUFFER_OES")]
    FramebufferOES = unchecked((uint)0x8D40),

    [NativeName("GL_READ_FRAMEBUFFER")]
    ReadFramebuffer = unchecked((uint)0x8CA8),

    [NativeName("GL_DRAW_FRAMEBUFFER")]
    DrawFramebuffer = unchecked((uint)0x8CA9),

    [NativeName("GL_FRAMEBUFFER")]
    Framebuffer = unchecked((uint)0x8D40),
}
