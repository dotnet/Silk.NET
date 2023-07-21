// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPERTY_METRICS.xml' path='doc/member[@name="PROPERTY_METRICS"]/*' />
public partial struct PROPERTY_METRICS
{
    /// <include file='PROPERTY_METRICS.xml' path='doc/member[@name="PROPERTY_METRICS.nLogicalMin"]/*' />
    [NativeTypeName("LONG")]
    public int nLogicalMin;

    /// <include file='PROPERTY_METRICS.xml' path='doc/member[@name="PROPERTY_METRICS.nLogicalMax"]/*' />
    [NativeTypeName("LONG")]
    public int nLogicalMax;

    /// <include file='PROPERTY_METRICS.xml' path='doc/member[@name="PROPERTY_METRICS.Units"]/*' />
    public PROPERTY_UNITS Units;

    /// <include file='PROPERTY_METRICS.xml' path='doc/member[@name="PROPERTY_METRICS.fResolution"]/*' />
    public float fResolution;
}
