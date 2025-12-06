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
    ClosePath = 0,

    [NativeName("GL_MOVE_TO_NV")]
    MoveTo = 2,

    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveTo = 3,

    [NativeName("GL_LINE_TO_NV")]
    LineTo = 4,

    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineTo = 5,

    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineTo = 6,

    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineTo = 7,

    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineTo = 8,

    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineTo = 9,

    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveTo = 10,

    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveTo = 11,

    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveTo = 12,

    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveTo = 13,

    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveTo = 14,

    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveTo = 15,

    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveTo = 16,

    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveTo = 17,

    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcTo = 18,

    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcTo = 19,

    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcTo = 20,

    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcTo = 21,

    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcTo = 22,

    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcTo = 23,

    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcTo = 24,

    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcTo = 25,

    [NativeName("GL_RESTART_PATH_NV")]
    RestartPath = 240,

    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveTo = 242,

    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveTo = 244,

    [NativeName("GL_RECT_NV")]
    Rect = 246,

    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcTo = 248,

    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcTo = 250,

    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcTo = 252,

    [NativeName("GL_ARC_TO_NV")]
    ArcTo = 254,

    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcTo = 255,

    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRect = 232,

    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRect = 233,

    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2 = 234,

    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2 = 235,

    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4 = 236,

    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4 = 237,

    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8 = 238,

    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8 = 239,

    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRect = 247,

    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveTo = 26,

    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveTo = 27,

    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdge = 192,
}
