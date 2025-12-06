// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PathCoordType")]
public enum PathCoordType : uint
{
    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathNV = 0,

    [NativeName("GL_MOVE_TO_NV")]
    MoveToNV = 2,

    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveToNV = 3,

    [NativeName("GL_LINE_TO_NV")]
    LineToNV = 4,

    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineToNV = 5,

    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineToNV = 6,

    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineToNV = 7,

    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineToNV = 8,

    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineToNV = 9,

    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveToNV = 10,

    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveToNV = 11,

    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveToNV = 12,

    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveToNV = 13,

    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveToNV = 14,

    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveToNV = 15,

    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveToNV = 16,

    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveToNV = 17,

    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcToNV = 18,

    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcToNV = 19,

    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcToNV = 20,

    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcToNV = 21,

    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcToNV = 22,

    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcToNV = 23,

    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcToNV = 24,

    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcToNV = 25,

    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathNV = 240,

    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveToNV = 242,

    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveToNV = 244,

    [NativeName("GL_RECT_NV")]
    RectNV = 246,

    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcToNV = 248,

    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcToNV = 250,

    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcToNV = 252,

    [NativeName("GL_ARC_TO_NV")]
    ArcToNV = 254,

    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcToNV = 255,

    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectNV = 232,

    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectNV = 233,

    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2NV = 234,

    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2NV = 235,

    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4NV = 236,

    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4NV = 237,

    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8NV = 238,

    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8NV = 239,

    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectNV = 247,

    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveToNV = 26,

    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveToNV = 27,
}
