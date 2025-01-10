// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_PROPORTION
{
    DWRITE_PANOSE_PROPORTION_ANY = 0,
    DWRITE_PANOSE_PROPORTION_NO_FIT = 1,
    DWRITE_PANOSE_PROPORTION_OLD_STYLE = 2,
    DWRITE_PANOSE_PROPORTION_MODERN = 3,
    DWRITE_PANOSE_PROPORTION_EVEN_WIDTH = 4,
    DWRITE_PANOSE_PROPORTION_EXPANDED = 5,
    DWRITE_PANOSE_PROPORTION_CONDENSED = 6,
    DWRITE_PANOSE_PROPORTION_VERY_EXPANDED = 7,
    DWRITE_PANOSE_PROPORTION_VERY_CONDENSED = 8,
    DWRITE_PANOSE_PROPORTION_MONOSPACED = 9,
}
