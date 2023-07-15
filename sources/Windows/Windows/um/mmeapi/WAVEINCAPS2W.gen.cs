// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEINCAPS2W
{
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.szPname"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.dwFormats"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFormats;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.wChannels"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wChannels;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.wReserved1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wReserved1;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='WAVEINCAPS2W.xml' path='doc/member[@name="WAVEINCAPS2W.NameGuid"]/*'/>
    public Guid NameGuid;
}