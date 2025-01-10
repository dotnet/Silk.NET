// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgLengthType
{
    SVG_LENGTHTYPE_UNKNOWN = 0,
    SVG_LENGTHTYPE_NUMBER = 1,
    SVG_LENGTHTYPE_PERCENTAGE = 2,
    SVG_LENGTHTYPE_EMS = 3,
    SVG_LENGTHTYPE_EXS = 4,
    SVG_LENGTHTYPE_PX = 5,
    SVG_LENGTHTYPE_CM = 6,
    SVG_LENGTHTYPE_MM = 7,
    SVG_LENGTHTYPE_IN = 8,
    SVG_LENGTHTYPE_PT = 9,
    SVG_LENGTHTYPE_PC = 10,
    svgLengthType_Max = 2147483647,
}
