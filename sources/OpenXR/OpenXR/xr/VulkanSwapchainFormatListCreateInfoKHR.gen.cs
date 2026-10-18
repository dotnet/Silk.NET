// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVulkanSwapchainFormatListCreateInfoKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VulkanSwapchainFormatListCreateInfoKHR
{
    [NativeName("type")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    public StructureType Type = StructureType.VulkanSwapchainFormatListCreateInfoKHR;

    [NativeName("next")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    public void* Next;

    [NativeName("viewFormatCount")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    public uint ViewFormatCount;

    [NativeName("viewFormats")]
    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    public VkFormatHandle ViewFormats;

    [SupportedApiProfile(
        "openxr",
        ["XR_KHR_vulkan_swapchain_format_list"],
        ImpliesSets = ["XR_KHR_vulkan_enable", "XR_KHR_vulkan_enable2", "XR_VERSION_1_0"]
    )]
    public VulkanSwapchainFormatListCreateInfoKHR() { }
}
