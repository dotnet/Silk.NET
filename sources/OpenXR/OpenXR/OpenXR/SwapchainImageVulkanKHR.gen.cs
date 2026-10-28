// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrSwapchainImageVulkanKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct SwapchainImageVulkanKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public StructureType Type = StructureType.SwapchainImageVulkanKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public void* Next;

    [NativeName("image")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public VkImageHandle Image;

    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public SwapchainImageVulkanKHR() { }
}
