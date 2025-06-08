// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkLayeredDriverUnderlyingApiMSFT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT = 1,

    [SupportedApiProfile(
        "vulkan",
        ["VK_MSFT_layered_driver"],
        ImpliesSets = [
            "VK_MSFT_layered_driver+VK_KHR_get_physical_device_properties2",
            "VK_MSFT_layered_driver+VK_VERSION_1_1",
        ]
    )]
    VK_LAYERED_DRIVER_UNDERLYING_API_MAX_ENUM_MSFT = 0x7FFFFFFF,
}
