// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BLEND")]
    public enum Blend : int
    {
        [NativeName("Name", "D3D12_BLEND_ZERO")]
        BlendZero = 0x1,
        [NativeName("Name", "D3D12_BLEND_ONE")]
        BlendOne = 0x2,
        [NativeName("Name", "D3D12_BLEND_SRC_COLOR")]
        BlendSrcColor = 0x3,
        [NativeName("Name", "D3D12_BLEND_INV_SRC_COLOR")]
        BlendInvSrcColor = 0x4,
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x5,
        [NativeName("Name", "D3D12_BLEND_INV_SRC_ALPHA")]
        BlendInvSrcAlpha = 0x6,
        [NativeName("Name", "D3D12_BLEND_DEST_ALPHA")]
        BlendDestAlpha = 0x7,
        [NativeName("Name", "D3D12_BLEND_INV_DEST_ALPHA")]
        BlendInvDestAlpha = 0x8,
        [NativeName("Name", "D3D12_BLEND_DEST_COLOR")]
        BlendDestColor = 0x9,
        [NativeName("Name", "D3D12_BLEND_INV_DEST_COLOR")]
        BlendInvDestColor = 0xA,
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA_SAT")]
        BlendSrcAlphaSat = 0xB,
        [NativeName("Name", "D3D12_BLEND_BLEND_FACTOR")]
        BlendBlendFactor = 0xE,
        [NativeName("Name", "D3D12_BLEND_INV_BLEND_FACTOR")]
        BlendInvBlendFactor = 0xF,
        [NativeName("Name", "D3D12_BLEND_SRC1_COLOR")]
        BlendSrc1Color = 0x10,
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_COLOR")]
        BlendInvSrc1Color = 0x11,
        [NativeName("Name", "D3D12_BLEND_SRC1_ALPHA")]
        BlendSrc1Alpha = 0x12,
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_ALPHA")]
        BlendInvSrc1Alpha = 0x13,
    }
}
