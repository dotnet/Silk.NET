// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE"]/*' />
public enum PROPDESC_AGGREGATION_TYPE
{
    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_DEFAULT"]/*' />
    PDAT_DEFAULT = 0,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_FIRST"]/*' />
    PDAT_FIRST = 1,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_SUM"]/*' />
    PDAT_SUM = 2,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_AVERAGE"]/*' />
    PDAT_AVERAGE = 3,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_DATERANGE"]/*' />
    PDAT_DATERANGE = 4,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_UNION"]/*' />
    PDAT_UNION = 5,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_MAX"]/*' />
    PDAT_MAX = 6,

    /// <include file='PROPDESC_AGGREGATION_TYPE.xml' path='doc/member[@name="PROPDESC_AGGREGATION_TYPE.PDAT_MIN"]/*' />
    PDAT_MIN = 7,
}
