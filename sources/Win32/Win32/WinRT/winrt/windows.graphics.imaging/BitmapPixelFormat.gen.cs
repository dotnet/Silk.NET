// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum BitmapPixelFormat
{
    BitmapPixelFormat_Unknown = 0,
    BitmapPixelFormat_Rgba16 = 12,
    BitmapPixelFormat_Rgba8 = 30,
    BitmapPixelFormat_Gray16 = 57,
    BitmapPixelFormat_Gray8 = 62,
    BitmapPixelFormat_Bgra8 = 87,
    BitmapPixelFormat_Nv12 = 103,
    BitmapPixelFormat_P010 = 104,
    BitmapPixelFormat_Yuy2 = 107,
}
