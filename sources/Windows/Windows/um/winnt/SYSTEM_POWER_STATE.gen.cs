// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE"]/*'/>
public enum SYSTEM_POWER_STATE
{
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemUnspecified"]/*'/>
    PowerSystemUnspecified = 0,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemWorking"]/*'/>
    PowerSystemWorking = 1,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemSleeping1"]/*'/>
    PowerSystemSleeping1 = 2,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemSleeping2"]/*'/>
    PowerSystemSleeping2 = 3,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemSleeping3"]/*'/>
    PowerSystemSleeping3 = 4,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemHibernate"]/*'/>
    PowerSystemHibernate = 5,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemShutdown"]/*'/>
    PowerSystemShutdown = 6,
    /// <include file='SYSTEM_POWER_STATE.xml' path='doc/member[@name="SYSTEM_POWER_STATE.PowerSystemMaximum"]/*'/>
    PowerSystemMaximum = 7,
}