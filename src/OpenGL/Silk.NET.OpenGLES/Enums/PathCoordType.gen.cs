// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "PathCoordType")]
    public enum PathCoordType : int
    {
        [NativeName("Name", "GL_CLOSE_PATH_NV")]
        ClosePathNV = 0x0,
        [NativeName("Name", "GL_MOVE_TO_NV")]
        MoveToNV = 0x2,
        [NativeName("Name", "GL_RELATIVE_MOVE_TO_NV")]
        RelativeMoveToNV = 0x3,
        [NativeName("Name", "GL_LINE_TO_NV")]
        LineToNV = 0x4,
        [NativeName("Name", "GL_RELATIVE_LINE_TO_NV")]
        RelativeLineToNV = 0x5,
        [NativeName("Name", "GL_HORIZONTAL_LINE_TO_NV")]
        HorizontalLineToNV = 0x6,
        [NativeName("Name", "GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
        RelativeHorizontalLineToNV = 0x7,
        [NativeName("Name", "GL_VERTICAL_LINE_TO_NV")]
        VerticalLineToNV = 0x8,
        [NativeName("Name", "GL_RELATIVE_VERTICAL_LINE_TO_NV")]
        RelativeVerticalLineToNV = 0x9,
        [NativeName("Name", "GL_QUADRATIC_CURVE_TO_NV")]
        QuadraticCurveToNV = 0xA,
        [NativeName("Name", "GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
        RelativeQuadraticCurveToNV = 0xB,
        [NativeName("Name", "GL_CUBIC_CURVE_TO_NV")]
        CubicCurveToNV = 0xC,
        [NativeName("Name", "GL_RELATIVE_CUBIC_CURVE_TO_NV")]
        RelativeCubicCurveToNV = 0xD,
        [NativeName("Name", "GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
        SmoothQuadraticCurveToNV = 0xE,
        [NativeName("Name", "GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
        RelativeSmoothQuadraticCurveToNV = 0xF,
        [NativeName("Name", "GL_SMOOTH_CUBIC_CURVE_TO_NV")]
        SmoothCubicCurveToNV = 0x10,
        [NativeName("Name", "GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
        RelativeSmoothCubicCurveToNV = 0x11,
        [NativeName("Name", "GL_SMALL_CCW_ARC_TO_NV")]
        SmallCcwArcToNV = 0x12,
        [NativeName("Name", "GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
        RelativeSmallCcwArcToNV = 0x13,
        [NativeName("Name", "GL_SMALL_CW_ARC_TO_NV")]
        SmallCWArcToNV = 0x14,
        [NativeName("Name", "GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
        RelativeSmallCWArcToNV = 0x15,
        [NativeName("Name", "GL_LARGE_CCW_ARC_TO_NV")]
        LargeCcwArcToNV = 0x16,
        [NativeName("Name", "GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
        RelativeLargeCcwArcToNV = 0x17,
        [NativeName("Name", "GL_LARGE_CW_ARC_TO_NV")]
        LargeCWArcToNV = 0x18,
        [NativeName("Name", "GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
        RelativeLargeCWArcToNV = 0x19,
        [NativeName("Name", "GL_CONIC_CURVE_TO_NV")]
        ConicCurveToNV = 0x1A,
        [NativeName("Name", "GL_RELATIVE_CONIC_CURVE_TO_NV")]
        RelativeConicCurveToNV = 0x1B,
        [NativeName("Name", "GL_ROUNDED_RECT_NV")]
        RoundedRectNV = 0xE8,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT_NV")]
        RelativeRoundedRectNV = 0xE9,
        [NativeName("Name", "GL_ROUNDED_RECT2_NV")]
        RoundedRect2NV = 0xEA,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT2_NV")]
        RelativeRoundedRect2NV = 0xEB,
        [NativeName("Name", "GL_ROUNDED_RECT4_NV")]
        RoundedRect4NV = 0xEC,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT4_NV")]
        RelativeRoundedRect4NV = 0xED,
        [NativeName("Name", "GL_ROUNDED_RECT8_NV")]
        RoundedRect8NV = 0xEE,
        [NativeName("Name", "GL_RELATIVE_ROUNDED_RECT8_NV")]
        RelativeRoundedRect8NV = 0xEF,
        [NativeName("Name", "GL_RESTART_PATH_NV")]
        RestartPathNV = 0xF0,
        [NativeName("Name", "GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
        DupFirstCubicCurveToNV = 0xF2,
        [NativeName("Name", "GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
        DupLastCubicCurveToNV = 0xF4,
        [NativeName("Name", "GL_RECT_NV")]
        RectNV = 0xF6,
        [NativeName("Name", "GL_RELATIVE_RECT_NV")]
        RelativeRectNV = 0xF7,
        [NativeName("Name", "GL_CIRCULAR_CCW_ARC_TO_NV")]
        CircularCcwArcToNV = 0xF8,
        [NativeName("Name", "GL_CIRCULAR_CW_ARC_TO_NV")]
        CircularCWArcToNV = 0xFA,
        [NativeName("Name", "GL_CIRCULAR_TANGENT_ARC_TO_NV")]
        CircularTangentArcToNV = 0xFC,
        [NativeName("Name", "GL_ARC_TO_NV")]
        ArcToNV = 0xFE,
        [NativeName("Name", "GL_RELATIVE_ARC_TO_NV")]
        RelativeArcToNV = 0xFF,
    }
}
