// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct AUXCAPS2A
{
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.szPname"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wTechnology"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wTechnology;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='AUXCAPS2A.xml' path='doc/member[@name="AUXCAPS2A.NameGuid"]/*'/>
    public Guid NameGuid;
}