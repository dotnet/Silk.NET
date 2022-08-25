// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [Flags]
    [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG")]
    public enum SwapChainFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Nonprerotated\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_NONPREROTATED")]
        SwapChainFlagNonprerotated = 0x1,
        [Obsolete("Deprecated in favour of \"AllowModeSwitch\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH")]
        SwapChainFlagAllowModeSwitch = 0x2,
        [Obsolete("Deprecated in favour of \"GdiCompatible\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE")]
        SwapChainFlagGdiCompatible = 0x4,
        [Obsolete("Deprecated in favour of \"RestrictedContent\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT")]
        SwapChainFlagRestrictedContent = 0x8,
        [Obsolete("Deprecated in favour of \"RestrictSharedResourceDriver\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER")]
        SwapChainFlagRestrictSharedResourceDriver = 0x10,
        [Obsolete("Deprecated in favour of \"DisplayOnly\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY")]
        SwapChainFlagDisplayOnly = 0x20,
        [Obsolete("Deprecated in favour of \"FrameLatencyWaitableObject\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT")]
        SwapChainFlagFrameLatencyWaitableObject = 0x40,
        [Obsolete("Deprecated in favour of \"ForegroundLayer\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER")]
        SwapChainFlagForegroundLayer = 0x80,
        [Obsolete("Deprecated in favour of \"FullscreenVideo\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO")]
        SwapChainFlagFullscreenVideo = 0x100,
        [Obsolete("Deprecated in favour of \"YuvVideo\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO")]
        SwapChainFlagYuvVideo = 0x200,
        [Obsolete("Deprecated in favour of \"HWProtected\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED")]
        SwapChainFlagHWProtected = 0x400,
        [Obsolete("Deprecated in favour of \"AllowTearing\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING")]
        SwapChainFlagAllowTearing = 0x800,
        [Obsolete("Deprecated in favour of \"RestrictedToAllHolographicDisplays\"")]
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS")]
        SwapChainFlagRestrictedToAllHolographicDisplays = 0x1000,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_NONPREROTATED")]
        Nonprerotated = 0x1,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_MODE_SWITCH")]
        AllowModeSwitch = 0x2,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_GDI_COMPATIBLE")]
        GdiCompatible = 0x4,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_CONTENT")]
        RestrictedContent = 0x8,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICT_SHARED_RESOURCE_DRIVER")]
        RestrictSharedResourceDriver = 0x10,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_DISPLAY_ONLY")]
        DisplayOnly = 0x20,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FRAME_LATENCY_WAITABLE_OBJECT")]
        FrameLatencyWaitableObject = 0x40,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FOREGROUND_LAYER")]
        ForegroundLayer = 0x80,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_FULLSCREEN_VIDEO")]
        FullscreenVideo = 0x100,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_YUV_VIDEO")]
        YuvVideo = 0x200,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_HW_PROTECTED")]
        HWProtected = 0x400,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_ALLOW_TEARING")]
        AllowTearing = 0x800,
        [NativeName("Name", "DXGI_SWAP_CHAIN_FLAG_RESTRICTED_TO_ALL_HOLOGRAPHIC_DISPLAYS")]
        RestrictedToAllHolographicDisplays = 0x1000,
    }
}
