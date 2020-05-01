// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum UseProgramStageMask
    {
        VertexShaderBit = 0x1,
        VertexShaderBitExt = 0x1,
        FragmentShaderBit = 0x2,
        FragmentShaderBitExt = 0x2,
        GeometryShaderBit = 0x4,
        GeometryShaderBitExt = 0x4,
        GeometryShaderBitOes = 0x4,
        TessControlShaderBit = 0x8,
        TessControlShaderBitExt = 0x8,
        TessControlShaderBitOes = 0x8,
        TessEvaluationShaderBit = 0x10,
        TessEvaluationShaderBitExt = 0x10,
        TessEvaluationShaderBitOes = 0x10,
        ComputeShaderBit = 0x20,
        MeshShaderBitNV = 0x40,
        TaskShaderBitNV = 0x80,
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        AllShaderBitsExt = unchecked((int)0xFFFFFFFF),
    }
}
