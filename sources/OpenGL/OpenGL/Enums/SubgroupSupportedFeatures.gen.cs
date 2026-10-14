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
    None = 0x0,

    [NativeName("GL_SUBGROUP_FEATURE_BASIC_BIT_KHR")]
    BasicBitKHR = 0x1,

    [NativeName("GL_SUBGROUP_FEATURE_VOTE_BIT_KHR")]
    VoteBitKHR = 0x2,

    [NativeName("GL_SUBGROUP_FEATURE_ARITHMETIC_BIT_KHR")]
    ArithmeticBitKHR = 0x4,

    [NativeName("GL_SUBGROUP_FEATURE_BALLOT_BIT_KHR")]
    BallotBitKHR = 0x8,

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_BIT_KHR")]
    ShuffleBitKHR = 0x10,

    [NativeName("GL_SUBGROUP_FEATURE_SHUFFLE_RELATIVE_BIT_KHR")]
    ShuffleRelativeBitKHR = 0x20,

    [NativeName("GL_SUBGROUP_FEATURE_CLUSTERED_BIT_KHR")]
    ClusteredBitKHR = 0x40,

    [NativeName("GL_SUBGROUP_FEATURE_QUAD_BIT_KHR")]
    QuadBitKHR = 0x80,

    [NativeName("GL_SUBGROUP_FEATURE_PARTITIONED_BIT_NV")]
    PartitionedBitNV = 0x100,
}
