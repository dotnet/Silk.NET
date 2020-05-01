// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum SubgroupFeatureFlags
    {
        SubgroupFeatureBasicBit = 1,
        SubgroupFeatureVoteBit = 2,
        SubgroupFeatureArithmeticBit = 4,
        SubgroupFeatureBallotBit = 8,
        SubgroupFeatureShuffleBit = 16,
        SubgroupFeatureShuffleRelativeBit = 32,
        SubgroupFeatureClusteredBit = 64,
        SubgroupFeatureQuadBit = 128,
        SubgroupFeaturePartitionedBitNV = 256,
    }
}
