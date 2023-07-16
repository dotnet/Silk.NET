// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEINCAPS2A
{
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.szPname"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.dwFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFormats;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wChannels;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='WAVEINCAPS2A.xml' path='doc/member[@name="WAVEINCAPS2A.NameGuid"]/*'/>
    public Guid NameGuid;
}