// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE"]/*' />
public partial struct NMITEMACTIVATE
{
    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.iItem"]/*' />
    public int iItem;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.iSubItem"]/*' />
    public int iSubItem;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.uNewState"]/*' />
    public uint uNewState;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.uOldState"]/*' />
    public uint uOldState;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.uChanged"]/*' />
    public uint uChanged;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.ptAction"]/*' />
    public POINT ptAction;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='NMITEMACTIVATE.xml' path='doc/member[@name="NMITEMACTIVATE.uKeyFlags"]/*' />
    public uint uKeyFlags;
}
