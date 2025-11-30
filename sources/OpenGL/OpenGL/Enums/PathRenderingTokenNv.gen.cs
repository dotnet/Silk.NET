// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "NV", 0)]
[NativeName("PathRenderingTokenNV")]
[Transformed]
public enum PathRenderingTokenNv : uint
{
    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CLOSE_PATH_NV")]
    ClosePathnv = unchecked((uint)0x00),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_MOVE_TO_NV")]
    MoveTonv = unchecked((uint)0x02),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_MOVE_TO_NV")]
    RelativeMoveTonv = unchecked((uint)0x03),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LINE_TO_NV")]
    LineTonv = unchecked((uint)0x04),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LINE_TO_NV")]
    RelativeLineTonv = unchecked((uint)0x05),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_HORIZONTAL_LINE_TO_NV")]
    HorizontalLineTonv = unchecked((uint)0x06),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_HORIZONTAL_LINE_TO_NV")]
    RelativeHorizontalLineTonv = unchecked((uint)0x07),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_VERTICAL_LINE_TO_NV")]
    VerticalLineTonv = unchecked((uint)0x08),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_VERTICAL_LINE_TO_NV")]
    RelativeVerticalLineTonv = unchecked((uint)0x09),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_QUADRATIC_CURVE_TO_NV")]
    QuadraticCurveTonv = unchecked((uint)0x0A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_QUADRATIC_CURVE_TO_NV")]
    RelativeQuadraticCurveTonv = unchecked((uint)0x0B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CUBIC_CURVE_TO_NV")]
    CubicCurveTonv = unchecked((uint)0x0C),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_CUBIC_CURVE_TO_NV")]
    RelativeCubicCurveTonv = unchecked((uint)0x0D),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    SmoothQuadraticCurveTonv = unchecked((uint)0x0E),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMOOTH_QUADRATIC_CURVE_TO_NV")]
    RelativeSmoothQuadraticCurveTonv = unchecked((uint)0x0F),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMOOTH_CUBIC_CURVE_TO_NV")]
    SmoothCubicCurveTonv = unchecked((uint)0x10),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMOOTH_CUBIC_CURVE_TO_NV")]
    RelativeSmoothCubicCurveTonv = unchecked((uint)0x11),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMALL_CCW_ARC_TO_NV")]
    SmallCcwArcTonv = unchecked((uint)0x12),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMALL_CCW_ARC_TO_NV")]
    RelativeSmallCcwArcTonv = unchecked((uint)0x13),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SMALL_CW_ARC_TO_NV")]
    SmallCwArcTonv = unchecked((uint)0x14),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_SMALL_CW_ARC_TO_NV")]
    RelativeSmallCwArcTonv = unchecked((uint)0x15),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LARGE_CCW_ARC_TO_NV")]
    LargeCcwArcTonv = unchecked((uint)0x16),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LARGE_CCW_ARC_TO_NV")]
    RelativeLargeCcwArcTonv = unchecked((uint)0x17),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_LARGE_CW_ARC_TO_NV")]
    LargeCwArcTonv = unchecked((uint)0x18),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_LARGE_CW_ARC_TO_NV")]
    RelativeLargeCwArcTonv = unchecked((uint)0x19),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RESTART_PATH_NV")]
    RestartPathnv = unchecked((uint)0xF0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DUP_FIRST_CUBIC_CURVE_TO_NV")]
    DupFirstCubicCurveTonv = unchecked((uint)0xF2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_DUP_LAST_CUBIC_CURVE_TO_NV")]
    DupLastCubicCurveTonv = unchecked((uint)0xF4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RECT_NV")]
    Rectnv = unchecked((uint)0xF6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_CCW_ARC_TO_NV")]
    CircularCcwArcTonv = unchecked((uint)0xF8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_CW_ARC_TO_NV")]
    CircularCwArcTonv = unchecked((uint)0xFA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CIRCULAR_TANGENT_ARC_TO_NV")]
    CircularTangentArcTonv = unchecked((uint)0xFC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ARC_TO_NV")]
    ArcTonv = unchecked((uint)0xFE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ARC_TO_NV")]
    RelativeArcTonv = unchecked((uint)0xFF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT_NV")]
    RoundedRectnv = unchecked((uint)0xE8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT_NV")]
    RelativeRoundedRectnv = unchecked((uint)0xE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT2_NV")]
    RoundedRect2Nv = unchecked((uint)0xEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT2_NV")]
    RelativeRoundedRect2Nv = unchecked((uint)0xEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT4_NV")]
    RoundedRect4Nv = unchecked((uint)0xEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT4_NV")]
    RelativeRoundedRect4Nv = unchecked((uint)0xED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_ROUNDED_RECT8_NV")]
    RoundedRect8Nv = unchecked((uint)0xEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_ROUNDED_RECT8_NV")]
    RelativeRoundedRect8Nv = unchecked((uint)0xEF),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_RECT_NV")]
    RelativeRectnv = unchecked((uint)0xF7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_CONIC_CURVE_TO_NV")]
    ConicCurveTonv = unchecked((uint)0x1A),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_RELATIVE_CONIC_CURVE_TO_NV")]
    RelativeConicCurveTonv = unchecked((uint)0x1B),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_SHARED_EDGE_NV")]
    SharedEdgenv = unchecked((uint)0xC0),
}
