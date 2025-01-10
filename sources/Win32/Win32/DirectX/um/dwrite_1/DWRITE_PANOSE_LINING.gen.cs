// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_LINING
{
    DWRITE_PANOSE_LINING_ANY = 0,
    DWRITE_PANOSE_LINING_NO_FIT = 1,
    DWRITE_PANOSE_LINING_NONE = 2,
    DWRITE_PANOSE_LINING_INLINE = 3,
    DWRITE_PANOSE_LINING_OUTLINE = 4,
    DWRITE_PANOSE_LINING_ENGRAVED = 5,
    DWRITE_PANOSE_LINING_SHADOW = 6,
    DWRITE_PANOSE_LINING_RELIEF = 7,
    DWRITE_PANOSE_LINING_BACKDROP = 8,
}
