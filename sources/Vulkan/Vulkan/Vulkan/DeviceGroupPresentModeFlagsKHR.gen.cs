// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KHR", 0)]
[NativeName("VkDeviceGroupPresentModeFlagBitsKHR")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum DeviceGroupPresentModeFlagsKHR : uint
{
    None = 0x0,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    LocalBitkhr = 0x1,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_REMOTE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    RemoteBitkhr = 0x2,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_SUM_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    SumBitkhr = 0x4,

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("VK_DEVICE_GROUP_PRESENT_MODE_LOCAL_MULTI_DEVICE_BIT_KHR")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_swapchain", "VK_VERSION_1_1"],
        ImpliesSets = ["VK_KHR_surface"],
        RequireAll = true
    )]
    LocalMultiDeviceBitkhr = 0x8,
}
