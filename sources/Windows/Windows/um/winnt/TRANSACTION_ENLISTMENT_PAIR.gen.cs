// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='TRANSACTION_ENLISTMENT_PAIR.xml' path='doc/member[@name="TRANSACTION_ENLISTMENT_PAIR"]/*' />
public partial struct TRANSACTION_ENLISTMENT_PAIR
{
    /// <include file='TRANSACTION_ENLISTMENT_PAIR.xml' path='doc/member[@name="TRANSACTION_ENLISTMENT_PAIR.EnlistmentId"]/*' />
    public Guid EnlistmentId;

    /// <include file='TRANSACTION_ENLISTMENT_PAIR.xml' path='doc/member[@name="TRANSACTION_ENLISTMENT_PAIR.ResourceManagerId"]/*' />
    public Guid ResourceManagerId;
}
