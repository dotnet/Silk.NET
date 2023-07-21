// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCAPSW
{
    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];

    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPSW.xml' path='doc/member[@name="MIXERCAPSW.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;
}
