// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='RESTOREPOINTINFOA.xml' path='doc/member[@name="RESTOREPOINTINFOA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct RESTOREPOINTINFOA
{
    /// <include file='RESTOREPOINTINFOA.xml' path='doc/member[@name="RESTOREPOINTINFOA.dwEventType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEventType;
    /// <include file='RESTOREPOINTINFOA.xml' path='doc/member[@name="RESTOREPOINTINFOA.dwRestorePtType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;
    /// <include file='RESTOREPOINTINFOA.xml' path='doc/member[@name="RESTOREPOINTINFOA.llSequenceNumber"]/*'/>
    [NativeTypeName("INT64")]
    public long llSequenceNumber;
    /// <include file='RESTOREPOINTINFOA.xml' path='doc/member[@name="RESTOREPOINTINFOA.szDescription"]/*'/>
    [NativeTypeName("CHAR[64]")]
    public fixed sbyte szDescription[64];
}