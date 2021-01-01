// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "AttribMask")]
    public enum AttribMask : int
    {
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT")]
        DepthBufferBit = 0x100,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT")]
        StencilBufferBit = 0x400,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT")]
        ColorBufferBit = 0x4000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_ARB")]
        MultisampleBitArb = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_EXT")]
        MultisampleBitExt = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_3DFX")]
        MultisampleBit3Dfx = 0x20000000,
    }
}
