// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum CommandOpcodesNV
    {
        TerminateSequenceCommandNV = 0x0,
        NopCommandNV = 0x1,
        DrawElementsCommandNV = 0x2,
        DrawArraysCommandNV = 0x3,
        DrawElementsStripCommandNV = 0x4,
        DrawArraysStripCommandNV = 0x5,
        DrawElementsInstancedCommandNV = 0x6,
        DrawArraysInstancedCommandNV = 0x7,
        ElementAddressCommandNV = 0x8,
        AttributeAddressCommandNV = 0x9,
        UniformAddressCommandNV = 0xA,
        BlendColorCommandNV = 0xB,
        StencilRefCommandNV = 0xC,
        LineWidthCommandNV = 0xD,
        PolygonOffsetCommandNV = 0xE,
        AlphaRefCommandNV = 0xF,
        ViewportCommandNV = 0x10,
        ScissorCommandNV = 0x11,
        FrontFaceCommandNV = 0x12,
    }
}
