// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DeviceAddressBindingCallbackDataEXT
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeTypeName("VkDeviceAddressBindingFlagsEXT")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public uint Flags;

    [NativeTypeName("VkDeviceAddress")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public ulong BaseAddress;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public ulong Size;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_address_binding_report"],
        ImpliesSets = [
            "VK_EXT_debug_utils+VK_KHR_get_physical_device_properties2",
            "VK_EXT_debug_utils+VK_VERSION_1_1",
        ]
    )]
    public DeviceAddressBindingTypeEXT BindingType;
}
