// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCAPSA
{
    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];

    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPSA.xml' path='doc/member[@name="MIXERCAPSA.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;
}
