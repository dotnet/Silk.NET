// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum DisplayOrientations : uint
{
    DisplayOrientations_None = 0,
    DisplayOrientations_Landscape = 0x1,
    DisplayOrientations_Portrait = 0x2,
    DisplayOrientations_LandscapeFlipped = 0x4,
    DisplayOrientations_PortraitFlipped = 0x8,
}
