// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.MESA
{
    [NativeName("Name", "GLenum")]
    public enum MESA : int
    {
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_X_MESA")]
        FramebufferFlipXMesa = 0x8BBC,
        [NativeName("Name", "GL_FRAMEBUFFER_FLIP_Y_MESA")]
        FramebufferFlipYMesa = 0x8BBB,
        [NativeName("Name", "GL_FRAMEBUFFER_SWAP_XY_MESA")]
        FramebufferSwapXYMesa = 0x8BBD,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMAT_MESA")]
        ProgramBinaryFormatMesa = 0x875F,
    }
}
