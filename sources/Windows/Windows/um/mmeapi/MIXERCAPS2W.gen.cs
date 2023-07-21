// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCAPS2W
{
    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.szPname"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szPname[32];

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.fdwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwSupport;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.cDestinations"]/*' />
    [NativeTypeName("DWORD")]
    public uint cDestinations;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIXERCAPS2W.xml' path='doc/member[@name="MIXERCAPS2W.NameGuid"]/*' />
    public Guid NameGuid;
}
