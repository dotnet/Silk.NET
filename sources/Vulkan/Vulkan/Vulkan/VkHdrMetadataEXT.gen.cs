// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkHdrMetadataEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public void* pNext;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public VkXYColorEXT displayPrimaryRed;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public VkXYColorEXT displayPrimaryGreen;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public VkXYColorEXT displayPrimaryBlue;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public VkXYColorEXT whitePoint;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public float maxLuminance;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public float minLuminance;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public float maxContentLightLevel;

    [SupportedApiProfile("vulkan", ["VK_EXT_hdr_metadata"], ImpliesSets = ["VK_KHR_swapchain"])]
    public float maxFrameAverageLightLevel;
}
