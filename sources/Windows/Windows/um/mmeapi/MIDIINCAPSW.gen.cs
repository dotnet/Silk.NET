// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIINCAPSW
{
    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];

    /// <include file='MIDIINCAPSW.xml' path='doc/member[@name="MIDIINCAPSW.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}
