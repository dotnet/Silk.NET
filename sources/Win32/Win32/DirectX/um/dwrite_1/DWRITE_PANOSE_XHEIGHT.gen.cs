// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum DWRITE_PANOSE_XHEIGHT
{
    DWRITE_PANOSE_XHEIGHT_ANY = 0,
    DWRITE_PANOSE_XHEIGHT_NO_FIT = 1,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL = 2,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD = 3,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE = 4,
    DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL = 5,
    DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD = 6,
    DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE = 7,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STD = DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD,
    DWRITE_PANOSE_XHEIGHT_DUCKING_STD = DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD,
}
