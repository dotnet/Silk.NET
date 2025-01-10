// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgTransformType
{
    SVG_TRANSFORM_UNKNOWN = 0,
    SVG_TRANSFORM_MATRIX = 1,
    SVG_TRANSFORM_TRANSLATE = 2,
    SVG_TRANSFORM_SCALE = 3,
    SVG_TRANSFORM_ROTATE = 4,
    SVG_TRANSFORM_SKEWX = 5,
    SVG_TRANSFORM_SKEWY = 6,
    svgTransformType_Max = 2147483647,
}
