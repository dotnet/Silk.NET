// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkClusterAccelerationStructureAddressResolutionFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ClusterAccelerationStructureAddressResolutionFlagsNV : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_NONE_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    NoneNV = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedDstImplicitDataBitNV = 0x1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedScratchDataBitNV = 0x2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedDstAddressArrayBitNV = 0x4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedDstSizesArrayBitNV = 0x8,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedSrcInfosArrayBitNV = 0x10,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    IndirectedSrcInfosCountBitNV = 0x20,
}
