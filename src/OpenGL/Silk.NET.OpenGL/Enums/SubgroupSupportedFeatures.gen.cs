// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "SubgroupSupportedFeatures")]
    public enum SubgroupSupportedFeatures : int
    {
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
        SubgroupFeatureBasicBitKhr = 0x1,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
        SubgroupFeatureVoteBitKhr = 0x2,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
        SubgroupFeatureArithmeticBitKhr = 0x4,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
        SubgroupFeatureBallotBitKhr = 0x8,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
        SubgroupFeatureShuffleBitKhr = 0x10,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
        SubgroupFeatureShuffleRelativeBitKhr = 0x20,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
        SubgroupFeatureClusteredBitKhr = 0x40,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
        SubgroupFeatureQuadBitKhr = 0x80,
        [NativeName("Name", "GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
        SubgroupFeaturePartitionedBitNV = 0x100,
    }
}
