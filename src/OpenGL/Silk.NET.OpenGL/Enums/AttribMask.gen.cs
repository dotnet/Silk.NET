// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum AttribMask
    {
        DepthBufferBit = 0x100,
        StencilBufferBit = 0x400,
        ColorBufferBit = 0x4000,
        MultisampleBitArb = 0x20000000,
        MultisampleBitExt = 0x20000000,
        MultisampleBit3Dfx = 0x20000000,
    }
}
