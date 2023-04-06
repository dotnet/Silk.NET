// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_PATH_COMMAND")]
    public enum SvgPathCommand : int
    {
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CLOSE_PATH")]
        ClosePath = 0x0,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_ABSOLUTE")]
        MoveAbsolute = 0x1,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_MOVE_RELATIVE")]
        MoveRelative = 0x2,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_ABSOLUTE")]
        LineAbsolute = 0x3,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_LINE_RELATIVE")]
        LineRelative = 0x4,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_ABSOLUTE")]
        CubicAbsolute = 0x5,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_RELATIVE")]
        CubicRelative = 0x6,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_ABSOLUTE")]
        QuadradicAbsolute = 0x7,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_RELATIVE")]
        QuadradicRelative = 0x8,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_ABSOLUTE")]
        ArcAbsolute = 0x9,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_ARC_RELATIVE")]
        ArcRelative = 0xA,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_ABSOLUTE")]
        HorizontalAbsolute = 0xB,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_HORIZONTAL_RELATIVE")]
        HorizontalRelative = 0xC,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_ABSOLUTE")]
        VerticalAbsolute = 0xD,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_VERTICAL_RELATIVE")]
        VerticalRelative = 0xE,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_ABSOLUTE")]
        CubicSmoothAbsolute = 0xF,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_CUBIC_SMOOTH_RELATIVE")]
        CubicSmoothRelative = 0x10,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_ABSOLUTE")]
        QuadradicSmoothAbsolute = 0x11,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_QUADRADIC_SMOOTH_RELATIVE")]
        QuadradicSmoothRelative = 0x12,
        [NativeName("Name", "D2D1_SVG_PATH_COMMAND_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
