// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct BITMAPV4HEADER
{
    [NativeTypeName("DWORD")]
    public uint bV4Size;

    [NativeTypeName("LONG")]
    public int bV4Width;

    [NativeTypeName("LONG")]
    public int bV4Height;

    [NativeTypeName("WORD")]
    public ushort bV4Planes;

    [NativeTypeName("WORD")]
    public ushort bV4BitCount;

    [NativeTypeName("DWORD")]
    public uint bV4V4Compression;

    [NativeTypeName("DWORD")]
    public uint bV4SizeImage;

    [NativeTypeName("LONG")]
    public int bV4XPelsPerMeter;

    [NativeTypeName("LONG")]
    public int bV4YPelsPerMeter;

    [NativeTypeName("DWORD")]
    public uint bV4ClrUsed;

    [NativeTypeName("DWORD")]
    public uint bV4ClrImportant;

    [NativeTypeName("DWORD")]
    public uint bV4RedMask;

    [NativeTypeName("DWORD")]
    public uint bV4GreenMask;

    [NativeTypeName("DWORD")]
    public uint bV4BlueMask;

    [NativeTypeName("DWORD")]
    public uint bV4AlphaMask;

    [NativeTypeName("DWORD")]
    public uint bV4CSType;
    public CIEXYZTRIPLE bV4Endpoints;

    [NativeTypeName("DWORD")]
    public uint bV4GammaRed;

    [NativeTypeName("DWORD")]
    public uint bV4GammaGreen;

    [NativeTypeName("DWORD")]
    public uint bV4GammaBlue;
}
