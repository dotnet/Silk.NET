// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_FAMILY
{
    DWRITE_PANOSE_FAMILY_ANY = 0,
    DWRITE_PANOSE_FAMILY_NO_FIT = 1,
    DWRITE_PANOSE_FAMILY_TEXT_DISPLAY = 2,
    DWRITE_PANOSE_FAMILY_SCRIPT = 3,
    DWRITE_PANOSE_FAMILY_DECORATIVE = 4,
    DWRITE_PANOSE_FAMILY_SYMBOL = 5,
    DWRITE_PANOSE_FAMILY_PICTORIAL = DWRITE_PANOSE_FAMILY_SYMBOL,
}
