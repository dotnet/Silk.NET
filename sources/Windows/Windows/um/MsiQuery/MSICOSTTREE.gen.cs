// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSICOSTTREE.xml' path='doc/member[@name="MSICOSTTREE"]/*' />
public enum MSICOSTTREE
{
    /// <include file='MSICOSTTREE.xml' path='doc/member[@name="MSICOSTTREE.MSICOSTTREE_SELFONLY"]/*' />
    MSICOSTTREE_SELFONLY = 0,

    /// <include file='MSICOSTTREE.xml' path='doc/member[@name="MSICOSTTREE.MSICOSTTREE_CHILDREN"]/*' />
    MSICOSTTREE_CHILDREN = 1,

    /// <include file='MSICOSTTREE.xml' path='doc/member[@name="MSICOSTTREE.MSICOSTTREE_PARENTS"]/*' />
    MSICOSTTREE_PARENTS = 2,

    /// <include file='MSICOSTTREE.xml' path='doc/member[@name="MSICOSTTREE.MSICOSTTREE_RESERVED"]/*' />
    MSICOSTTREE_RESERVED = 3,
}
