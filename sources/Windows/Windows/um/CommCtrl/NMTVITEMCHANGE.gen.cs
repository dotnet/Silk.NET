// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE"]/*' />
public partial struct NMTVITEMCHANGE
{
    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.uChanged"]/*' />
    public uint uChanged;

    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.hItem"]/*' />
    public HTREEITEM hItem;

    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.uStateNew"]/*' />
    public uint uStateNew;

    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.uStateOld"]/*' />
    public uint uStateOld;

    /// <include file='NMTVITEMCHANGE.xml' path='doc/member[@name="NMTVITEMCHANGE.lParam"]/*' />
    public LPARAM lParam;
}
