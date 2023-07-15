// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES"]/*'/>
public partial struct TXFS_LIST_TRANSACTION_LOCKED_FILES
{
    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES.KtmTransaction"]/*'/>
    public Guid KtmTransaction;
    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES.NumberOfFiles"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong NumberOfFiles;
    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES.BufferSizeRequired"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong BufferSizeRequired;
    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES.Offset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;
}