// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_BLEND
{
    D2D1_BLEND_ZERO = 1,
    D2D1_BLEND_ONE = 2,
    D2D1_BLEND_SRC_COLOR = 3,
    D2D1_BLEND_INV_SRC_COLOR = 4,
    D2D1_BLEND_SRC_ALPHA = 5,
    D2D1_BLEND_INV_SRC_ALPHA = 6,
    D2D1_BLEND_DEST_ALPHA = 7,
    D2D1_BLEND_INV_DEST_ALPHA = 8,
    D2D1_BLEND_DEST_COLOR = 9,
    D2D1_BLEND_INV_DEST_COLOR = 10,
    D2D1_BLEND_SRC_ALPHA_SAT = 11,
    D2D1_BLEND_BLEND_FACTOR = 14,
    D2D1_BLEND_INV_BLEND_FACTOR = 15,
    D2D1_BLEND_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
