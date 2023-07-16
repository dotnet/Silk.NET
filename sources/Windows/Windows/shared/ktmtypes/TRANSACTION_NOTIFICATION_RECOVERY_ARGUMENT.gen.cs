// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT"]/*'/>
public partial struct TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT
{
    /// <include file='TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT.EnlistmentId"]/*'/>
    public Guid EnlistmentId;
    /// <include file='TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT.UOW"]/*'/>
    [NativeTypeName("UOW")]
    public Guid UOW;
}