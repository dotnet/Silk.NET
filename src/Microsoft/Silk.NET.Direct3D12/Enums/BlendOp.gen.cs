// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BLEND_OP")]
    public enum BlendOp
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
