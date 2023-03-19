// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG")]
    public enum SwapChainColorSpaceSupportFlag : int
    {
        [Obsolete("Deprecated in favour of \"Present\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_PRESENT")]
        SwapChainColorSpaceSupportFlagPresent = 0x1,
        [Obsolete("Deprecated in favour of \"OverlayPresent\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_OVERLAY_PRESENT")]
        SwapChainColorSpaceSupportFlagOverlayPresent = 0x2,
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_PRESENT")]
        Present = 0x1,
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_OVERLAY_PRESENT")]
        OverlayPresent = 0x2,
    }
}
