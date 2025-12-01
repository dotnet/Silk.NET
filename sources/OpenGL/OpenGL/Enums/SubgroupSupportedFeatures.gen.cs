// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SubgroupSupportedFeatures")]
[Flags]
public enum SubgroupSupportedFeatures : uint
{
    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    BasicBitKHR = unchecked((uint)0x00000001),

    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    VoteBitKHR = unchecked((uint)0x00000002),

    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    ArithmeticBitKHR = unchecked((uint)0x00000004),

    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    BallotBitKHR = unchecked((uint)0x00000008),

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    ShuffleBitKHR = unchecked((uint)0x00000010),

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    ShuffleRelativeBitKHR = unchecked((uint)0x00000020),

    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    ClusteredBitKHR = unchecked((uint)0x00000040),

    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    QuadBitKHR = unchecked((uint)0x00000080),

    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    PartitionedBitNV = unchecked((uint)0x00000100),
}
