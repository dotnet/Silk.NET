// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URLZONE.xml' path='doc/member[@name="URLZONE"]/*' />
public enum URLZONE
{
    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_INVALID"]/*' />
    URLZONE_INVALID = -1,

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_PREDEFINED_MIN"]/*' />
    URLZONE_PREDEFINED_MIN = 0,

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_LOCAL_MACHINE"]/*' />
    URLZONE_LOCAL_MACHINE = 0,

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_INTRANET"]/*' />
    URLZONE_INTRANET = (URLZONE_LOCAL_MACHINE + 1),

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_TRUSTED"]/*' />
    URLZONE_TRUSTED = (URLZONE_INTRANET + 1),

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_INTERNET"]/*' />
    URLZONE_INTERNET = (URLZONE_TRUSTED + 1),

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_UNTRUSTED"]/*' />
    URLZONE_UNTRUSTED = (URLZONE_INTERNET + 1),

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_PREDEFINED_MAX"]/*' />
    URLZONE_PREDEFINED_MAX = 999,

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_USER_MIN"]/*' />
    URLZONE_USER_MIN = 1000,

    /// <include file='URLZONE.xml' path='doc/member[@name="URLZONE.URLZONE_USER_MAX"]/*' />
    URLZONE_USER_MAX = 10000,
}
