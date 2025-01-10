// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum svgEdgemode
{
    SVG_EDGEMODE_UNKNOWN = 0,
    SVG_EDGEMODE_DUPLICATE = 1,
    SVG_EDGEMODE_WRAP = 2,
    SVG_EDGEMODE_NONE = 3,
    svgEdgemode_Max = 2147483647,
}
