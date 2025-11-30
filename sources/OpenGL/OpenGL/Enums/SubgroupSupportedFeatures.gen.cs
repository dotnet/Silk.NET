// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SubgroupSupportedFeatures")]
[Transformed]
[Flags]
public enum SubgroupSupportedFeatures : uint
{
    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    BasicBitkhr = unchecked((uint)0x00000001),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    VoteBitkhr = unchecked((uint)0x00000002),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    ArithmeticBitkhr = unchecked((uint)0x00000004),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    BallotBitkhr = unchecked((uint)0x00000008),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    ShuffleBitkhr = unchecked((uint)0x00000010),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    ShuffleRelativeBitkhr = unchecked((uint)0x00000020),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    ClusteredBitkhr = unchecked((uint)0x00000040),

    [NameAffix("Suffix", "KHR", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    QuadBitkhr = unchecked((uint)0x00000080),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    PartitionedBitnv = unchecked((uint)0x00000100),
}
