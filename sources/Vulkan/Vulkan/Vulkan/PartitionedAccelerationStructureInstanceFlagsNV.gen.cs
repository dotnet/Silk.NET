// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkPartitionedAccelerationStructureInstanceFlagBitsNV")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum PartitionedAccelerationStructureInstanceFlagsNV : uint
{
    None = 0x0,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FACING_CULL_DISABLE_BIT_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    TriangleFacingCullDisableBitNV = 0x1,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_TRIANGLE_FLIP_FACING_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    TriangleFlipFacingBitNV = 0x2,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_OPAQUE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ForceOpaqueBitNV = 0x4,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_FORCE_NO_OPAQUE_BIT_NV")]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    ForceNoOpaqueBitNV = 0x8,

    [NameAffix("Suffix", "NV", 0)]
    [NativeName(
        "VK_PARTITIONED_ACCELERATION_STRUCTURE_INSTANCE_FLAG_ENABLE_EXPLICIT_BOUNDING_BOX_NV"
    )]
    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_partitioned_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"]
    )]
    EnableExplicitBoundingBoxNV = 0x10,
}
