// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VkDeviceFaultInfoEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkStructureType sType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public void* pNext;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceFaultInfoEXT_description description;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceFaultAddressInfoEXT* pAddressInfos;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceFaultVendorInfoEXT* pVendorInfos;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public void* pVendorBinaryData;
}
