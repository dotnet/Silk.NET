// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_ASPECT
{
    DWRITE_PANOSE_ASPECT_ANY = 0,
    DWRITE_PANOSE_ASPECT_NO_FIT = 1,
    DWRITE_PANOSE_ASPECT_SUPER_CONDENSED = 2,
    DWRITE_PANOSE_ASPECT_VERY_CONDENSED = 3,
    DWRITE_PANOSE_ASPECT_CONDENSED = 4,
    DWRITE_PANOSE_ASPECT_NORMAL = 5,
    DWRITE_PANOSE_ASPECT_EXTENDED = 6,
    DWRITE_PANOSE_ASPECT_VERY_EXTENDED = 7,
    DWRITE_PANOSE_ASPECT_SUPER_EXTENDED = 8,
    DWRITE_PANOSE_ASPECT_MONOSPACED = 9,
}
