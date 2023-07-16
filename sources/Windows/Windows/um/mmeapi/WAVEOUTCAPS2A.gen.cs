// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEOUTCAPS2A
{
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.szPname"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.dwFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFormats;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.wChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wChannels;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='WAVEOUTCAPS2A.xml' path='doc/member[@name="WAVEOUTCAPS2A.NameGuid"]/*'/>
    public Guid NameGuid;
}