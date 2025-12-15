// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STENCIL_OP")]
    public enum StencilOp : int
    {
        [Obsolete("Deprecated in favour of \"Keep\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_KEEP")]
        StencilOpKeep = 0x1,
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_ZERO")]
        StencilOpZero = 0x2,
        [Obsolete("Deprecated in favour of \"Replace\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_REPLACE")]
        StencilOpReplace = 0x3,
        [Obsolete("Deprecated in favour of \"IncrSat\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_INCR_SAT")]
        StencilOpIncrSat = 0x4,
        [Obsolete("Deprecated in favour of \"DecrSat\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_DECR_SAT")]
        StencilOpDecrSat = 0x5,
        [Obsolete("Deprecated in favour of \"Invert\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_INVERT")]
        StencilOpInvert = 0x6,
        [Obsolete("Deprecated in favour of \"Incr\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_INCR")]
        StencilOpIncr = 0x7,
        [Obsolete("Deprecated in favour of \"Decr\"")]
        [NativeName("Name", "D3D12_STENCIL_OP_DECR")]
        StencilOpDecr = 0x8,
        [NativeName("Name", "D3D12_STENCIL_OP_KEEP")]
        Keep = 0x1,
        [NativeName("Name", "D3D12_STENCIL_OP_ZERO")]
        Zero = 0x2,
        [NativeName("Name", "D3D12_STENCIL_OP_REPLACE")]
        Replace = 0x3,
        [NativeName("Name", "D3D12_STENCIL_OP_INCR_SAT")]
        IncrSat = 0x4,
        [NativeName("Name", "D3D12_STENCIL_OP_DECR_SAT")]
        DecrSat = 0x5,
        [NativeName("Name", "D3D12_STENCIL_OP_INVERT")]
        Invert = 0x6,
        [NativeName("Name", "D3D12_STENCIL_OP_INCR")]
        Incr = 0x7,
        [NativeName("Name", "D3D12_STENCIL_OP_DECR")]
        Decr = 0x8,
    }
}
