// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkPresentInfoKHR
{
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public void* pNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint waitSemaphoreCount;

    [NativeTypeName("const VkSemaphore *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSemaphore_T** pWaitSemaphores;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint swapchainCount;

    [NativeTypeName("const VkSwapchainKHR *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkSwapchainKHR_T** pSwapchains;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public uint* pImageIndices;

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    public VkResult* pResults;
}
