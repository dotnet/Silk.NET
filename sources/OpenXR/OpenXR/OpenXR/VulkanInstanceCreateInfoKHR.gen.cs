// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVulkanInstanceCreateInfoKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VulkanInstanceCreateInfoKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public StructureType Type = StructureType.VulkanInstanceCreateInfoKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public void* Next;

    [NativeName("systemId")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public ulong SystemId;

    [NativeName("createFlags")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VulkanInstanceCreateFlagsKHR CreateFlags;

    [NativeName("pfnGetInstanceProcAddr")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public PfnVkGetInstanceProcAddr PfnGetInstanceProcAddr;

    [NativeName("vulkanCreateInfo")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VkInstanceCreateInfoHandle VulkanCreateInfo;

    [NativeName("vulkanAllocator")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VkAllocationCallbacksHandle VulkanAllocator;

    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VulkanInstanceCreateInfoKHR() { }
}
