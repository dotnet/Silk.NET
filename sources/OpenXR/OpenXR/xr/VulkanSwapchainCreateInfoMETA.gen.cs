// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrVulkanSwapchainCreateInfoMETA")]
[SupportedApiProfile("openxr")]
public unsafe partial struct VulkanSwapchainCreateInfoMETA
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    public StructureType Type = StructureType.VulkanSwapchainCreateInfoMETA;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    public void* Next;

    [NativeName("additionalCreateFlags")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    public uint AdditionalCreateFlags;

    [NativeName("additionalUsageFlags")]
    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    public uint AdditionalUsageFlags;

    [SupportedApiProfile("openxr", ["XR_META_vulkan_swapchain_create_info"])]
    public VulkanSwapchainCreateInfoMETA() { }
}
