// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSubgroupFeatureFlags")]
    public enum SubgroupFeatureFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BasicBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BASIC_BIT")]
        SubgroupFeatureBasicBit = 1,
        [Obsolete("Deprecated in favour of \"VoteBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_VOTE_BIT")]
        SubgroupFeatureVoteBit = 2,
        [Obsolete("Deprecated in favour of \"ArithmeticBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ARITHMETIC_BIT")]
        SubgroupFeatureArithmeticBit = 4,
        [Obsolete("Deprecated in favour of \"BallotBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BALLOT_BIT")]
        SubgroupFeatureBallotBit = 8,
        [Obsolete("Deprecated in favour of \"ShuffleBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_BIT")]
        SubgroupFeatureShuffleBit = 16,
        [Obsolete("Deprecated in favour of \"ShuffleRelativeBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT")]
        SubgroupFeatureShuffleRelativeBit = 32,
        [Obsolete("Deprecated in favour of \"ClusteredBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_CLUSTERED_BIT")]
        SubgroupFeatureClusteredBit = 64,
        [Obsolete("Deprecated in favour of \"QuadBit\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_QUAD_BIT")]
        SubgroupFeatureQuadBit = 128,
        [Obsolete("Deprecated in favour of \"PartitionedBitNV\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 256,
        [Obsolete("Deprecated in favour of \"RotateBitKhr\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR")]
        SubgroupFeatureRotateBitKhr = 512,
        [Obsolete("Deprecated in favour of \"RotateClusteredBitKhr\"")]
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR")]
        SubgroupFeatureRotateClusteredBitKhr = 1024,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BASIC_BIT")]
        BasicBit = 1,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_VOTE_BIT")]
        VoteBit = 2,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ARITHMETIC_BIT")]
        ArithmeticBit = 4,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BALLOT_BIT")]
        BallotBit = 8,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_BIT")]
        ShuffleBit = 16,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT")]
        ShuffleRelativeBit = 32,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_CLUSTERED_BIT")]
        ClusteredBit = 64,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_QUAD_BIT")]
        QuadBit = 128,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        PartitionedBitNV = 256,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ROTATE_BIT_KHR")]
        RotateBitKhr = 512,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ROTATE_CLUSTERED_BIT_KHR")]
        RotateClusteredBitKhr = 1024,
    }
}
