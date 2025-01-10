// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_SVG_ASPECT_ALIGN
{
    D2D1_SVG_ASPECT_ALIGN_NONE = 0,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MIN = 1,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MIN = 2,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MIN = 3,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MID = 4,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MID = 5,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MID = 6,
    D2D1_SVG_ASPECT_ALIGN_X_MIN_Y_MAX = 7,
    D2D1_SVG_ASPECT_ALIGN_X_MID_Y_MAX = 8,
    D2D1_SVG_ASPECT_ALIGN_X_MAX_Y_MAX = 9,
    D2D1_SVG_ASPECT_ALIGN_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
