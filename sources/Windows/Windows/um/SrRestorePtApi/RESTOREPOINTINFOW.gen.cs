// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct RESTOREPOINTINFOW
{
    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.dwEventType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEventType;
    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.dwRestorePtType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;
    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.llSequenceNumber"]/*'/>
    [NativeTypeName("INT64")]
    public long llSequenceNumber;
    /// <include file='RESTOREPOINTINFOW.xml' path='doc/member[@name="RESTOREPOINTINFOW.szDescription"]/*'/>
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort szDescription[256];
}