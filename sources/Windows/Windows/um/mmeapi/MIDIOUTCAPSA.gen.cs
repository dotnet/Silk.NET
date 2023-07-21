// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIOUTCAPSA
{
    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wVoices"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVoices;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wNotes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wNotes;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.wChannelMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannelMask;

    /// <include file='MIDIOUTCAPSA.xml' path='doc/member[@name="MIDIOUTCAPSA.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}
