// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_WEIGHT
{
    DWRITE_PANOSE_WEIGHT_ANY = 0,
    DWRITE_PANOSE_WEIGHT_NO_FIT = 1,
    DWRITE_PANOSE_WEIGHT_VERY_LIGHT = 2,
    DWRITE_PANOSE_WEIGHT_LIGHT = 3,
    DWRITE_PANOSE_WEIGHT_THIN = 4,
    DWRITE_PANOSE_WEIGHT_BOOK = 5,
    DWRITE_PANOSE_WEIGHT_MEDIUM = 6,
    DWRITE_PANOSE_WEIGHT_DEMI = 7,
    DWRITE_PANOSE_WEIGHT_BOLD = 8,
    DWRITE_PANOSE_WEIGHT_HEAVY = 9,
    DWRITE_PANOSE_WEIGHT_BLACK = 10,
    DWRITE_PANOSE_WEIGHT_EXTRA_BLACK = 11,
    DWRITE_PANOSE_WEIGHT_NORD = DWRITE_PANOSE_WEIGHT_EXTRA_BLACK,
}
