// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES"]/*'/>
public unsafe partial struct SYSTEM_POWER_CAPABILITIES
{
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.PowerButtonPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte PowerButtonPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SleepButtonPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SleepButtonPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.LidPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte LidPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemS1"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemS1;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemS2"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemS2;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemS3"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemS3;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemS4"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemS4;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemS5"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemS5;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.HiberFilePresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte HiberFilePresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.FullWake"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte FullWake;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.VideoDimPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte VideoDimPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.ApmPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ApmPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.UpsPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte UpsPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.ThermalControl"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ThermalControl;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.ProcessorThrottle"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ProcessorThrottle;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.ProcessorMinThrottle"]/*'/>
    public byte ProcessorMinThrottle;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.ProcessorMaxThrottle"]/*'/>
    public byte ProcessorMaxThrottle;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.FastSystemS4"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte FastSystemS4;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.Hiberboot"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Hiberboot;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.WakeAlarmPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte WakeAlarmPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.AoAc"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AoAc;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.DiskSpinDown"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte DiskSpinDown;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.HiberFileType"]/*'/>
    public byte HiberFileType;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.AoAcConnectivitySupported"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AoAcConnectivitySupported;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.spare3"]/*'/>
    [NativeTypeName("BYTE[6]")]
    public fixed byte spare3[6];
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SystemBatteriesPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SystemBatteriesPresent;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.BatteriesAreShortTerm"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BatteriesAreShortTerm;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.BatteryScale"]/*'/>
    [NativeTypeName("BATTERY_REPORTING_SCALE[3]")]
    public _BatteryScale_e__FixedBuffer BatteryScale;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.AcOnLineWake"]/*'/>
    public SYSTEM_POWER_STATE AcOnLineWake;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.SoftLidWake"]/*'/>
    public SYSTEM_POWER_STATE SoftLidWake;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.RtcWake"]/*'/>
    public SYSTEM_POWER_STATE RtcWake;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.MinDeviceWakeState"]/*'/>
    public SYSTEM_POWER_STATE MinDeviceWakeState;
    /// <include file='SYSTEM_POWER_CAPABILITIES.xml' path='doc/member[@name="SYSTEM_POWER_CAPABILITIES.DefaultLowLatencyWake"]/*'/>
    public SYSTEM_POWER_STATE DefaultLowLatencyWake;
    /// <include file='_BatteryScale_e__FixedBuffer.xml' path='doc/member[@name="_BatteryScale_e__FixedBuffer"]/*'/>
    public partial struct _BatteryScale_e__FixedBuffer
    {
        public BATTERY_REPORTING_SCALE e0;
        public BATTERY_REPORTING_SCALE e1;
        public BATTERY_REPORTING_SCALE e2;
        [UnscopedRef]
        public ref BATTERY_REPORTING_SCALE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<BATTERY_REPORTING_SCALE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
    }
}