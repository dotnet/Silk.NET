// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum PathRenderingTokenNV
{
    ClosePath = 0x00,
    MoveTo = 0x02,
    RelativeMoveTo = 0x03,
    LineTo = 0x04,
    RelativeLineTo = 0x05,
    HorizontalLineTo = 0x06,
    RelativeHorizontalLineTo = 0x07,
    VerticalLineTo = 0x08,
    RelativeVerticalLineTo = 0x09,
    QuadraticCurveTo = 0x0A,
    RelativeQuadraticCurveTo = 0x0B,
    CubicCurveTo = 0x0C,
    RelativeCubicCurveTo = 0x0D,
    SmoothQuadraticCurveTo = 0x0E,
    RelativeSmoothQuadraticCurveTo = 0x0F,
    SmoothCubicCurveTo = 0x10,
    RelativeSmoothCubicCurveTo = 0x11,
    SmallCcwArcTo = 0x12,
    RelativeSmallCcwArcTo = 0x13,
    SmallCwArcTo = 0x14,
    RelativeSmallCwArcTo = 0x15,
    LargeCcwArcTo = 0x16,
    RelativeLargeCcwArcTo = 0x17,
    LargeCwArcTo = 0x18,
    RelativeLargeCwArcTo = 0x19,
    RestartPath = 0xF0,
    DupFirstCubicCurveTo = 0xF2,
    DupLastCubicCurveTo = 0xF4,
    Rect = 0xF6,
    CircularCcwArcTo = 0xF8,
    CircularCwArcTo = 0xFA,
    CircularTangentArcTo = 0xFC,
    ArcTo = 0xFE,
    RelativeArcTo = 0xFF,
    RoundedRect = 0xE8,
    RelativeRoundedRect = 0xE9,
    RoundedRect2 = 0xEA,
    RelativeRoundedRect2 = 0xEB,
    RoundedRect4 = 0xEC,
    RelativeRoundedRect4 = 0xED,
    RoundedRect8 = 0xEE,
    RelativeRoundedRect8 = 0xEF,
    RelativeRect = 0xF7,
    ConicCurveTo = 0x1A,
    RelativeConicCurveTo = 0x1B,
    SharedEdge = 0xC0
}
