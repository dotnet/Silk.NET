// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION"]/*' />
public enum POWER_ACTION
{
    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionNone"]/*' />
    PowerActionNone = 0,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionReserved"]/*' />
    PowerActionReserved,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionSleep"]/*' />
    PowerActionSleep,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionHibernate"]/*' />
    PowerActionHibernate,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionShutdown"]/*' />
    PowerActionShutdown,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionShutdownReset"]/*' />
    PowerActionShutdownReset,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionShutdownOff"]/*' />
    PowerActionShutdownOff,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionWarmEject"]/*' />
    PowerActionWarmEject,

    /// <include file='POWER_ACTION.xml' path='doc/member[@name="POWER_ACTION.PowerActionDisplayOff"]/*' />
    PowerActionDisplayOff,
}
