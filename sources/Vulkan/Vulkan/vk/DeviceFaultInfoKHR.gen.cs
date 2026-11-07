// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceFaultInfoKHR")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct DeviceFaultInfoKHR
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType = StructureType.DeviceFaultInfoKHR;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("flags")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultFlagsKHR Flags;

    [NativeName("groupId")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public ulong GroupId;

    [NativeName("description")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultInfoKHRDescription Description;

    [NativeName("faultAddressInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultAddressInfoKHR FaultAddressInfo;

    [NativeName("instructionAddressInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultAddressInfoKHR InstructionAddressInfo;

    [NativeName("vendorInfo")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultVendorInfoKHR VendorInfo;

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_device_fault"],
        ImpliesSets = [
            "VK_KHR_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_KHR_device_fault+VK_VERSION_1_1",
        ]
    )]
    public DeviceFaultInfoKHR() { }
}
