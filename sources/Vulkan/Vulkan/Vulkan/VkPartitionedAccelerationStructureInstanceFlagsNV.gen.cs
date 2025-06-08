// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum VkPartitionedAccelerationStructureInstanceFlagsNV
{
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV =
        0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV = 0x00000002,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV = 0x00000004,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV = 0x00000008,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV =
        0x00000010,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_BITS_MAX_ENUM_NV = 0x7FFFFFFF,
}
