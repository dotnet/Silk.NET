// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathCoordType : uint
{
    ClosePathNV = 0x00,
    MoveToNV = 0x02,
    RelativeMoveToNV = 0x03,
    LineToNV = 0x04,
    RelativeLineToNV = 0x05,
    HorizontalLineToNV = 0x06,
    RelativeHorizontalLineToNV = 0x07,
    VerticalLineToNV = 0x08,
    RelativeVerticalLineToNV = 0x09,
    QuadraticCurveToNV = 0x0A,
    RelativeQuadraticCurveToNV = 0x0B,
    CubicCurveToNV = 0x0C,
    RelativeCubicCurveToNV = 0x0D,
    SmoothQuadraticCurveToNV = 0x0E,
    RelativeSmoothQuadraticCurveToNV = 0x0F,
    SmoothCubicCurveToNV = 0x10,
    RelativeSmoothCubicCurveToNV = 0x11,
    SmallCcwArcToNV = 0x12,
    RelativeSmallCcwArcToNV = 0x13,
    SmallCwArcToNV = 0x14,
    RelativeSmallCwArcToNV = 0x15,
    LargeCcwArcToNV = 0x16,
    RelativeLargeCcwArcToNV = 0x17,
    LargeCwArcToNV = 0x18,
    RelativeLargeCwArcToNV = 0x19,
    RestartPathNV = 0xF0,
    DupFirstCubicCurveToNV = 0xF2,
    DupLastCubicCurveToNV = 0xF4,
    RectNV = 0xF6,
    CircularCcwArcToNV = 0xF8,
    CircularCwArcToNV = 0xFA,
    CircularTangentArcToNV = 0xFC,
    ArcToNV = 0xFE,
    RelativeArcToNV = 0xFF,
    RoundedRectNV = 0xE8,
    RelativeRoundedRectNV = 0xE9,
    RoundedRect2NV = 0xEA,
    RelativeRoundedRect2NV = 0xEB,
    RoundedRect4NV = 0xEC,
    RelativeRoundedRect4NV = 0xED,
    RoundedRect8NV = 0xEE,
    RelativeRoundedRect8NV = 0xEF,
    RelativeRectNV = 0xF7,
    ConicCurveToNV = 0x1A,
    RelativeConicCurveToNV = 0x1B
}
