// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgAngleType
{
    SVG_ANGLETYPE_UNKNOWN = 0,
    SVG_ANGLETYPE_UNSPECIFIED = 1,
    SVG_ANGLETYPE_DEG = 2,
    SVG_ANGLETYPE_RAD = 3,
    SVG_ANGLETYPE_GRAD = 4,
    svgAngleType_Max = 2147483647,
}
