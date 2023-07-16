// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS"]/*'/>
public partial struct SYSTEM_POWER_STATUS
{
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.ACLineStatus"]/*'/>
    public byte ACLineStatus;
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.BatteryFlag"]/*'/>
    public byte BatteryFlag;
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.BatteryLifePercent"]/*'/>
    public byte BatteryLifePercent;
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.SystemStatusFlag"]/*'/>
    public byte SystemStatusFlag;
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.BatteryLifeTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BatteryLifeTime;
    /// <include file='SYSTEM_POWER_STATUS.xml' path='doc/member[@name="SYSTEM_POWER_STATUS.BatteryFullLifeTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BatteryFullLifeTime;
}