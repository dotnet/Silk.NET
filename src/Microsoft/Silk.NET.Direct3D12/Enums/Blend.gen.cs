// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BLEND")]
    public enum Blend : int
    {
        [Obsolete("Deprecated in favour of \"Zero\"")]
        [NativeName("Name", "D3D12_BLEND_ZERO")]
        BlendZero = 0x1,
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "D3D12_BLEND_ONE")]
        BlendOne = 0x2,
        [Obsolete("Deprecated in favour of \"SrcColor\"")]
        [NativeName("Name", "D3D12_BLEND_SRC_COLOR")]
        BlendSrcColor = 0x3,
        [Obsolete("Deprecated in favour of \"InvSrcColor\"")]
        [NativeName("Name", "D3D12_BLEND_INV_SRC_COLOR")]
        BlendInvSrcColor = 0x4,
        [Obsolete("Deprecated in favour of \"SrcAlpha\"")]
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA")]
        BlendSrcAlpha = 0x5,
        [Obsolete("Deprecated in favour of \"InvSrcAlpha\"")]
        [NativeName("Name", "D3D12_BLEND_INV_SRC_ALPHA")]
        BlendInvSrcAlpha = 0x6,
        [Obsolete("Deprecated in favour of \"DestAlpha\"")]
        [NativeName("Name", "D3D12_BLEND_DEST_ALPHA")]
        BlendDestAlpha = 0x7,
        [Obsolete("Deprecated in favour of \"InvDestAlpha\"")]
        [NativeName("Name", "D3D12_BLEND_INV_DEST_ALPHA")]
        BlendInvDestAlpha = 0x8,
        [Obsolete("Deprecated in favour of \"DestColor\"")]
        [NativeName("Name", "D3D12_BLEND_DEST_COLOR")]
        BlendDestColor = 0x9,
        [Obsolete("Deprecated in favour of \"InvDestColor\"")]
        [NativeName("Name", "D3D12_BLEND_INV_DEST_COLOR")]
        BlendInvDestColor = 0xA,
        [Obsolete("Deprecated in favour of \"SrcAlphaSat\"")]
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA_SAT")]
        BlendSrcAlphaSat = 0xB,
        [Obsolete("Deprecated in favour of \"BlendFactor\"")]
        [NativeName("Name", "D3D12_BLEND_BLEND_FACTOR")]
        BlendBlendFactor = 0xE,
        [Obsolete("Deprecated in favour of \"InvBlendFactor\"")]
        [NativeName("Name", "D3D12_BLEND_INV_BLEND_FACTOR")]
        BlendInvBlendFactor = 0xF,
        [Obsolete("Deprecated in favour of \"Src1Color\"")]
        [NativeName("Name", "D3D12_BLEND_SRC1_COLOR")]
        BlendSrc1Color = 0x10,
        [Obsolete("Deprecated in favour of \"InvSrc1Color\"")]
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_COLOR")]
        BlendInvSrc1Color = 0x11,
        [Obsolete("Deprecated in favour of \"Src1Alpha\"")]
        [NativeName("Name", "D3D12_BLEND_SRC1_ALPHA")]
        BlendSrc1Alpha = 0x12,
        [Obsolete("Deprecated in favour of \"InvSrc1Alpha\"")]
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_ALPHA")]
        BlendInvSrc1Alpha = 0x13,
        [Obsolete("Deprecated in favour of \"AlphaFactor\"")]
        [NativeName("Name", "D3D12_BLEND_ALPHA_FACTOR")]
        BlendAlphaFactor = 0x14,
        [Obsolete("Deprecated in favour of \"InvAlphaFactor\"")]
        [NativeName("Name", "D3D12_BLEND_INV_ALPHA_FACTOR")]
        BlendInvAlphaFactor = 0x15,
        [NativeName("Name", "D3D12_BLEND_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "D3D12_BLEND_ONE")]
        One = 0x2,
        [NativeName("Name", "D3D12_BLEND_SRC_COLOR")]
        SrcColor = 0x3,
        [NativeName("Name", "D3D12_BLEND_INV_SRC_COLOR")]
        InvSrcColor = 0x4,
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA")]
        SrcAlpha = 0x5,
        [NativeName("Name", "D3D12_BLEND_INV_SRC_ALPHA")]
        InvSrcAlpha = 0x6,
        [NativeName("Name", "D3D12_BLEND_DEST_ALPHA")]
        DestAlpha = 0x7,
        [NativeName("Name", "D3D12_BLEND_INV_DEST_ALPHA")]
        InvDestAlpha = 0x8,
        [NativeName("Name", "D3D12_BLEND_DEST_COLOR")]
        DestColor = 0x9,
        [NativeName("Name", "D3D12_BLEND_INV_DEST_COLOR")]
        InvDestColor = 0xA,
        [NativeName("Name", "D3D12_BLEND_SRC_ALPHA_SAT")]
        SrcAlphaSat = 0xB,
        [NativeName("Name", "D3D12_BLEND_BLEND_FACTOR")]
        BlendFactor = 0xE,
        [NativeName("Name", "D3D12_BLEND_INV_BLEND_FACTOR")]
        InvBlendFactor = 0xF,
        [NativeName("Name", "D3D12_BLEND_SRC1_COLOR")]
        Src1Color = 0x10,
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_COLOR")]
        InvSrc1Color = 0x11,
        [NativeName("Name", "D3D12_BLEND_SRC1_ALPHA")]
        Src1Alpha = 0x12,
        [NativeName("Name", "D3D12_BLEND_INV_SRC1_ALPHA")]
        InvSrc1Alpha = 0x13,
        [NativeName("Name", "D3D12_BLEND_ALPHA_FACTOR")]
        AlphaFactor = 0x14,
        [NativeName("Name", "D3D12_BLEND_INV_ALPHA_FACTOR")]
        InvAlphaFactor = 0x15,
    }
}
