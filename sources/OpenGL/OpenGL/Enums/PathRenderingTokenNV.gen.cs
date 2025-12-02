// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("PathRenderingTokenNV")]
public enum PathRenderingTokenNV : uint
{
    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePath = unchecked((uint)0x00),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_MOVE_TO_NV")]
    MoveTo = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveTo = unchecked((uint)0x03),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_LINE_TO_NV")]
    LineTo = unchecked((uint)0x04),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineTo = unchecked((uint)0x05),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineTo = unchecked((uint)0x06),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineTo = unchecked((uint)0x07),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineTo = unchecked((uint)0x08),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineTo = unchecked((uint)0x09),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveTo = unchecked((uint)0x0A),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveTo = unchecked((uint)0x0B),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveTo = unchecked((uint)0x0C),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveTo = unchecked((uint)0x0D),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveTo = unchecked((uint)0x0E),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveTo = unchecked((uint)0x0F),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveTo = unchecked((uint)0x10),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveTo = unchecked((uint)0x11),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcTo = unchecked((uint)0x12),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcTo = unchecked((uint)0x13),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcTo = unchecked((uint)0x14),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcTo = unchecked((uint)0x15),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcTo = unchecked((uint)0x16),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcTo = unchecked((uint)0x17),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcTo = unchecked((uint)0x18),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcTo = unchecked((uint)0x19),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RESTART_PATH_NV")]
    RestartPath = unchecked((uint)0xF0),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveTo = unchecked((uint)0xF2),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveTo = unchecked((uint)0xF4),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RECT_NV")]
    Rect = unchecked((uint)0xF6),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcTo = unchecked((uint)0xF8),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcTo = unchecked((uint)0xFA),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcTo = unchecked((uint)0xFC),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_ARC_TO_NV")]
    ArcTo = unchecked((uint)0xFE),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcTo = unchecked((uint)0xFF),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRect = unchecked((uint)0xE8),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRect = unchecked((uint)0xE9),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2 = unchecked((uint)0xEA),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2 = unchecked((uint)0xEB),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4 = unchecked((uint)0xEC),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4 = unchecked((uint)0xED),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8 = unchecked((uint)0xEE),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8 = unchecked((uint)0xEF),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRect = unchecked((uint)0xF7),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveTo = unchecked((uint)0x1A),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveTo = unchecked((uint)0x1B),

    [NameAffix("Suffix", "NV", -1)]
    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdge = unchecked((uint)0xC0),
}
