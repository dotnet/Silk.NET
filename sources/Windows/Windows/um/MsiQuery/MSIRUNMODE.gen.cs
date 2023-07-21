// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE"]/*' />
public enum MSIRUNMODE
{
    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_ADMIN"]/*' />
    MSIRUNMODE_ADMIN = 0,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_ADVERTISE"]/*' />
    MSIRUNMODE_ADVERTISE = 1,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_MAINTENANCE"]/*' />
    MSIRUNMODE_MAINTENANCE = 2,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_ROLLBACKENABLED"]/*' />
    MSIRUNMODE_ROLLBACKENABLED = 3,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_LOGENABLED"]/*' />
    MSIRUNMODE_LOGENABLED = 4,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_OPERATIONS"]/*' />
    MSIRUNMODE_OPERATIONS = 5,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_REBOOTATEND"]/*' />
    MSIRUNMODE_REBOOTATEND = 6,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_REBOOTNOW"]/*' />
    MSIRUNMODE_REBOOTNOW = 7,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_CABINET"]/*' />
    MSIRUNMODE_CABINET = 8,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_SOURCESHORTNAMES"]/*' />
    MSIRUNMODE_SOURCESHORTNAMES = 9,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_TARGETSHORTNAMES"]/*' />
    MSIRUNMODE_TARGETSHORTNAMES = 10,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_RESERVED11"]/*' />
    MSIRUNMODE_RESERVED11 = 11,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_WINDOWS9X"]/*' />
    MSIRUNMODE_WINDOWS9X = 12,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_ZAWENABLED"]/*' />
    MSIRUNMODE_ZAWENABLED = 13,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_RESERVED14"]/*' />
    MSIRUNMODE_RESERVED14 = 14,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_RESERVED15"]/*' />
    MSIRUNMODE_RESERVED15 = 15,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_SCHEDULED"]/*' />
    MSIRUNMODE_SCHEDULED = 16,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_ROLLBACK"]/*' />
    MSIRUNMODE_ROLLBACK = 17,

    /// <include file='MSIRUNMODE.xml' path='doc/member[@name="MSIRUNMODE.MSIRUNMODE_COMMIT"]/*' />
    MSIRUNMODE_COMMIT = 18,
}
