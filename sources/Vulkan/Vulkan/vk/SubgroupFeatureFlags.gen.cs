// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSubgroupFeatureFlags")]
[Flags]
public enum SubgroupFeatureFlags : uint
{
    None = 0x0,

    [NativeName("VK_SUBGROUP_FEATURE_BASIC_BIT")]
    BasicBit = 0x1,

    [NativeName("VK_SUBGROUP_FEATURE_VOTE_BIT")]
    VoteBit = 0x2,

    [NativeName("VK_SUBGROUP_FEATURE_ARITHMETIC_BIT")]
    ArithmeticBit = 0x4,

    [NativeName("VK_SUBGROUP_FEATURE_BALLOT_BIT")]
    BallotBit = 0x8,

    [NativeName("VK_SUBGROUP_FEATURE_SHUFFLE_BIT")]
    ShuffleBit = 0x10,

    [NativeName("VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT")]
    ShuffleRelativeBit = 0x20,

    [NativeName("VK_SUBGROUP_FEATURE_CLUSTERED_BIT")]
    ClusteredBit = 0x40,

    [NativeName("VK_SUBGROUP_FEATURE_QUAD_BIT")]
    QuadBit = 0x80,

    [NativeName("VK_SUBGROUP_FEATURE_ROTATE_BIT")]
    RotateBit = 0x200,

    [NativeName("VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT")]
    RotateClusteredBit = 0x400,

    [NativeName("VK_SUBGROUP_FEATURE_PARTITIONED_BIT_EXT")]
    PartitionedBitEXT = 0x100,

    [NativeName("VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    PartitionedBitNV = PartitionedBitEXT,

    [NativeName("VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR")]
    RotateBitKHR = RotateBit,

    [NativeName("VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR")]
    RotateClusteredBitKHR = RotateClusteredBit,
}
