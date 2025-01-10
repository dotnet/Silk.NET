// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct BITMAPINFOHEADER
{
    [NativeTypeName("DWORD")]
    public uint biSize;

    [NativeTypeName("LONG")]
    public int biWidth;

    [NativeTypeName("LONG")]
    public int biHeight;

    [NativeTypeName("WORD")]
    public ushort biPlanes;

    [NativeTypeName("WORD")]
    public ushort biBitCount;

    [NativeTypeName("DWORD")]
    public uint biCompression;

    [NativeTypeName("DWORD")]
    public uint biSizeImage;

    [NativeTypeName("LONG")]
    public int biXPelsPerMeter;

    [NativeTypeName("LONG")]
    public int biYPelsPerMeter;

    [NativeTypeName("DWORD")]
    public uint biClrUsed;

    [NativeTypeName("DWORD")]
    public uint biClrImportant;
}
