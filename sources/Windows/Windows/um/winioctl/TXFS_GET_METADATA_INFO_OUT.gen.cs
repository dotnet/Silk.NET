// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TXFS_GET_METADATA_INFO_OUT.xml' path='doc/member[@name="TXFS_GET_METADATA_INFO_OUT"]/*'/>
public partial struct TXFS_GET_METADATA_INFO_OUT
{
    /// <include file='TXFS_GET_METADATA_INFO_OUT.xml' path='doc/member[@name="TXFS_GET_METADATA_INFO_OUT.TxfFileId"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L13302_C5")]
    public _TxfFileId_e__Struct TxfFileId;
    /// <include file='TXFS_GET_METADATA_INFO_OUT.xml' path='doc/member[@name="TXFS_GET_METADATA_INFO_OUT.LockingTransaction"]/*'/>
    public Guid LockingTransaction;
    /// <include file='TXFS_GET_METADATA_INFO_OUT.xml' path='doc/member[@name="TXFS_GET_METADATA_INFO_OUT.LastLsn"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong LastLsn;
    /// <include file='TXFS_GET_METADATA_INFO_OUT.xml' path='doc/member[@name="TXFS_GET_METADATA_INFO_OUT.TransactionState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TransactionState;
    /// <include file='_TxfFileId_e__Struct.xml' path='doc/member[@name="_TxfFileId_e__Struct"]/*'/>
    public partial struct _TxfFileId_e__Struct
    {
        /// <include file='_TxfFileId_e__Struct.xml' path='doc/member[@name="_TxfFileId_e__Struct.LowPart"]/*'/>
        [NativeTypeName("LONGLONG")]
        public long LowPart;
        /// <include file='_TxfFileId_e__Struct.xml' path='doc/member[@name="_TxfFileId_e__Struct.HighPart"]/*'/>
        [NativeTypeName("LONGLONG")]
        public long HighPart;
    }
}