// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/namespaceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION
{
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.MaxIops"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.MaxBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.ReservationIops"]/*' />
    [NativeTypeName("LONG64")]
    public long ReservationIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.VolumeName"]/*' />
    [NativeTypeName("PCWSTR")]
    public ushort* VolumeName;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.BaseIoSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint BaseIoSize;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION.ControlFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint ControlFlags;
}
