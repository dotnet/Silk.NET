// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMLVLINK.xml' path='doc/member[@name="NMLVLINK"]/*' />
public partial struct NMLVLINK
{
    /// <include file='NMLVLINK.xml' path='doc/member[@name="NMLVLINK.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMLVLINK.xml' path='doc/member[@name="NMLVLINK.link"]/*' />
    public LITEM link;

    /// <include file='NMLVLINK.xml' path='doc/member[@name="NMLVLINK.iItem"]/*' />
    public int iItem;

    /// <include file='NMLVLINK.xml' path='doc/member[@name="NMLVLINK.iSubItem"]/*' />
    public int iSubItem;
}
