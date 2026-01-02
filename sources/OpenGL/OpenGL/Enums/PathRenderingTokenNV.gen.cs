// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum PathRenderingTokenNV : uint
{
    ClosePath = unchecked((uint)0x00),
    MoveTo = unchecked((uint)0x02),
    RelativeMoveTo = unchecked((uint)0x03),
    LineTo = unchecked((uint)0x04),
    RelativeLineTo = unchecked((uint)0x05),
    HorizontalLineTo = unchecked((uint)0x06),
    RelativeHorizontalLineTo = unchecked((uint)0x07),
    VerticalLineTo = unchecked((uint)0x08),
    RelativeVerticalLineTo = unchecked((uint)0x09),
    QuadraticCurveTo = unchecked((uint)0x0A),
    RelativeQuadraticCurveTo = unchecked((uint)0x0B),
    CubicCurveTo = unchecked((uint)0x0C),
    RelativeCubicCurveTo = unchecked((uint)0x0D),
    SmoothQuadraticCurveTo = unchecked((uint)0x0E),
    RelativeSmoothQuadraticCurveTo = unchecked((uint)0x0F),
    SmoothCubicCurveTo = unchecked((uint)0x10),
    RelativeSmoothCubicCurveTo = unchecked((uint)0x11),
    SmallCcwArcTo = unchecked((uint)0x12),
    RelativeSmallCcwArcTo = unchecked((uint)0x13),
    SmallCwArcTo = unchecked((uint)0x14),
    RelativeSmallCwArcTo = unchecked((uint)0x15),
    LargeCcwArcTo = unchecked((uint)0x16),
    RelativeLargeCcwArcTo = unchecked((uint)0x17),
    LargeCwArcTo = unchecked((uint)0x18),
    RelativeLargeCwArcTo = unchecked((uint)0x19),
    RestartPath = unchecked((uint)0xF0),
    DupFirstCubicCurveTo = unchecked((uint)0xF2),
    DupLastCubicCurveTo = unchecked((uint)0xF4),
    Rect = unchecked((uint)0xF6),
    CircularCcwArcTo = unchecked((uint)0xF8),
    CircularCwArcTo = unchecked((uint)0xFA),
    CircularTangentArcTo = unchecked((uint)0xFC),
    ArcTo = unchecked((uint)0xFE),
    RelativeArcTo = unchecked((uint)0xFF),
    RoundedRect = unchecked((uint)0xE8),
    RelativeRoundedRect = unchecked((uint)0xE9),
    RoundedRect2 = unchecked((uint)0xEA),
    RelativeRoundedRect2 = unchecked((uint)0xEB),
    RoundedRect4 = unchecked((uint)0xEC),
    RelativeRoundedRect4 = unchecked((uint)0xED),
    RoundedRect8 = unchecked((uint)0xEE),
    RelativeRoundedRect8 = unchecked((uint)0xEF),
    RelativeRect = unchecked((uint)0xF7),
    ConicCurveTo = unchecked((uint)0x1A),
    RelativeConicCurveTo = unchecked((uint)0x1B),
    SharedEdge = unchecked((uint)0xC0),
}
