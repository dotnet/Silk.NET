// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3"]/*' />
public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3
{
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxIops"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationIops"]/*' />
    [NativeTypeName("LONG64")]
    public long ReservationIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.VolumeName"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* VolumeName;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.BaseIoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint BaseIoSize;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ControlFlags"]/*' />
    public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.VolumeNameLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort VolumeNameLength;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationIops"]/*' />
    [NativeTypeName("LONG64")]
    public long CriticalReservationIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long ReservationBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long CriticalReservationBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.MaxTimePercent"]/*' />
    [NativeTypeName("LONG64")]
    public long MaxTimePercent;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.ReservationTimePercent"]/*' />
    [NativeTypeName("LONG64")]
    public long ReservationTimePercent;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.CriticalReservationTimePercent"]/*' />
    [NativeTypeName("LONG64")]
    public long CriticalReservationTimePercent;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxIops"]/*' />
    [NativeTypeName("LONG64")]
    public long SoftMaxIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long SoftMaxBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.SoftMaxTimePercent"]/*' />
    [NativeTypeName("LONG64")]
    public long SoftMaxTimePercent;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyIops"]/*' />
    [NativeTypeName("LONG64")]
    public long LimitExcessNotifyIops;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyBandwidth"]/*' />
    [NativeTypeName("LONG64")]
    public long LimitExcessNotifyBandwidth;

    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V3.LimitExcessNotifyTimePercent"]/*' />
    [NativeTypeName("LONG64")]
    public long LimitExcessNotifyTimePercent;
}
