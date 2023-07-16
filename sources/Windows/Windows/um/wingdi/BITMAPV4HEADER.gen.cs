// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER"]/*'/>
public partial struct BITMAPV4HEADER
{
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4Size;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Width"]/*'/>
    [NativeTypeName("LONG")]
    public int bV4Width;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Height"]/*'/>
    [NativeTypeName("LONG")]
    public int bV4Height;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Planes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort bV4Planes;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4BitCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort bV4BitCount;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4V4Compression"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4V4Compression;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4SizeImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4SizeImage;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4XPelsPerMeter"]/*'/>
    [NativeTypeName("LONG")]
    public int bV4XPelsPerMeter;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4YPelsPerMeter"]/*'/>
    [NativeTypeName("LONG")]
    public int bV4YPelsPerMeter;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4ClrUsed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4ClrUsed;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4ClrImportant"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4ClrImportant;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4RedMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4RedMask;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GreenMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4GreenMask;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4BlueMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4BlueMask;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4AlphaMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4AlphaMask;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4CSType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4CSType;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4Endpoints"]/*'/>
    public CIEXYZTRIPLE bV4Endpoints;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaRed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4GammaRed;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaGreen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4GammaGreen;
    /// <include file='BITMAPV4HEADER.xml' path='doc/member[@name="BITMAPV4HEADER.bV4GammaBlue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bV4GammaBlue;
}