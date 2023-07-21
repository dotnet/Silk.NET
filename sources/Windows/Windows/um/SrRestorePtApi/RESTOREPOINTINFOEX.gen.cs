// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct RESTOREPOINTINFOEX
{
    /// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX.ftCreation"]/*' />
    public FILETIME ftCreation;

    /// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX.dwEventType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEventType;

    /// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX.dwRestorePtType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRestorePtType;

    /// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX.dwRPNum"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRPNum;

    /// <include file='RESTOREPOINTINFOEX.xml' path='doc/member[@name="RESTOREPOINTINFOEX.szDescription"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public fixed ushort szDescription[256];
}
