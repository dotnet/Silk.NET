// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.Gdiplus;
/// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3"]/*'/>
public partial struct ENHMETAHEADER3
{
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.iType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iType;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nSize;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.rclBounds"]/*'/>
    public RECTL rclBounds;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.rclFrame"]/*'/>
    public RECTL rclFrame;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.dSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dSignature;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nVersion;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nBytes;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nRecords"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nRecords;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nHandles"]/*'/>
    [NativeTypeName("WORD")]
    public ushort nHandles;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.sReserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort sReserved;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nDescription"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nDescription;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.offDescription"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offDescription;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.nPalEntries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nPalEntries;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.szlDevice"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlDevice;
    /// <include file='ENHMETAHEADER3.xml' path='doc/member[@name="ENHMETAHEADER3.szlMillimeters"]/*'/>
    [NativeTypeName("SIZEL")]
    public SIZE szlMillimeters;
}