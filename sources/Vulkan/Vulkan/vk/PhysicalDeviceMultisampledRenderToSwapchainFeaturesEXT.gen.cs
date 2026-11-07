// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public StructureType SType =
        StructureType.PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public void* PNext;

    [NativeName("multisampledRenderToSwapchain")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public MaybeBool<uint> MultisampledRenderToSwapchain;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public PhysicalDeviceMultisampledRenderToSwapchainFeaturesEXT() { }
}
