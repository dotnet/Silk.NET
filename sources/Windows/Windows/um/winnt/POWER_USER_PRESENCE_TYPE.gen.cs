// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_USER_PRESENCE_TYPE.xml' path='doc/member[@name="POWER_USER_PRESENCE_TYPE"]/*' />
public enum POWER_USER_PRESENCE_TYPE
{
    /// <include file='POWER_USER_PRESENCE_TYPE.xml' path='doc/member[@name="POWER_USER_PRESENCE_TYPE.UserNotPresent"]/*' />
    UserNotPresent = 0,

    /// <include file='POWER_USER_PRESENCE_TYPE.xml' path='doc/member[@name="POWER_USER_PRESENCE_TYPE.UserPresent"]/*' />
    UserPresent = 1,

    /// <include file='POWER_USER_PRESENCE_TYPE.xml' path='doc/member[@name="POWER_USER_PRESENCE_TYPE.UserUnknown"]/*' />
    UserUnknown = 0xff,
}
