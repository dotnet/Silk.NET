// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgPathSegType
{
    PATHSEG_UNKNOWN = 0,
    PATHSEG_CLOSEPATH = 1,
    PATHSEG_MOVETO_ABS = 2,
    PATHSEG_MOVETO_REL = 3,
    PATHSEG_LINETO_ABS = 4,
    PATHSEG_LINETO_REL = 5,
    PATHSEG_CURVETO_CUBIC_ABS = 6,
    PATHSEG_CURVETO_CUBIC_REL = 7,
    PATHSEG_CURVETO_QUADRATIC_ABS = 8,
    PATHSEG_CURVETO_QUADRATIC_REL = 9,
    PATHSEG_ARC_ABS = 10,
    PATHSEG_ARC_REL = 11,
    PATHSEG_LINETO_HORIZONTAL_ABS = 12,
    PATHSEG_LINETO_HORIZONTAL_REL = 13,
    PATHSEG_LINETO_VERTICAL_ABS = 14,
    PATHSEG_LINETO_VERTICAL_REL = 15,
    PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16,
    PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17,
    PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18,
    PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19,
    svgPathSegType_Max = 2147483647,
}
