// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkSurfaceCapabilitiesKHR
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint minImageCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint maxImageCount;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D currentExtent;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D minImageExtent;

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkExtent2D maxImageExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint maxImageArrayLayers;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint supportedTransforms;

    [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR currentTransform;

    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint supportedCompositeAlpha;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    public uint supportedUsageFlags;
}
