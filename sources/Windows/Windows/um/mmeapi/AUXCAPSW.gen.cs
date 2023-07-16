// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct AUXCAPSW
{
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.szPname"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wTechnology"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wTechnology;
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='AUXCAPSW.xml' path='doc/member[@name="AUXCAPSW.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}