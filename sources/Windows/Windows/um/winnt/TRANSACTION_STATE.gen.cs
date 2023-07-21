// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRANSACTION_STATE.xml' path='doc/member[@name="TRANSACTION_STATE"]/*' />
public enum TRANSACTION_STATE
{
    /// <include file='TRANSACTION_STATE.xml' path='doc/member[@name="TRANSACTION_STATE.TransactionStateNormal"]/*' />
    TransactionStateNormal = 1,

    /// <include file='TRANSACTION_STATE.xml' path='doc/member[@name="TRANSACTION_STATE.TransactionStateIndoubt"]/*' />
    TransactionStateIndoubt,

    /// <include file='TRANSACTION_STATE.xml' path='doc/member[@name="TRANSACTION_STATE.TransactionStateCommittedNotify"]/*' />
    TransactionStateCommittedNotify,
}
