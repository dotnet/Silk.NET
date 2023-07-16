// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIINCAPS2W
{
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.szPname"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.ManufacturerGuid"]/*'/>
    public Guid ManufacturerGuid;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.ProductGuid"]/*'/>
    public Guid ProductGuid;
    /// <include file='MIDIINCAPS2W.xml' path='doc/member[@name="MIDIINCAPS2W.NameGuid"]/*'/>
    public Guid NameGuid;
}