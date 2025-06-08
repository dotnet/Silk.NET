// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkRectLayerKHR
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public VkOffset2D offset;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public VkExtent2D extent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_incremental_present"],
        ImpliesSets = ["VK_KHR_swapchain"]
    )]
    public uint layer;
}
