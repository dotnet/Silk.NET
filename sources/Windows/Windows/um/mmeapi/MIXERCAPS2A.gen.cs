// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCAPS2A
{
    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szPname[32];

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIXERCAPS2A.xml' path='doc/member[@name="MIXERCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;
}
