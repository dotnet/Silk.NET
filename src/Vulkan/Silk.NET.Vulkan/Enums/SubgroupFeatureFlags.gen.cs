// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkSubgroupFeatureFlags")]
    public enum SubgroupFeatureFlags : int
    {
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BASIC_BIT")]
        SubgroupFeatureBasicBit = 1,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_VOTE_BIT")]
        SubgroupFeatureVoteBit = 2,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_ARITHMETIC_BIT")]
        SubgroupFeatureArithmeticBit = 4,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_BALLOT_BIT")]
        SubgroupFeatureBallotBit = 8,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_BIT")]
        SubgroupFeatureShuffleBit = 16,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT")]
        SubgroupFeatureShuffleRelativeBit = 32,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_CLUSTERED_BIT")]
        SubgroupFeatureClusteredBit = 64,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_QUAD_BIT")]
        SubgroupFeatureQuadBit = 128,
        [NativeName("Name", "VK_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 256,
    }
}
