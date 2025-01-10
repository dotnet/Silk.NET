// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WICPngChrmProperties
{
    WICPngChrmWhitePointX = 0x1,
    WICPngChrmWhitePointY = 0x2,
    WICPngChrmRedX = 0x3,
    WICPngChrmRedY = 0x4,
    WICPngChrmGreenX = 0x5,
    WICPngChrmGreenY = 0x6,
    WICPngChrmBlueX = 0x7,
    WICPngChrmBlueY = 0x8,
    WICPngChrmProperties_FORCE_DWORD = 0x7fffffff,
}
