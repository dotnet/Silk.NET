// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE"]/*' />
public enum TRUSTEE_TYPE
{
    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_UNKNOWN"]/*' />
    TRUSTEE_IS_UNKNOWN,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_USER"]/*' />
    TRUSTEE_IS_USER,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_GROUP"]/*' />
    TRUSTEE_IS_GROUP,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_DOMAIN"]/*' />
    TRUSTEE_IS_DOMAIN,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_ALIAS"]/*' />
    TRUSTEE_IS_ALIAS,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_WELL_KNOWN_GROUP"]/*' />
    TRUSTEE_IS_WELL_KNOWN_GROUP,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_DELETED"]/*' />
    TRUSTEE_IS_DELETED,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_INVALID"]/*' />
    TRUSTEE_IS_INVALID,

    /// <include file='TRUSTEE_TYPE.xml' path='doc/member[@name="TRUSTEE_TYPE.TRUSTEE_IS_COMPUTER"]/*' />
    TRUSTEE_IS_COMPUTER,
}
