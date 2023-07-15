// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRANSACTION_NOTIFICATION.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION"]/*'/>
public unsafe partial struct TRANSACTION_NOTIFICATION
{
    /// <include file='TRANSACTION_NOTIFICATION.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION.TransactionKey"]/*'/>
    [NativeTypeName("PVOID")]
    public void* TransactionKey;
    /// <include file='TRANSACTION_NOTIFICATION.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION.TransactionNotification"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TransactionNotification;
    /// <include file='TRANSACTION_NOTIFICATION.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION.TmVirtualClock"]/*'/>
    public LARGE_INTEGER TmVirtualClock;
    /// <include file='TRANSACTION_NOTIFICATION.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION.ArgumentLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ArgumentLength;
}