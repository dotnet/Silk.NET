// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVulkanDeviceCreateInfoKHR")]
public unsafe partial struct VulkanDeviceCreateInfoKHR
{
    [NativeName("type")]
    public StructureType Type = StructureType.VulkanDeviceCreateInfoKHR;

    [NativeName("next")]
    public void* Next;

    [NativeName("systemId")]
    public ulong SystemId;

    [NativeName("createFlags")]
    public VulkanDeviceCreateFlagsKHR CreateFlags;

    [NativeName("pfnGetInstanceProcAddr")]
    public PfnVkGetInstanceProcAddr PfnGetInstanceProcAddr;

    [NativeName("vulkanPhysicalDevice")]
    public VkPhysicalDeviceHandle VulkanPhysicalDevice;

    [NativeName("vulkanCreateInfo")]
    public VkDeviceCreateInfoHandle VulkanCreateInfo;

    [NativeName("vulkanAllocator")]
    public VkAllocationCallbacksHandle VulkanAllocator;

    public VulkanDeviceCreateInfoKHR() { }
}
