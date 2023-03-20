// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_BLEND")]
    public enum Blend : int
    {
        [NativeName("Name", "D2D1_BLEND_ZERO")]
        Zero = 0x1,
        [NativeName("Name", "D2D1_BLEND_ONE")]
        One = 0x2,
        [NativeName("Name", "D2D1_BLEND_SRC_COLOR")]
        SrcColor = 0x3,
        [NativeName("Name", "D2D1_BLEND_INV_SRC_COLOR")]
        InvSrcColor = 0x4,
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA")]
        SrcAlpha = 0x5,
        [NativeName("Name", "D2D1_BLEND_INV_SRC_ALPHA")]
        InvSrcAlpha = 0x6,
        [NativeName("Name", "D2D1_BLEND_DEST_ALPHA")]
        DestAlpha = 0x7,
        [NativeName("Name", "D2D1_BLEND_INV_DEST_ALPHA")]
        InvDestAlpha = 0x8,
        [NativeName("Name", "D2D1_BLEND_DEST_COLOR")]
        DestColor = 0x9,
        [NativeName("Name", "D2D1_BLEND_INV_DEST_COLOR")]
        InvDestColor = 0xA,
        [NativeName("Name", "D2D1_BLEND_SRC_ALPHA_SAT")]
        SrcAlphaSat = 0xB,
        [NativeName("Name", "D2D1_BLEND_BLEND_FACTOR")]
        BlendFactor = 0xE,
        [NativeName("Name", "D2D1_BLEND_INV_BLEND_FACTOR")]
        InvBlendFactor = 0xF,
        [NativeName("Name", "D2D1_BLEND_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
