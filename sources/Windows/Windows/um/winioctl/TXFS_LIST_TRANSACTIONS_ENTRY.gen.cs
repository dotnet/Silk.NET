// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY"]/*' />
public partial struct TXFS_LIST_TRANSACTIONS_ENTRY
{
    /// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY.TransactionId"]/*' />
    public Guid TransactionId;

    /// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY.TransactionState"]/*' />
    [NativeTypeName("DWORD")]
    public uint TransactionState;

    /// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;

    /// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;

    /// <include file='TXFS_LIST_TRANSACTIONS_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTIONS_ENTRY.Reserved3"]/*' />
    [NativeTypeName("LONGLONG")]
    public long Reserved3;
}
