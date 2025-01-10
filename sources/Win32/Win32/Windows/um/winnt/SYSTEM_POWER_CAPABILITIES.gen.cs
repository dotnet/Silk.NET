// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SYSTEM_POWER_CAPABILITIES
{
    [NativeTypeName("BOOLEAN")]
    public byte PowerButtonPresent;

    [NativeTypeName("BOOLEAN")]
    public byte SleepButtonPresent;

    [NativeTypeName("BOOLEAN")]
    public byte LidPresent;

    [NativeTypeName("BOOLEAN")]
    public byte SystemS1;

    [NativeTypeName("BOOLEAN")]
    public byte SystemS2;

    [NativeTypeName("BOOLEAN")]
    public byte SystemS3;

    [NativeTypeName("BOOLEAN")]
    public byte SystemS4;

    [NativeTypeName("BOOLEAN")]
    public byte SystemS5;

    [NativeTypeName("BOOLEAN")]
    public byte HiberFilePresent;

    [NativeTypeName("BOOLEAN")]
    public byte FullWake;

    [NativeTypeName("BOOLEAN")]
    public byte VideoDimPresent;

    [NativeTypeName("BOOLEAN")]
    public byte ApmPresent;

    [NativeTypeName("BOOLEAN")]
    public byte UpsPresent;

    [NativeTypeName("BOOLEAN")]
    public byte ThermalControl;

    [NativeTypeName("BOOLEAN")]
    public byte ProcessorThrottle;
    public byte ProcessorMinThrottle;
    public byte ProcessorMaxThrottle;

    [NativeTypeName("BOOLEAN")]
    public byte FastSystemS4;

    [NativeTypeName("BOOLEAN")]
    public byte Hiberboot;

    [NativeTypeName("BOOLEAN")]
    public byte WakeAlarmPresent;

    [NativeTypeName("BOOLEAN")]
    public byte AoAc;

    [NativeTypeName("BOOLEAN")]
    public byte DiskSpinDown;
    public byte HiberFileType;

    [NativeTypeName("BOOLEAN")]
    public byte AoAcConnectivitySupported;

    [NativeTypeName("BYTE[6]")]
    public _spare3_e__FixedBuffer spare3;

    [NativeTypeName("BOOLEAN")]
    public byte SystemBatteriesPresent;

    [NativeTypeName("BOOLEAN")]
    public byte BatteriesAreShortTerm;

    [NativeTypeName("BATTERY_REPORTING_SCALE[3]")]
    public _BatteryScale_e__FixedBuffer BatteryScale;
    public SYSTEM_POWER_STATE AcOnLineWake;
    public SYSTEM_POWER_STATE SoftLidWake;
    public SYSTEM_POWER_STATE RtcWake;
    public SYSTEM_POWER_STATE MinDeviceWakeState;
    public SYSTEM_POWER_STATE DefaultLowLatencyWake;

    [InlineArray(6)]
    public partial struct _spare3_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _BatteryScale_e__FixedBuffer
    {
        public BATTERY_REPORTING_SCALE e0;
    }
}
