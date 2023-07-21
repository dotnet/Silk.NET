// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMLINK.xml' path='doc/member[@name="NMLINK"]/*' />
public partial struct NMLINK
{
    /// <include file='NMLINK.xml' path='doc/member[@name="NMLINK.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMLINK.xml' path='doc/member[@name="NMLINK.item"]/*' />
    public LITEM item;
}
