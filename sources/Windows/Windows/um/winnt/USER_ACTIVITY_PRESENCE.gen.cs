// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE"]/*' />
public enum USER_ACTIVITY_PRESENCE
{
    /// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE.PowerUserPresent"]/*' />
    PowerUserPresent = 0,

    /// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE.PowerUserNotPresent"]/*' />
    PowerUserNotPresent,

    /// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE.PowerUserInactive"]/*' />
    PowerUserInactive,

    /// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE.PowerUserMaximum"]/*' />
    PowerUserMaximum,

    /// <include file='USER_ACTIVITY_PRESENCE.xml' path='doc/member[@name="USER_ACTIVITY_PRESENCE.PowerUserInvalid"]/*' />
    PowerUserInvalid = PowerUserMaximum,
}
