// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "D3D_TESSELLATOR_OUTPUT_PRIMITIVE")]
    public enum D3DTessellatorOutputPrimitive : int
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
