// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDisplayPresentInfoKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    public void* pNext;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    public VkRect2D srcRect;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    public VkRect2D dstRect;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_display_swapchain"],
        ImpliesSets = ["VK_KHR_display", "VK_KHR_swapchain"]
    )]
    public uint persistent;
}
