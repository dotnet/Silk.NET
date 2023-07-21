// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE"]/*' />
public enum PROPDESC_CONDITION_TYPE
{
    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_NONE"]/*' />
    PDCOT_NONE = 0,

    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_STRING"]/*' />
    PDCOT_STRING = 1,

    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_SIZE"]/*' />
    PDCOT_SIZE = 2,

    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_DATETIME"]/*' />
    PDCOT_DATETIME = 3,

    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_BOOLEAN"]/*' />
    PDCOT_BOOLEAN = 4,

    /// <include file='PROPDESC_CONDITION_TYPE.xml' path='doc/member[@name="PROPDESC_CONDITION_TYPE.PDCOT_NUMBER"]/*' />
    PDCOT_NUMBER = 5,
}
