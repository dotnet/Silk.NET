// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct METAHEADER
{
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtType;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtHeaderSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtHeaderSize;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtVersion;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mtSize;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtNoObjects"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtNoObjects;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtMaxRecord"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mtMaxRecord;
    /// <include file='METAHEADER.xml' path='doc/member[@name="METAHEADER.mtNoParameters"]/*'/>
    [NativeTypeName("WORD")]
    public ushort mtNoParameters;
}