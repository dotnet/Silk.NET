// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.DirectX.D2D1_LINE_JOIN;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_SVG_LINE_JOIN
{
    D2D1_SVG_LINE_JOIN_BEVEL = D2D1_LINE_JOIN_BEVEL,
    D2D1_SVG_LINE_JOIN_MITER = D2D1_LINE_JOIN_MITER_OR_BEVEL,
    D2D1_SVG_LINE_JOIN_ROUND = D2D1_LINE_JOIN_ROUND,
    D2D1_SVG_LINE_JOIN_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
