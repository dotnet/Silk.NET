// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE"]/*' />
public enum ACCESS_MODE
{
    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.NOT_USED_ACCESS"]/*' />
    NOT_USED_ACCESS = 0,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.GRANT_ACCESS"]/*' />
    GRANT_ACCESS,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.SET_ACCESS"]/*' />
    SET_ACCESS,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.DENY_ACCESS"]/*' />
    DENY_ACCESS,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.REVOKE_ACCESS"]/*' />
    REVOKE_ACCESS,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.SET_AUDIT_SUCCESS"]/*' />
    SET_AUDIT_SUCCESS,

    /// <include file='ACCESS_MODE.xml' path='doc/member[@name="ACCESS_MODE.SET_AUDIT_FAILURE"]/*' />
    SET_AUDIT_FAILURE,
}
