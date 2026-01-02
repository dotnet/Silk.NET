// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathCoordType : uint
{
    ClosePathNV = unchecked((uint)0x00),
    MoveToNV = unchecked((uint)0x02),
    RelativeMoveToNV = unchecked((uint)0x03),
    LineToNV = unchecked((uint)0x04),
    RelativeLineToNV = unchecked((uint)0x05),
    HorizontalLineToNV = unchecked((uint)0x06),
    RelativeHorizontalLineToNV = unchecked((uint)0x07),
    VerticalLineToNV = unchecked((uint)0x08),
    RelativeVerticalLineToNV = unchecked((uint)0x09),
    QuadraticCurveToNV = unchecked((uint)0x0A),
    RelativeQuadraticCurveToNV = unchecked((uint)0x0B),
    CubicCurveToNV = unchecked((uint)0x0C),
    RelativeCubicCurveToNV = unchecked((uint)0x0D),
    SmoothQuadraticCurveToNV = unchecked((uint)0x0E),
    RelativeSmoothQuadraticCurveToNV = unchecked((uint)0x0F),
    SmoothCubicCurveToNV = unchecked((uint)0x10),
    RelativeSmoothCubicCurveToNV = unchecked((uint)0x11),
    SmallCcwArcToNV = unchecked((uint)0x12),
    RelativeSmallCcwArcToNV = unchecked((uint)0x13),
    SmallCwArcToNV = unchecked((uint)0x14),
    RelativeSmallCwArcToNV = unchecked((uint)0x15),
    LargeCcwArcToNV = unchecked((uint)0x16),
    RelativeLargeCcwArcToNV = unchecked((uint)0x17),
    LargeCwArcToNV = unchecked((uint)0x18),
    RelativeLargeCwArcToNV = unchecked((uint)0x19),
    RestartPathNV = unchecked((uint)0xF0),
    DupFirstCubicCurveToNV = unchecked((uint)0xF2),
    DupLastCubicCurveToNV = unchecked((uint)0xF4),
    RectNV = unchecked((uint)0xF6),
    CircularCcwArcToNV = unchecked((uint)0xF8),
    CircularCwArcToNV = unchecked((uint)0xFA),
    CircularTangentArcToNV = unchecked((uint)0xFC),
    ArcToNV = unchecked((uint)0xFE),
    RelativeArcToNV = unchecked((uint)0xFF),
    RoundedRectNV = unchecked((uint)0xE8),
    RelativeRoundedRectNV = unchecked((uint)0xE9),
    RoundedRect2NV = unchecked((uint)0xEA),
    RelativeRoundedRect2NV = unchecked((uint)0xEB),
    RoundedRect4NV = unchecked((uint)0xEC),
    RelativeRoundedRect4NV = unchecked((uint)0xED),
    RoundedRect8NV = unchecked((uint)0xEE),
    RelativeRoundedRect8NV = unchecked((uint)0xEF),
    RelativeRectNV = unchecked((uint)0xF7),
    ConicCurveToNV = unchecked((uint)0x1A),
    RelativeConicCurveToNV = unchecked((uint)0x1B),
}
