// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPresentTimesInfoGOOGLE")]
[NameAffix("Suffix", "KhronosVendor", "GOOGLE")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPresentTimesInfoGOOGLE
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public void* PNext;

    [NativeName("swapchainCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public uint SwapchainCount;

    [NativeName("pTimes")]
    [NativeTypeName("const VkPresentTimeGOOGLE *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_GOOGLE_display_timing"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public VkPresentTimeGOOGLE* PTimes;
}
