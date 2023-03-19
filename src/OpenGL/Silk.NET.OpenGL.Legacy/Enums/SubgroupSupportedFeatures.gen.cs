// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "SubgroupSupportedFeatures")]
    public enum SubgroupSupportedFeatures : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"BasicBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
        SubgroupFeatureBasicBitKhr = 0x1,
        [Obsolete("Deprecated in favour of \"VoteBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
        SubgroupFeatureVoteBitKhr = 0x2,
        [Obsolete("Deprecated in favour of \"ArithmeticBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
        SubgroupFeatureArithmeticBitKhr = 0x4,
        [Obsolete("Deprecated in favour of \"BallotBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
        SubgroupFeatureBallotBitKhr = 0x8,
        [Obsolete("Deprecated in favour of \"ShuffleBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
        SubgroupFeatureShuffleBitKhr = 0x10,
        [Obsolete("Deprecated in favour of \"ShuffleRelativeBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
        SubgroupFeatureShuffleRelativeBitKhr = 0x20,
        [Obsolete("Deprecated in favour of \"ClusteredBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
        SubgroupFeatureClusteredBitKhr = 0x40,
        [Obsolete("Deprecated in favour of \"QuadBitKhr\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
        SubgroupFeatureQuadBitKhr = 0x80,
        [Obsolete("Deprecated in favour of \"PartitionedBitNV\"")]
        [NativeName("Name", "GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 0x100,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
        BasicBitKhr = 0x1,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
        VoteBitKhr = 0x2,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
        ArithmeticBitKhr = 0x4,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
        BallotBitKhr = 0x8,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
        ShuffleBitKhr = 0x10,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
        ShuffleRelativeBitKhr = 0x20,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
        ClusteredBitKhr = 0x40,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
        QuadBitKhr = 0x80,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        PartitionedBitNV = 0x100,
    }
}
