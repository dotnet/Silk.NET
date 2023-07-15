// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POWER_MONITOR_REQUEST_TYPE.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_TYPE"]/*'/>
public enum POWER_MONITOR_REQUEST_TYPE
{
    /// <include file='POWER_MONITOR_REQUEST_TYPE.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_TYPE.MonitorRequestTypeOff"]/*'/>
    MonitorRequestTypeOff,
    /// <include file='POWER_MONITOR_REQUEST_TYPE.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_TYPE.MonitorRequestTypeOnAndPresent"]/*'/>
    MonitorRequestTypeOnAndPresent,
    /// <include file='POWER_MONITOR_REQUEST_TYPE.xml' path='doc/member[@name="POWER_MONITOR_REQUEST_TYPE.MonitorRequestTypeToggleOn"]/*'/>
    MonitorRequestTypeToggleOn,
}