// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FramebufferTarget")]
    public enum FramebufferTarget
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
