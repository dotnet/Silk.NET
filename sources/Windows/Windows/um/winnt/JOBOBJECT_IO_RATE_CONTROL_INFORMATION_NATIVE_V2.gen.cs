// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2"]/*'/>
public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2
{
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.MaxIops"]/*'/>
    [NativeTypeName("LONG64")]
    public long MaxIops;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.MaxBandwidth"]/*'/>
    [NativeTypeName("LONG64")]
    public long MaxBandwidth;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.ReservationIops"]/*'/>
    [NativeTypeName("LONG64")]
    public long ReservationIops;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.VolumeName"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* VolumeName;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.BaseIoSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseIoSize;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.ControlFlags"]/*'/>
    public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.VolumeNameLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort VolumeNameLength;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.CriticalReservationIops"]/*'/>
    [NativeTypeName("LONG64")]
    public long CriticalReservationIops;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.ReservationBandwidth"]/*'/>
    [NativeTypeName("LONG64")]
    public long ReservationBandwidth;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.CriticalReservationBandwidth"]/*'/>
    [NativeTypeName("LONG64")]
    public long CriticalReservationBandwidth;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.MaxTimePercent"]/*'/>
    [NativeTypeName("LONG64")]
    public long MaxTimePercent;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.ReservationTimePercent"]/*'/>
    [NativeTypeName("LONG64")]
    public long ReservationTimePercent;
    /// <include file='JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.xml' path='doc/member[@name="JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2.CriticalReservationTimePercent"]/*'/>
    [NativeTypeName("LONG64")]
    public long CriticalReservationTimePercent;
}