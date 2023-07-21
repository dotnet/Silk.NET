// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE"]/*' />
public enum SECURELOCKCODE
{
    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_NOCHANGE"]/*' />
    SECURELOCK_NOCHANGE = -1,

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_UNSECURE"]/*' />
    SECURELOCK_SET_UNSECURE = 0,

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_MIXED"]/*' />
    SECURELOCK_SET_MIXED = (SECURELOCK_SET_UNSECURE + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_SECUREUNKNOWNBIT"]/*' />
    SECURELOCK_SET_SECUREUNKNOWNBIT = (SECURELOCK_SET_MIXED + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_SECURE40BIT"]/*' />
    SECURELOCK_SET_SECURE40BIT = (SECURELOCK_SET_SECUREUNKNOWNBIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_SECURE56BIT"]/*' />
    SECURELOCK_SET_SECURE56BIT = (SECURELOCK_SET_SECURE40BIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_FORTEZZA"]/*' />
    SECURELOCK_SET_FORTEZZA = (SECURELOCK_SET_SECURE56BIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SET_SECURE128BIT"]/*' />
    SECURELOCK_SET_SECURE128BIT = (SECURELOCK_SET_FORTEZZA + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_FIRSTSUGGEST"]/*' />
    SECURELOCK_FIRSTSUGGEST = (SECURELOCK_SET_SECURE128BIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_UNSECURE"]/*' />
    SECURELOCK_SUGGEST_UNSECURE = SECURELOCK_FIRSTSUGGEST,

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_MIXED"]/*' />
    SECURELOCK_SUGGEST_MIXED = (SECURELOCK_SUGGEST_UNSECURE + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_SECUREUNKNOWNBIT"]/*' />
    SECURELOCK_SUGGEST_SECUREUNKNOWNBIT = (SECURELOCK_SUGGEST_MIXED + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_SECURE40BIT"]/*' />
    SECURELOCK_SUGGEST_SECURE40BIT = (SECURELOCK_SUGGEST_SECUREUNKNOWNBIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_SECURE56BIT"]/*' />
    SECURELOCK_SUGGEST_SECURE56BIT = (SECURELOCK_SUGGEST_SECURE40BIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_FORTEZZA"]/*' />
    SECURELOCK_SUGGEST_FORTEZZA = (SECURELOCK_SUGGEST_SECURE56BIT + 1),

    /// <include file='SECURELOCKCODE.xml' path='doc/member[@name="SECURELOCKCODE.SECURELOCK_SUGGEST_SECURE128BIT"]/*' />
    SECURELOCK_SUGGEST_SECURE128BIT = (SECURELOCK_SUGGEST_FORTEZZA + 1),
}
