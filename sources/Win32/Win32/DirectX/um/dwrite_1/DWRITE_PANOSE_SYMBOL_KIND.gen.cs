// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_SYMBOL_KIND
{
    DWRITE_PANOSE_SYMBOL_KIND_ANY = 0,
    DWRITE_PANOSE_SYMBOL_KIND_NO_FIT = 1,
    DWRITE_PANOSE_SYMBOL_KIND_MONTAGES = 2,
    DWRITE_PANOSE_SYMBOL_KIND_PICTURES = 3,
    DWRITE_PANOSE_SYMBOL_KIND_SHAPES = 4,
    DWRITE_PANOSE_SYMBOL_KIND_SCIENTIFIC = 5,
    DWRITE_PANOSE_SYMBOL_KIND_MUSIC = 6,
    DWRITE_PANOSE_SYMBOL_KIND_EXPERT = 7,
    DWRITE_PANOSE_SYMBOL_KIND_PATTERNS = 8,
    DWRITE_PANOSE_SYMBOL_KIND_BOARDERS = 9,
    DWRITE_PANOSE_SYMBOL_KIND_ICONS = 10,
    DWRITE_PANOSE_SYMBOL_KIND_LOGOS = 11,
    DWRITE_PANOSE_SYMBOL_KIND_INDUSTRY_SPECIFIC = 12,
}
