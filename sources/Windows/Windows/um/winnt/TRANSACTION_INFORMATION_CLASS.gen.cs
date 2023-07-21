// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS"]/*' />
public enum TRANSACTION_INFORMATION_CLASS
{
    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionBasicInformation"]/*' />
    TransactionBasicInformation,

    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionPropertiesInformation"]/*' />
    TransactionPropertiesInformation,

    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionEnlistmentInformation"]/*' />
    TransactionEnlistmentInformation,

    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionSuperiorEnlistmentInformation"]/*' />
    TransactionSuperiorEnlistmentInformation,

    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionBindInformation"]/*' />
    TransactionBindInformation,

    /// <include file='TRANSACTION_INFORMATION_CLASS.xml' path='doc/member[@name="TRANSACTION_INFORMATION_CLASS.TransactionDTCPrivateInformation"]/*' />
    TransactionDTCPrivateInformation,
}
