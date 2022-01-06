// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG")]
    public enum SwapChainColorSpaceSupportFlag : int
    {
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_PRESENT")]
        SwapChainColorSpaceSupportFlagPresent = 0x1,
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_OVERLAY_PRESENT")]
        SwapChainColorSpaceSupportFlagOverlayPresent = 0x2,
    }
}
