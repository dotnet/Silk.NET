// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainFlagsSurfaceCapabilitiesEXT")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct SwapchainFlagsSurfaceCapabilitiesEXT
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public StructureType SType = StructureType.SwapchainFlagsSurfaceCapabilitiesEXT;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public void* PNext;

    [NativeName("swapchainSupportedFlags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public SwapchainCreateFlagsKHR SwapchainSupportedFlags;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_multisampled_render_to_swapchain"],
        ImpliesSets = ["VK_EXT_multisampled_render_to_single_sampled", "VK_KHR_swapchain"]
    )]
    public SwapchainFlagsSurfaceCapabilitiesEXT() { }
}
