// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BATTERY_REPORTING_SCALE.xml' path='doc/member[@name="BATTERY_REPORTING_SCALE"]/*'/>
public partial struct BATTERY_REPORTING_SCALE
{
    /// <include file='BATTERY_REPORTING_SCALE.xml' path='doc/member[@name="BATTERY_REPORTING_SCALE.Granularity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Granularity;
    /// <include file='BATTERY_REPORTING_SCALE.xml' path='doc/member[@name="BATTERY_REPORTING_SCALE.Capacity"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Capacity;
}