// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIOUTCAPSW
{
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.szPname"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wTechnology"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wTechnology;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wVoices"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wVoices;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wNotes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wNotes;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.wChannelMask"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wChannelMask;
    /// <include file='MIDIOUTCAPSW.xml' path='doc/member[@name="MIDIOUTCAPSW.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}