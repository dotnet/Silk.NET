// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkClusterAccelerationStructureAddressResolutionFlagsNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_IMPLICIT_DATA_BIT_NV =
        0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SCRATCH_DATA_BIT_NV =
        0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_ADDRESS_ARRAY_BIT_NV =
        0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_DST_SIZES_ARRAY_BIT_NV =
        0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_ARRAY_BIT_NV =
        0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_INDIRECTED_SRC_INFOS_COUNT_BIT_NV =
        0x00000020,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_CLUSTER_ACCELERATION_STRUCTURE_ADDRESS_RESOLUTION_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
