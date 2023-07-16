// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TXFS_LIST_TRANSACTIONS.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS"]/*'/>
public partial struct TXFS_LIST_TRANSACTIONS
{
    /// <include file='TXFS_LIST_TRANSACTIONS.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS.NumberOfTransactions"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumberOfTransactions;
    /// <include file='TXFS_LIST_TRANSACTIONS.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS.BufferSizeRequired"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BufferSizeRequired;
}