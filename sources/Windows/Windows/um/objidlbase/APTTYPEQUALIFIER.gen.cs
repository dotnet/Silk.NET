// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER"]/*' />
public enum APTTYPEQUALIFIER
{
    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NONE"]/*' />
    APTTYPEQUALIFIER_NONE = 0,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_IMPLICIT_MTA"]/*' />
    APTTYPEQUALIFIER_IMPLICIT_MTA = 1,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_MTA"]/*' />
    APTTYPEQUALIFIER_NA_ON_MTA = 2,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_STA"]/*' />
    APTTYPEQUALIFIER_NA_ON_STA = 3,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA"]/*' />
    APTTYPEQUALIFIER_NA_ON_IMPLICIT_MTA = 4,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_NA_ON_MAINSTA"]/*' />
    APTTYPEQUALIFIER_NA_ON_MAINSTA = 5,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_APPLICATION_STA"]/*' />
    APTTYPEQUALIFIER_APPLICATION_STA = 6,

    /// <include file='APTTYPEQUALIFIER.xml' path='doc/member[@name="APTTYPEQUALIFIER.APTTYPEQUALIFIER_RESERVED_1"]/*' />
    APTTYPEQUALIFIER_RESERVED_1 = 7,
}
