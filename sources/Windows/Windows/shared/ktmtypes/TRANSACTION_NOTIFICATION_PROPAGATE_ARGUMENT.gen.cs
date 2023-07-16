// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT"]/*'/>
public partial struct TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT
{
    /// <include file='TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.PropagationCookie"]/*'/>
    [NativeTypeName("ULONG")]
    public uint PropagationCookie;
    /// <include file='TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.UOW"]/*'/>
    public Guid UOW;
    /// <include file='TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.TmIdentity"]/*'/>
    public Guid TmIdentity;
    /// <include file='TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.xml' path='doc/member[@name="TRANSACTION_NOTIFICATION_PROPAGATE_ARGUMENT.BufferLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint BufferLength;
}