// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BitmapRotation
{
    BitmapRotation_None = 0,
    BitmapRotation_Clockwise90Degrees = 1,
    BitmapRotation_Clockwise180Degrees = 2,
    BitmapRotation_Clockwise270Degrees = 3,
}
