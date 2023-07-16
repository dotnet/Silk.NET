// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE"]/*'/>
public unsafe partial struct SYSTEM_BATTERY_STATE
{
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.AcOnLine"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte AcOnLine;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.BatteryPresent"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte BatteryPresent;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Charging"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Charging;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Discharging"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Discharging;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Spare1"]/*'/>
    [NativeTypeName("BOOLEAN[3]")]
    public fixed byte Spare1[3];
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Tag"]/*'/>
    public byte Tag;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.MaxCapacity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxCapacity;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.RemainingCapacity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RemainingCapacity;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.Rate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Rate;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.EstimatedTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EstimatedTime;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.DefaultAlert1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DefaultAlert1;
    /// <include file='SYSTEM_BATTERY_STATE.xml' path='doc/member[@name="SYSTEM_BATTERY_STATE.DefaultAlert2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DefaultAlert2;
}