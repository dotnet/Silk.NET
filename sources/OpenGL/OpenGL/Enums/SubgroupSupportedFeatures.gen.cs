// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SubgroupSupportedFeatures : uint
{
    BasicBitKHR = unchecked((uint)0x00000001),
    VoteBitKHR = unchecked((uint)0x00000002),
    ArithmeticBitKHR = unchecked((uint)0x00000004),
    BallotBitKHR = unchecked((uint)0x00000008),
    ShuffleBitKHR = unchecked((uint)0x00000010),
    ShuffleRelativeBitKHR = unchecked((uint)0x00000020),
    ClusteredBitKHR = unchecked((uint)0x00000040),
    QuadBitKHR = unchecked((uint)0x00000080),
    PartitionedBitNV = unchecked((uint)0x00000100),
}
