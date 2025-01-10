// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum VideoEncodingQuality
{
    VideoEncodingQuality_Auto = 0,
    VideoEncodingQuality_HD1080p = 1,
    VideoEncodingQuality_HD720p = 2,
    VideoEncodingQuality_Wvga = 3,
    VideoEncodingQuality_Ntsc = 4,
    VideoEncodingQuality_Pal = 5,
    VideoEncodingQuality_Vga = 6,
    VideoEncodingQuality_Qvga = 7,
    VideoEncodingQuality_Uhd2160p = 8,
    VideoEncodingQuality_Uhd4320p = 9,
}
