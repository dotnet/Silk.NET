// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum SubgroupSupportedFeatures : uint
{
    BasicBitKHR = 0x00000001,
    VoteBitKHR = 0x00000002,
    ArithmeticBitKHR = 0x00000004,
    BallotBitKHR = 0x00000008,
    ShuffleBitKHR = 0x00000010,
    ShuffleRelativeBitKHR = 0x00000020,
    ClusteredBitKHR = 0x00000040,
    QuadBitKHR = 0x00000080,
    PartitionedBitNV = 0x00000100
}
