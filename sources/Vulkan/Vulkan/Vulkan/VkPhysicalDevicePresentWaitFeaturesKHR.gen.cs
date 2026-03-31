// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePresentWaitFeaturesKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDevicePresentWaitFeaturesKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    public void* PNext;

    [NativeName("presentWait")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_present_wait"],
        ImpliesSets = ["VK_KHR_present_id", "VK_KHR_swapchain"]
    )]
    public uint PresentWait;
}
