// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PngFilterMode
{
    PngFilterMode_Automatic = 0,
    PngFilterMode_None = 1,
    PngFilterMode_Sub = 2,
    PngFilterMode_Up = 3,
    PngFilterMode_Average = 4,
    PngFilterMode_Paeth = 5,
    PngFilterMode_Adaptive = 6,
}
