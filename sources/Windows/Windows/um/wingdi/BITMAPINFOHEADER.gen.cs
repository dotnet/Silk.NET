// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER"]/*'/>
public partial struct BITMAPINFOHEADER
{
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint biSize;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biWidth"]/*'/>
    [NativeTypeName("LONG")]
    public int biWidth;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biHeight"]/*'/>
    [NativeTypeName("LONG")]
    public int biHeight;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biPlanes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort biPlanes;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biBitCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort biBitCount;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biCompression"]/*'/>
    [NativeTypeName("DWORD")]
    public uint biCompression;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biSizeImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint biSizeImage;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biXPelsPerMeter"]/*'/>
    [NativeTypeName("LONG")]
    public int biXPelsPerMeter;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biYPelsPerMeter"]/*'/>
    [NativeTypeName("LONG")]
    public int biYPelsPerMeter;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biClrUsed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint biClrUsed;
    /// <include file='BITMAPINFOHEADER.xml' path='doc/member[@name="BITMAPINFOHEADER.biClrImportant"]/*'/>
    [NativeTypeName("DWORD")]
    public uint biClrImportant;
}