// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVulkanGraphicsDeviceGetInfoKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VulkanGraphicsDeviceGetInfoKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public StructureType Type = StructureType.VulkanGraphicsDeviceGetInfoKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public void* Next;

    [NativeName("systemId")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public ulong SystemId;

    [NativeName("vulkanInstance")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VkInstanceHandle VulkanInstance;

    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable2"])]
    public VulkanGraphicsDeviceGetInfoKHR() { }
}
