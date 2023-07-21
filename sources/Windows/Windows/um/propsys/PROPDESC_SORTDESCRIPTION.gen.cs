// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION"]/*' />
public enum PROPDESC_SORTDESCRIPTION
{
    /// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION.PDSD_GENERAL"]/*' />
    PDSD_GENERAL = 0,

    /// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION.PDSD_A_Z"]/*' />
    PDSD_A_Z = 1,

    /// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION.PDSD_LOWEST_HIGHEST"]/*' />
    PDSD_LOWEST_HIGHEST = 2,

    /// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION.PDSD_SMALLEST_BIGGEST"]/*' />
    PDSD_SMALLEST_BIGGEST = 3,

    /// <include file='PROPDESC_SORTDESCRIPTION.xml' path='doc/member[@name="PROPDESC_SORTDESCRIPTION.PDSD_OLDEST_NEWEST"]/*' />
    PDSD_OLDEST_NEWEST = 4,
}
