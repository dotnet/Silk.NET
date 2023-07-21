// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMROFFSETCLIPRGN.xml' path='doc/member[@name="EMROFFSETCLIPRGN"]/*' />
public partial struct EMROFFSETCLIPRGN
{
    /// <include file='EMROFFSETCLIPRGN.xml' path='doc/member[@name="EMROFFSETCLIPRGN.emr"]/*' />
    public EMR emr;

    /// <include file='EMROFFSETCLIPRGN.xml' path='doc/member[@name="EMROFFSETCLIPRGN.ptlOffset"]/*' />
    public POINTL ptlOffset;
}
