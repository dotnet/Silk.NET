// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE"]/*' />
public enum SPMATCHINGMODE
{
    /// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE.AllWords"]/*' />
    AllWords = 0,

    /// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE.Subsequence"]/*' />
    Subsequence = 1,

    /// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE.OrderedSubset"]/*' />
    OrderedSubset = 3,

    /// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE.SubsequenceContentRequired"]/*' />
    SubsequenceContentRequired = 5,

    /// <include file='SPMATCHINGMODE.xml' path='doc/member[@name="SPMATCHINGMODE.OrderedSubsetContentRequired"]/*' />
    OrderedSubsetContentRequired = 7,
}
