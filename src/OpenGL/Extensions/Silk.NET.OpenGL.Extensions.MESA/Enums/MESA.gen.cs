// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.MESA
{
    [NativeName("Name", "GLenum")]
    public enum MESA : int
    {
        [Obsolete("Deprecated in favour of \"FlipXMesa\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_X_MESA")]
        FramebufferFlipXMesa = 0x8BBC,
        [Obsolete("Deprecated in favour of \"FlipYMesa\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_Y_MESA")]
        FramebufferFlipYMesa = 0x8BBB,
        [Obsolete("Deprecated in favour of \"SwapXYMesa\"")]
        [NativeName("Name", "GL_FRAMEBUFFER_SWAP_XY_MESA")]
        FramebufferSwapXYMesa = 0x8BBD,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_X_MESA")]
        FlipXMesa = 0x8BBC,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_Y_MESA")]
        FlipYMesa = 0x8BBB,
        [NativeName("Name", "GL_FRAMEBUFFER_SWAP_XY_MESA")]
        SwapXYMesa = 0x8BBD,
    }
}
