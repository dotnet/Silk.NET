// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIINCAPSA
{
    /// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA.wMid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMid;
    /// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA.wPid"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wPid;
    /// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA.vDriverVersion"]/*'/>
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;
    /// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA.szPname"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];
    /// <include file='MIDIINCAPSA.xml' path='doc/member[@name="MIDIINCAPSA.dwSupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}