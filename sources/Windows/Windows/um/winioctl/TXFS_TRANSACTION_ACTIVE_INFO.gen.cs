// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TXFS_TRANSACTION_ACTIVE_INFO.xml' path='doc/member[@name="TXFS_TRANSACTION_ACTIVE_INFO"]/*'/>
public partial struct TXFS_TRANSACTION_ACTIVE_INFO
{
    /// <include file='TXFS_TRANSACTION_ACTIVE_INFO.xml' path='doc/member[@name="TXFS_TRANSACTION_ACTIVE_INFO.TransactionsActiveAtSnapshot"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte TransactionsActiveAtSnapshot;
}