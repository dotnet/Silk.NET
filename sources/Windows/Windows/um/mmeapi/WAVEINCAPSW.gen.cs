// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct WAVEINCAPSW
{
    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.dwFormats"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFormats;

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.wChannels"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannels;

    /// <include file='WAVEINCAPSW.xml' path='doc/member[@name="WAVEINCAPSW.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;
}
