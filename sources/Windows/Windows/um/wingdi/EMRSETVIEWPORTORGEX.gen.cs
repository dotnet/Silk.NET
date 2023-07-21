// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRSETVIEWPORTORGEX.xml' path='doc/member[@name="EMRSETVIEWPORTORGEX"]/*' />
public partial struct EMRSETVIEWPORTORGEX
{
    /// <include file='EMRSETVIEWPORTORGEX.xml' path='doc/member[@name="EMRSETVIEWPORTORGEX.emr"]/*' />
    public EMR emr;

    /// <include file='EMRSETVIEWPORTORGEX.xml' path='doc/member[@name="EMRSETVIEWPORTORGEX.ptlOrigin"]/*' />
    public POINTL ptlOrigin;
}
