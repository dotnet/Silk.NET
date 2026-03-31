// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkClusterAccelerationStructureAddressResolutionFlagBitsNV")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkClusterAccelerationStructureAddressResolutionFlagsNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionNone = 0,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedDstImplicitDataBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedScratchDataBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedDstAddressArrayBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedDstSizesArrayBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedSrcInfosArrayBit = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionIndirectedSrcInfosCountBit = 0x00000020,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_FLAG_BITS_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkClusterAccelerationStructureAddressResolutionFlagBitsMaxEnum = 0x7FFFFFFF,
}
