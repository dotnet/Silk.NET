// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TRACE_GS_INPUT_PRIMITIVE")]
    public enum TraceGSInputPrimitive : int
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
