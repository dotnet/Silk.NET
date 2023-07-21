// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER"]/*' />
public partial struct BITMAPV5HEADER
{
    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5Size;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Width"]/*' />
    [NativeTypeName("LONG")]
    public int bV5Width;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Height"]/*' />
    [NativeTypeName("LONG")]
    public int bV5Height;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Planes"]/*' />
    [NativeTypeName("WORD")]
    public ushort bV5Planes;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5BitCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort bV5BitCount;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Compression"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5Compression;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5SizeImage"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5SizeImage;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5XPelsPerMeter"]/*' />
    [NativeTypeName("LONG")]
    public int bV5XPelsPerMeter;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5YPelsPerMeter"]/*' />
    [NativeTypeName("LONG")]
    public int bV5YPelsPerMeter;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5ClrUsed"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5ClrUsed;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5ClrImportant"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5ClrImportant;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5RedMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5RedMask;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5GreenMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5GreenMask;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5BlueMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5BlueMask;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5AlphaMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5AlphaMask;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5CSType"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5CSType;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Endpoints"]/*' />
    public CIEXYZTRIPLE bV5Endpoints;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5GammaRed"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5GammaRed;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5GammaGreen"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5GammaGreen;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5GammaBlue"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5GammaBlue;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Intent"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5Intent;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5ProfileData"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5ProfileData;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5ProfileSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5ProfileSize;

    /// <include file='BITMAPV5HEADER.xml' path='doc/member[@name="BITMAPV5HEADER.bV5Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint bV5Reserved;
}
