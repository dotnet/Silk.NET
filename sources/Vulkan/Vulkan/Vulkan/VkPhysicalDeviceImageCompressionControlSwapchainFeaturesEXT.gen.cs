// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public void* pNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_compression_control_swapchain"],
        ImpliesSets = ["VK_EXT_image_compression_control"]
    )]
    public uint imageCompressionControlSwapchain;
}
