// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct AUXCAPS2W
{
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.szPname"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.wTechnology"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wTechnology;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='AUXCAPS2W.xml' path='doc/member[@name="AUXCAPS2W.NameGuid"]/*'/>
    public Guid NameGuid;
}