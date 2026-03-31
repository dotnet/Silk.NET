// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "KhronosVendor", "NV")]
[NativeName("VkPartitionedAccelerationStructureInstanceFlagBitsNV")]
[NativeTypeName("unsigned int")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum VkPartitionedAccelerationStructureInstanceFlagsNV : uint
{
    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagTriangleFacingCullDisableBit = 0x00000001,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagTriangleFlipFacingBit = 0x00000002,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagForceOpaqueBit = 0x00000004,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagForceNoOpaqueBit = 0x00000008,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName(
        "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagEnableExplicitBoundingBox = 0x00000010,

    [NameAffix("Suffix", "KhronosImpliedVendor", "NV")]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_BITS_MAX_ENUM_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    VkPartitionedAccelerationStructureInstanceFlagBitsMaxEnum = 0x7FFFFFFF,
}
