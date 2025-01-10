// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_CONTRAST
{
    DWRITE_PANOSE_CONTRAST_ANY = 0,
    DWRITE_PANOSE_CONTRAST_NO_FIT = 1,
    DWRITE_PANOSE_CONTRAST_NONE = 2,
    DWRITE_PANOSE_CONTRAST_VERY_LOW = 3,
    DWRITE_PANOSE_CONTRAST_LOW = 4,
    DWRITE_PANOSE_CONTRAST_MEDIUM_LOW = 5,
    DWRITE_PANOSE_CONTRAST_MEDIUM = 6,
    DWRITE_PANOSE_CONTRAST_MEDIUM_HIGH = 7,
    DWRITE_PANOSE_CONTRAST_HIGH = 8,
    DWRITE_PANOSE_CONTRAST_VERY_HIGH = 9,
    DWRITE_PANOSE_CONTRAST_HORIZONTAL_LOW = 10,
    DWRITE_PANOSE_CONTRAST_HORIZONTAL_MEDIUM = 11,
    DWRITE_PANOSE_CONTRAST_HORIZONTAL_HIGH = 12,
    DWRITE_PANOSE_CONTRAST_BROKEN = 13,
}
