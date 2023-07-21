// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIDIINCAPS2A
{
    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIDIINCAPS2A.xml' path='doc/member[@name="MIDIINCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;
}
