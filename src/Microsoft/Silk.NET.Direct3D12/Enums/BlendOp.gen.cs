// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_BLEND_OP")]
    public enum BlendOp : int
    {
        [NativeName("Name", "D3D12_BLEND_OP_ADD")]
        BlendOpAdd = 0x1,
        [NativeName("Name", "D3D12_BLEND_OP_SUBTRACT")]
        BlendOpSubtract = 0x2,
        [NativeName("Name", "D3D12_BLEND_OP_REV_SUBTRACT")]
        BlendOpRevSubtract = 0x3,
        [NativeName("Name", "D3D12_BLEND_OP_MIN")]
        BlendOpMin = 0x4,
        [NativeName("Name", "D3D12_BLEND_OP_MAX")]
        BlendOpMax = 0x5,
    }
}
