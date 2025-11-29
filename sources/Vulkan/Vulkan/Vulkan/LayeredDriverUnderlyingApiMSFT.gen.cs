// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "MSFT", 0)]
[NativeName("VkLayeredDriverUnderlyingApiMSFT")]
[SupportedApiProfile("vulkan")]
public enum LayeredDriverUnderlyingApiMSFT : uint
{
    [NameAffix("Suffix", "MSFT", 0)]
    [NativeName("VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    NoneMSFT = 0,

    [NameAffix("Suffix", "MSFT", 0)]
    [NativeName("VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    D3D12Msft = 1,
}
