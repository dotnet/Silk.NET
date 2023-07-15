// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MONITOR_DISPLAY_STATE.xml' path='doc/member[@name="MONITOR_DISPLAY_STATE"]/*'/>
public enum MONITOR_DISPLAY_STATE
{
    /// <include file='MONITOR_DISPLAY_STATE.xml' path='doc/member[@name="MONITOR_DISPLAY_STATE.PowerMonitorOff"]/*'/>
    PowerMonitorOff = 0,
    /// <include file='MONITOR_DISPLAY_STATE.xml' path='doc/member[@name="MONITOR_DISPLAY_STATE.PowerMonitorOn"]/*'/>
    PowerMonitorOn,
    /// <include file='MONITOR_DISPLAY_STATE.xml' path='doc/member[@name="MONITOR_DISPLAY_STATE.PowerMonitorDim"]/*'/>
    PowerMonitorDim,
}