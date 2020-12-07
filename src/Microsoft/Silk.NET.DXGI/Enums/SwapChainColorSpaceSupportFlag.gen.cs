// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG")]
    public enum SwapChainColorSpaceSupportFlag
    {
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_PRESENT")]
        SwapChainColorSpaceSupportFlagPresent = 0x1,
        [NativeName("Name", "DXGI_SWAP_CHAIN_COLOR_SPACE_SUPPORT_FLAG_OVERLAY_PRESENT")]
        SwapChainColorSpaceSupportFlagOverlayPresent = 0x2,
    }
}
