// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICNamedWhitePoint
{
    WICWhitePointDefault = 0x1,
    WICWhitePointDaylight = 0x2,
    WICWhitePointCloudy = 0x4,
    WICWhitePointShade = 0x8,
    WICWhitePointTungsten = 0x10,
    WICWhitePointFluorescent = 0x20,
    WICWhitePointFlash = 0x40,
    WICWhitePointUnderwater = 0x80,
    WICWhitePointCustom = 0x100,
    WICWhitePointAutoWhiteBalance = 0x200,
    WICWhitePointAsShot = WICWhitePointDefault,
    WICNAMEDWHITEPOINT_FORCE_DWORD = 0x7fffffff,
}
