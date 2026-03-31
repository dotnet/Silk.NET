// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSwapchainCreateInfoKHR")]
[NameAffix("Suffix", "KhronosVendor", "KHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkSwapchainCreateInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public void* PNext;

    [NativeName("flags")]
    [NativeTypeName("VkSwapchainCreateFlagsKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSwapchainCreateFlagsKHR Flags;

    [NativeName("surface")]
    [NativeTypeName("VkSurfaceKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceHandleKHR Surface;

    [NativeName("minImageCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint MinImageCount;

    [NativeName("imageFormat")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkFormat ImageFormat;

    [NativeName("imageColorSpace")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkColorSpaceKHR ImageColorSpace;

    [NativeName("imageExtent")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkExtent2D ImageExtent;

    [NativeName("imageArrayLayers")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint ImageArrayLayers;

    [NativeName("imageUsage")]
    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkImageUsageFlags ImageUsage;

    [NativeName("imageSharingMode")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSharingMode ImageSharingMode;

    [NativeName("queueFamilyIndexCount")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint QueueFamilyIndexCount;

    [NativeName("pQueueFamilyIndices")]
    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint* PQueueFamilyIndices;

    [NativeName("preTransform")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSurfaceTransformFlagsKHR PreTransform;

    [NativeName("compositeAlpha")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkCompositeAlphaFlagsKHR CompositeAlpha;

    [NativeName("presentMode")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkPresentModeKHR PresentMode;

    [NativeName("clipped")]
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint Clipped;

    [NativeName("oldSwapchain")]
    [NativeTypeName("VkSwapchainKHR")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSwapchainHandleKHR OldSwapchain;
}
