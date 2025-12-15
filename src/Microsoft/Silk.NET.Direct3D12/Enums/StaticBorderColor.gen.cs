// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATIC_BORDER_COLOR")]
    public enum StaticBorderColor : int
    {
        [Obsolete("Deprecated in favour of \"TransparentBlack\"")]
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK")]
        StaticBorderColorTransparentBlack = 0x0,
        [Obsolete("Deprecated in favour of \"OpaqueBlack\"")]
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK")]
        StaticBorderColorOpaqueBlack = 0x1,
        [Obsolete("Deprecated in favour of \"OpaqueWhite\"")]
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE")]
        StaticBorderColorOpaqueWhite = 0x2,
        [Obsolete("Deprecated in favour of \"OpaqueBlackUint\"")]
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT")]
        StaticBorderColorOpaqueBlackUint = 0x3,
        [Obsolete("Deprecated in favour of \"OpaqueWhiteUint\"")]
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT")]
        StaticBorderColorOpaqueWhiteUint = 0x4,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK")]
        TransparentBlack = 0x0,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK")]
        OpaqueBlack = 0x1,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE")]
        OpaqueWhite = 0x2,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT")]
        OpaqueBlackUint = 0x3,
        [NativeName("Name", "D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT")]
        OpaqueWhiteUint = 0x4,
    }
}
