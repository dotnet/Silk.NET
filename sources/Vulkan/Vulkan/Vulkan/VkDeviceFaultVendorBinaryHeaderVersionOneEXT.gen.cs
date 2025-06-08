// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint headerSize;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint vendorID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint deviceID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint driverVersion;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public VkDeviceFaultVendorBinaryHeaderVersionOneEXT_pipelineCacheUUID pipelineCacheUUID;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint applicationNameOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint applicationVersion;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint engineNameOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint engineVersion;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_fault"],
        ImpliesSets = [
            "VK_EXT_device_fault+VK_KHR_get_physical_device_properties2",
            "VK_EXT_device_fault+VK_VERSION_1_1",
        ]
    )]
    public uint apiVersion;
}
