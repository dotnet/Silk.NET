// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMRSETPIXELV.xml' path='doc/member[@name="EMRSETPIXELV"]/*' />
public partial struct EMRSETPIXELV
{
    /// <include file='EMRSETPIXELV.xml' path='doc/member[@name="EMRSETPIXELV.emr"]/*' />
    public EMR emr;

    /// <include file='EMRSETPIXELV.xml' path='doc/member[@name="EMRSETPIXELV.ptlPixel"]/*' />
    public POINTL ptlPixel;

    /// <include file='EMRSETPIXELV.xml' path='doc/member[@name="EMRSETPIXELV.crColor"]/*' />
    public COLORREF crColor;
}
