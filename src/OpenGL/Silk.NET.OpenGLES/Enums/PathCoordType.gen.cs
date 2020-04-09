// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum PathCoordType
    {
        ClosePathNV = 0x0,
        MoveToNV = 0x2,
        RelativeMoveToNV = 0x3,
        LineToNV = 0x4,
        RelativeLineToNV = 0x5,
        HorizontalLineToNV = 0x6,
        RelativeHorizontalLineToNV = 0x7,
        VerticalLineToNV = 0x8,
        RelativeVerticalLineToNV = 0x9,
        QuadraticCurveToNV = 0xA,
        RelativeQuadraticCurveToNV = 0xB,
        CubicCurveToNV = 0xC,
        RelativeCubicCurveToNV = 0xD,
        SmoothQuadraticCurveToNV = 0xE,
        RelativeSmoothQuadraticCurveToNV = 0xF,
        SmoothCubicCurveToNV = 0x10,
        RelativeSmoothCubicCurveToNV = 0x11,
        SmallCcwArcToNV = 0x12,
        RelativeSmallCcwArcToNV = 0x13,
        SmallCWArcToNV = 0x14,
        RelativeSmallCWArcToNV = 0x15,
        LargeCcwArcToNV = 0x16,
        RelativeLargeCcwArcToNV = 0x17,
        LargeCWArcToNV = 0x18,
        RelativeLargeCWArcToNV = 0x19,
        ConicCurveToNV = 0x1A,
        RelativeConicCurveToNV = 0x1B,
        RoundedRectNV = 0xE8,
        RelativeRoundedRectNV = 0xE9,
        RoundedRect2NV = 0xEA,
        RelativeRoundedRect2NV = 0xEB,
        RoundedRect4NV = 0xEC,
        RelativeRoundedRect4NV = 0xED,
        RoundedRect8NV = 0xEE,
        RelativeRoundedRect8NV = 0xEF,
        RestartPathNV = 0xF0,
        DupFirstCubicCurveToNV = 0xF2,
        DupLastCubicCurveToNV = 0xF4,
        RectNV = 0xF6,
        RelativeRectNV = 0xF7,
        CircularCcwArcToNV = 0xF8,
        CircularCWArcToNV = 0xFA,
        CircularTangentArcToNV = 0xFC,
        ArcToNV = 0xFE,
        RelativeArcToNV = 0xFF,
    }
}
