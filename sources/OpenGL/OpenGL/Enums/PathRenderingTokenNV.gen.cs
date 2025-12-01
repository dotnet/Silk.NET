// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathRenderingTokenNV")]
public enum PathRenderingTokenNV : uint
{
    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathNV = unchecked((uint)0x00),

    [NativeName("GL_MOVE_TO_NV")]
    MoveToNV = unchecked((uint)0x02),

    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveToNV = unchecked((uint)0x03),

    [NativeName("GL_LINE_TO_NV")]
    LineToNV = unchecked((uint)0x04),

    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineToNV = unchecked((uint)0x05),

    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineToNV = unchecked((uint)0x06),

    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineToNV = unchecked((uint)0x07),

    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineToNV = unchecked((uint)0x08),

    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineToNV = unchecked((uint)0x09),

    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveToNV = unchecked((uint)0x0A),

    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveToNV = unchecked((uint)0x0B),

    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveToNV = unchecked((uint)0x0C),

    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveToNV = unchecked((uint)0x0D),

    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveToNV = unchecked((uint)0x0E),

    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveToNV = unchecked((uint)0x0F),

    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveToNV = unchecked((uint)0x10),

    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveToNV = unchecked((uint)0x11),

    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcToNV = unchecked((uint)0x12),

    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcToNV = unchecked((uint)0x13),

    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcToNV = unchecked((uint)0x14),

    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcToNV = unchecked((uint)0x15),

    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcToNV = unchecked((uint)0x16),

    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcToNV = unchecked((uint)0x17),

    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcToNV = unchecked((uint)0x18),

    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcToNV = unchecked((uint)0x19),

    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathNV = unchecked((uint)0xF0),

    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveToNV = unchecked((uint)0xF2),

    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveToNV = unchecked((uint)0xF4),

    [NativeName("GL_RECT_NV")]
    RectNV = unchecked((uint)0xF6),

    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcToNV = unchecked((uint)0xF8),

    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcToNV = unchecked((uint)0xFA),

    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcToNV = unchecked((uint)0xFC),

    [NativeName("GL_ARC_TO_NV")]
    ArcToNV = unchecked((uint)0xFE),

    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcToNV = unchecked((uint)0xFF),

    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectNV = unchecked((uint)0xE8),

    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectNV = unchecked((uint)0xE9),

    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2NV = unchecked((uint)0xEA),

    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2NV = unchecked((uint)0xEB),

    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4NV = unchecked((uint)0xEC),

    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4NV = unchecked((uint)0xED),

    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8NV = unchecked((uint)0xEE),

    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8NV = unchecked((uint)0xEF),

    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectNV = unchecked((uint)0xF7),

    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveToNV = unchecked((uint)0x1A),

    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveToNV = unchecked((uint)0x1B),

    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdgeNV = unchecked((uint)0xC0),
}
