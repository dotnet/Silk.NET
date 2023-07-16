// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER"]/*'/>
public partial struct ENHMETAHEADER
{
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.iType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iType;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nSize;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.rclFrame"]/*'/>
    public RECTL rclFrame;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.dSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dSignature;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nVersion;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nBytes;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nRecords"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nRecords;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nHandles"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nHandles;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.sReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort sReserved;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nDescription"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nDescription;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.offDescription"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offDescription;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.nPalEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPalEntries;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlDevice"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlDevice;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlMillimeters"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlMillimeters;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.cbPixelFormat"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbPixelFormat;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.offPixelFormat"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offPixelFormat;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.bOpenGL"]/*'/>
    [NativeTypeName("DWORD")]
    public uint bOpenGL;
    /// <include file='ENHMETAHEADER.xml' path='doc/member[@name="ENHMETAHEADER.szlMicrometers"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlMicrometers;
}