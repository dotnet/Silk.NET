// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSwapchainCreateInfoKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public void* pNext;

    [NativeTypeName("VkSwapchainCreateFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint flags;

    [NativeTypeName("VkSurfaceKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceKHR_T* surface;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint minImageCount;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkFormat imageFormat;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkColorSpaceKHR imageColorSpace;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D imageExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint imageArrayLayers;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint imageUsage;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSharingMode imageSharingMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint queueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint* pQueueFamilyIndices;

    [NativeTypeName("VkSurfaceTransformFlagBitsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR preTransform;

    [NativeTypeName("VkCompositeAlphaFlagBitsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkCompositeAlphaFlagsKHR compositeAlpha;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkPresentModeKHR presentMode;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint clipped;

    [NativeTypeName("VkSwapchainKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSwapchainKHR_T* oldSwapchain;
}
