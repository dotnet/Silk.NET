// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FramebufferTarget")]
    public enum FramebufferTarget : int
    {
        [NativeName("Name", "GL_READ_FRAMEBUFFER")]
        ReadFramebuffer = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER")]
        DrawFramebuffer = 0x8CA9,
        [NativeName("Name", "GL_FRAMEBUFFER")]
        Framebuffer = 0x8D40,
        [NativeName("Name", "GL_FRAMEBUFFER_OES")]
        FramebufferOes = 0x8D40,
    }
}
