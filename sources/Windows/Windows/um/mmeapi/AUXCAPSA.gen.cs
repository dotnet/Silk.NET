// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct AUXCAPSA
{
    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;
}
