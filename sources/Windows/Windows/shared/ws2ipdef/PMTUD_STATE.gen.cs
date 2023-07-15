// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE"]/*'/>
public enum PMTUD_STATE
{
    /// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE.IP_PMTUDISC_NOT_SET"]/*'/>
    IP_PMTUDISC_NOT_SET,
    /// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE.IP_PMTUDISC_DO"]/*'/>
    IP_PMTUDISC_DO,
    /// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE.IP_PMTUDISC_DONT"]/*'/>
    IP_PMTUDISC_DONT,
    /// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE.IP_PMTUDISC_PROBE"]/*'/>
    IP_PMTUDISC_PROBE,
    /// <include file='PMTUD_STATE.xml' path='doc/member[@name="PMTUD_STATE.IP_PMTUDISC_MAX"]/*'/>
    IP_PMTUDISC_MAX,
}