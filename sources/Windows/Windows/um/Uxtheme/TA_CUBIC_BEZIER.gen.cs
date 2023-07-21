// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER"]/*' />
public partial struct TA_CUBIC_BEZIER
{
    /// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER.header"]/*' />
    public TA_TIMINGFUNCTION header;

    /// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER.rX0"]/*' />
    public float rX0;

    /// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER.rY0"]/*' />
    public float rY0;

    /// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER.rX1"]/*' />
    public float rX1;

    /// <include file='TA_CUBIC_BEZIER.xml' path='doc/member[@name="TA_CUBIC_BEZIER.rY1"]/*' />
    public float rY1;
}
