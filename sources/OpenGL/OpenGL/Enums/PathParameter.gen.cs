// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathParameter : uint
{
    StrokeWidthNV = unchecked((uint)0x9075),
    EndCapsNV = unchecked((uint)0x9076),
    InitialEndCapNV = unchecked((uint)0x9077),
    TerminalEndCapNV = unchecked((uint)0x9078),
    JoinStyleNV = unchecked((uint)0x9079),
    MiterLimitNV = unchecked((uint)0x907A),
    DashCapsNV = unchecked((uint)0x907B),
    InitialDashCapNV = unchecked((uint)0x907C),
    TerminalDashCapNV = unchecked((uint)0x907D),
    DashOffsetNV = unchecked((uint)0x907E),
    ClientLengthNV = unchecked((uint)0x907F),
    FillModeNV = unchecked((uint)0x9080),
    FillMaskNV = unchecked((uint)0x9081),
    FillCoverModeNV = unchecked((uint)0x9082),
    StrokeCoverModeNV = unchecked((uint)0x9083),
    StrokeMaskNV = unchecked((uint)0x9084),
    ObjectBoundingBoxNV = unchecked((uint)0x908A),
    CommandCountNV = unchecked((uint)0x909D),
    CoordCountNV = unchecked((uint)0x909E),
    DashArrayCountNV = unchecked((uint)0x909F),
    ComputedLengthNV = unchecked((uint)0x90A0),
    FillBoundingBoxNV = unchecked((uint)0x90A1),
    StrokeBoundingBoxNV = unchecked((uint)0x90A2),
    DashOffsetResetNV = unchecked((uint)0x90B4),
}
