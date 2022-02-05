// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_STENCIL_OP")]
    public enum StencilOp : int
    {
        [NativeName("Name", "D3D11_STENCIL_OP_KEEP")]
        StencilOpKeep = 0x1,
        [NativeName("Name", "D3D11_STENCIL_OP_ZERO")]
        StencilOpZero = 0x2,
        [NativeName("Name", "D3D11_STENCIL_OP_REPLACE")]
        StencilOpReplace = 0x3,
        [NativeName("Name", "D3D11_STENCIL_OP_INCR_SAT")]
        StencilOpIncrSat = 0x4,
        [NativeName("Name", "D3D11_STENCIL_OP_DECR_SAT")]
        StencilOpDecrSat = 0x5,
        [NativeName("Name", "D3D11_STENCIL_OP_INVERT")]
        StencilOpInvert = 0x6,
        [NativeName("Name", "D3D11_STENCIL_OP_INCR")]
        StencilOpIncr = 0x7,
        [NativeName("Name", "D3D11_STENCIL_OP_DECR")]
        StencilOpDecr = 0x8,
    }
}
