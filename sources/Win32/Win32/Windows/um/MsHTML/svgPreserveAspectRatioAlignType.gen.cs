// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgPreserveAspectRatioAlignType
{
    SVG_PRESERVEASPECTRATIO_UNKNOWN = 0,
    SVG_PRESERVEASPECTRATIO_NONE = 1,
    SVG_PRESERVEASPECTRATIO_XMINYMIN = 2,
    SVG_PRESERVEASPECTRATIO_XMIDYMIN = 3,
    SVG_PRESERVEASPECTRATIO_XMAXYMIN = 4,
    SVG_PRESERVEASPECTRATIO_XMINYMID = 5,
    SVG_PRESERVEASPECTRATIO_XMIDYMID = 6,
    SVG_PRESERVEASPECTRATIO_XMAXYMID = 7,
    SVG_PRESERVEASPECTRATIO_XMINYMAX = 8,
    SVG_PRESERVEASPECTRATIO_XMIDYMAX = 9,
    SVG_PRESERVEASPECTRATIO_XMAXYMAX = 10,
    svgPreserveAspectRatioAlignType_Max = 2147483647,
}
