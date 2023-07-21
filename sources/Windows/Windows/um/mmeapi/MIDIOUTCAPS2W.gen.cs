// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIOUTCAPS2W
{
    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wVoices"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVoices;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wNotes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wNotes;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.wChannelMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannelMask;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIDIOUTCAPS2W.xml' path='doc/member[@name="MIDIOUTCAPS2W.NameGuid"]/*' />
    public Guid NameGuid;
}
