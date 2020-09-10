// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_PRIMITIVE")]
    public enum TessellatorOutputPrimitive
    {
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_UNDEFINED")]
        TessellatorOutputUndefined = 0x0,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_POINT")]
        TessellatorOutputPoint = 0x1,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_LINE")]
        TessellatorOutputLine = 0x2,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW")]
        TessellatorOutputTriangleCW = 0x3,
        [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW")]
        TessellatorOutputTriangleCcw = 0x4,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_UNDEFINED")]
        D3D11TessellatorOutputUndefined = 0x0,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_POINT")]
        D3D11TessellatorOutputPoint = 0x1,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_LINE")]
        D3D11TessellatorOutputLine = 0x2,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW")]
        D3D11TessellatorOutputTriangleCW = 0x3,
        [NativeName("Name", "D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW")]
        D3D11TessellatorOutputTriangleCcw = 0x4,
    }
}
