// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrGraphicsBindingVulkanKHR")]
[SupportedApiProfile("openxr")]
public unsafe partial struct GraphicsBindingVulkanKHR
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public StructureType Type = StructureType.GraphicsBindingVulkanKHR;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public void* Next;

    [NativeName("instance")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public VkInstanceHandle Instance;

    [NativeName("physicalDevice")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public VkPhysicalDeviceHandle PhysicalDevice;

    [NativeName("device")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public VkDeviceHandle Device;

    [NativeName("queueFamilyIndex")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public uint QueueFamilyIndex;

    [NativeName("queueIndex")]
    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public uint QueueIndex;

    [SupportedApiProfile("openxr", ["XR_KHR_vulkan_enable"])]
    public GraphicsBindingVulkanKHR() { }
}
