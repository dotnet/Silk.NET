// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum SubgroupSupportedFeatures
    {
        SubgroupFeatureBasicBitKhr = 0x1,
        SubgroupFeatureVoteBitKhr = 0x2,
        SubgroupFeatureArithmeticBitKhr = 0x4,
        SubgroupFeatureBallotBitKhr = 0x8,
        SubgroupFeatureShuffleBitKhr = 0x10,
        SubgroupFeatureShuffleRelativeBitKhr = 0x20,
        SubgroupFeatureClusteredBitKhr = 0x40,
        SubgroupFeatureQuadBitKhr = 0x80,
        SubgroupFeaturePartitionedBitNV = 0x100,
    }
}
