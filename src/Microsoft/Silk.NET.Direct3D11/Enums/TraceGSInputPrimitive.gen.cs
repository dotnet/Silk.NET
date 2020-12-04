// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
    public enum TraceGSInputPrimitive
    {
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_UNDEFINED")]
        TraceGSInputPrimitiveUndefined = 0x0,
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_POINT")]
        TraceGSInputPrimitivePoint = 0x1,
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE")]
        TraceGSInputPrimitiveLine = 0x2,
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE")]
        TraceGSInputPrimitiveTriangle = 0x3,
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_LINE_ADJ")]
        TraceGSInputPrimitiveLineAdj = 0x6,
        [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE_TRIANGLE_ADJ")]
        TraceGSInputPrimitiveTriangleAdj = 0x7,
    }
}
