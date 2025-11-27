// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("NV", 0)]
[NativeName("VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
{
    [NativeName("sType")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    public void* PNext;

    [NativeName("extendedSparseAddressSpace")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_extended_sparse_address_space"],
        ImpliesSets = [
            "VK_NV_extended_sparse_address_space+VK_KHR_get_physical_device_properties2",
            "VK_NV_extended_sparse_address_space+VK_VERSION_1_1",
        ]
    )]
    public uint ExtendedSparseAddressSpace;
}
