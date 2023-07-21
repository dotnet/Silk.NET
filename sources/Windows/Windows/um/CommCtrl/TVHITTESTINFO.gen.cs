// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TVHITTESTINFO.xml' path='doc/member[@name="TVHITTESTINFO"]/*' />
public partial struct TVHITTESTINFO
{
    /// <include file='TVHITTESTINFO.xml' path='doc/member[@name="TVHITTESTINFO.pt"]/*' />
    public POINT pt;

    /// <include file='TVHITTESTINFO.xml' path='doc/member[@name="TVHITTESTINFO.flags"]/*' />
    public uint flags;

    /// <include file='TVHITTESTINFO.xml' path='doc/member[@name="TVHITTESTINFO.hItem"]/*' />
    public HTREEITEM hItem;
}
