// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_PRIMITIVE")]
    public enum D3DTessellatorOutputPrimitive
    {
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_UNDEFINED")]
        D3DTessellatorOutputUndefined = 0x0,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_POINT")]
        D3DTessellatorOutputPoint = 0x1,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_LINE")]
        D3DTessellatorOutputLine = 0x2,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW")]
        D3DTessellatorOutputTriangleCW = 0x3,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW")]
        D3DTessellatorOutputTriangleCcw = 0x4,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_UNDEFINED")]
        TessellatorOutputUndefined = 0x0,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_POINT")]
        TessellatorOutputPoint = 0x1,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_LINE")]
        TessellatorOutputLine = 0x2,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW")]
        TessellatorOutputTriangleCW = 0x3,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW")]
        TessellatorOutputTriangleCcw = 0x4,
    }
}
