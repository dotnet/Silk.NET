// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE"]/*' />
[Flags]
public enum ACCESS_REASON_TYPE
{
    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNone"]/*' />
    AccessReasonNone = 0x00000000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonAllowedAce"]/*' />
    AccessReasonAllowedAce = 0x00010000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonDeniedAce"]/*' />
    AccessReasonDeniedAce = 0x00020000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonAllowedParentAce"]/*' />
    AccessReasonAllowedParentAce = 0x00030000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonDeniedParentAce"]/*' />
    AccessReasonDeniedParentAce = 0x00040000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedByCape"]/*' />
    AccessReasonNotGrantedByCape = 0x00050000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedByParentCape"]/*' />
    AccessReasonNotGrantedByParentCape = 0x00060000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNotGrantedToAppContainer"]/*' />
    AccessReasonNotGrantedToAppContainer = 0x00070000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonMissingPrivilege"]/*' />
    AccessReasonMissingPrivilege = 0x00100000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonFromPrivilege"]/*' />
    AccessReasonFromPrivilege = 0x00200000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonIntegrityLevel"]/*' />
    AccessReasonIntegrityLevel = 0x00300000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonOwnership"]/*' />
    AccessReasonOwnership = 0x00400000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNullDacl"]/*' />
    AccessReasonNullDacl = 0x00500000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonEmptyDacl"]/*' />
    AccessReasonEmptyDacl = 0x00600000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNoSD"]/*' />
    AccessReasonNoSD = 0x00700000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonNoGrant"]/*' />
    AccessReasonNoGrant = 0x00800000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonTrustLabel"]/*' />
    AccessReasonTrustLabel = 0x00900000,

    /// <include file='ACCESS_REASON_TYPE.xml' path='doc/member[@name="ACCESS_REASON_TYPE.AccessReasonFilterAce"]/*' />
    AccessReasonFilterAce = 0x00a00000,
}
