// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN"]/*' />
public unsafe partial struct EMRFILLRGN
{
    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.emr"]/*' />
    public EMR emr;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.rclBounds"]/*' />
    public RECTL rclBounds;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.cbRgnData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbRgnData;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.ihBrush"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihBrush;

    /// <include file='EMRFILLRGN.xml' path='doc/member[@name="EMRFILLRGN.RgnData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte RgnData[1];
}
