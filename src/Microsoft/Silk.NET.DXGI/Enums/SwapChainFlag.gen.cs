// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG")]
    public enum SwapChainFlag
    {
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_NONPREROTATED")]
        SwapChainFlagNonprerotated = 0x1,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH")]
        SwapChainFlagAllowModeSwitch = 0x2,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE")]
        SwapChainFlagGdiCompatible = 0x4,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT")]
        SwapChainFlagRestrictedContent = 0x8,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER")]
        SwapChainFlagRestrictSharedResourceDriver = 0x10,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY")]
        SwapChainFlagDisplayOnly = 0x20,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT")]
        SwapChainFlagFrameLatencyWaitableObject = 0x40,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER")]
        SwapChainFlagForegroundLayer = 0x80,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO")]
        SwapChainFlagFullscreenVideo = 0x100,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO")]
        SwapChainFlagYuvVideo = 0x200,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED")]
        SwapChainFlagHWProtected = 0x400,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING")]
        SwapChainFlagAllowTearing = 0x800,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS")]
        SwapChainFlagRestrictedToAllHolographicDisplays = 0x1000,
    }
}
