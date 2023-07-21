// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE"]/*' />
public enum INSTALLSTATE
{
    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_NOTUSED"]/*' />
    INSTALLSTATE_NOTUSED = -7,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_BADCONFIG"]/*' />
    INSTALLSTATE_BADCONFIG = -6,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_INCOMPLETE"]/*' />
    INSTALLSTATE_INCOMPLETE = -5,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_SOURCEABSENT"]/*' />
    INSTALLSTATE_SOURCEABSENT = -4,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_MOREDATA"]/*' />
    INSTALLSTATE_MOREDATA = -3,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_INVALIDARG"]/*' />
    INSTALLSTATE_INVALIDARG = -2,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_UNKNOWN"]/*' />
    INSTALLSTATE_UNKNOWN = -1,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_BROKEN"]/*' />
    INSTALLSTATE_BROKEN = 0,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_ADVERTISED"]/*' />
    INSTALLSTATE_ADVERTISED = 1,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_REMOVED"]/*' />
    INSTALLSTATE_REMOVED = 1,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_ABSENT"]/*' />
    INSTALLSTATE_ABSENT = 2,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_LOCAL"]/*' />
    INSTALLSTATE_LOCAL = 3,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_SOURCE"]/*' />
    INSTALLSTATE_SOURCE = 4,

    /// <include file='INSTALLSTATE.xml' path='doc/member[@name="INSTALLSTATE.INSTALLSTATE_DEFAULT"]/*' />
    INSTALLSTATE_DEFAULT = 5,
}
