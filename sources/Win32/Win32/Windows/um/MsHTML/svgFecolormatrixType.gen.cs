// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgFecolormatrixType
{
    SVG_FECOLORMATRIX_TYPE_UNKNOWN = 0,
    SVG_FECOLORMATRIX_TYPE_MATRIX = 1,
    SVG_FECOLORMATRIX_TYPE_SATURATE = 2,
    SVG_FECOLORMATRIX_TYPE_HUEROTATE = 3,
    SVG_FECOLORMATRIX_TYPE_LUMINANCETOALPHA = 4,
    svgFecolormatrixType_Max = 2147483647,
}
