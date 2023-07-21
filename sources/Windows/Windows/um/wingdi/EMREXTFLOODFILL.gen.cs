// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMREXTFLOODFILL.xml' path='doc/member[@name="EMREXTFLOODFILL"]/*' />
public partial struct EMREXTFLOODFILL
{
    /// <include file='EMREXTFLOODFILL.xml' path='doc/member[@name="EMREXTFLOODFILL.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTFLOODFILL.xml' path='doc/member[@name="EMREXTFLOODFILL.ptlStart"]/*' />
    public POINTL ptlStart;

    /// <include file='EMREXTFLOODFILL.xml' path='doc/member[@name="EMREXTFLOODFILL.crColor"]/*' />
    public COLORREF crColor;

    /// <include file='EMREXTFLOODFILL.xml' path='doc/member[@name="EMREXTFLOODFILL.iMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint iMode;
}
