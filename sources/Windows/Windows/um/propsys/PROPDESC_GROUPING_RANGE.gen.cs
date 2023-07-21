// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE"]/*' />
public enum PROPDESC_GROUPING_RANGE
{
    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_DISCRETE"]/*' />
    PDGR_DISCRETE = 0,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_ALPHANUMERIC"]/*' />
    PDGR_ALPHANUMERIC = 1,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_SIZE"]/*' />
    PDGR_SIZE = 2,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_DYNAMIC"]/*' />
    PDGR_DYNAMIC = 3,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_DATE"]/*' />
    PDGR_DATE = 4,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_PERCENT"]/*' />
    PDGR_PERCENT = 5,

    /// <include file='PROPDESC_GROUPING_RANGE.xml' path='doc/member[@name="PROPDESC_GROUPING_RANGE.PDGR_ENUMERATED"]/*' />
    PDGR_ENUMERATED = 6,
}
