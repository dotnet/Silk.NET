// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum AttribMask
    {
        CurrentBit = 0x1,
        PointBit = 0x2,
        LineBit = 0x4,
        PolygonBit = 0x8,
        PolygonStippleBit = 0x10,
        PixelModeBit = 0x20,
        LightingBit = 0x40,
        FogBit = 0x80,
        DepthBufferBit = 0x100,
        AccumBufferBit = 0x200,
        StencilBufferBit = 0x400,
        ViewportBit = 0x800,
        TransformBit = 0x1000,
        EnableBit = 0x2000,
        ColorBufferBit = 0x4000,
        HintBit = 0x8000,
        EvalBit = 0x10000,
        ListBit = 0x20000,
        TextureBit = 0x40000,
        ScissorBit = 0x80000,
        MultisampleBit = 0x20000000,
        MultisampleBitArb = 0x20000000,
        MultisampleBitExt = 0x20000000,
        MultisampleBit3Dfx = 0x20000000,
        AllAttribBits = unchecked((int)0xFFFFFFFF),
    }
}
