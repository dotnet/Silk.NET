// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public enum GdiplusStartupParams
{
    GdiplusStartupDefault = 0x00000000,
    GdiplusStartupNoSetRound = 0x00000001,
    GdiplusStartupSetPSValue = 0x00000002,
    GdiplusStartupReserved0 = 0x00000004,
    GdiplusStartupTransparencyMask = unchecked((int)(0xFF000000)),
}
