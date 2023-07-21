// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE"]/*' />
public enum MSV1_0_CREDENTIAL_KEY_TYPE
{
    /// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE.InvalidCredKey"]/*' />
    InvalidCredKey,

    /// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE.DeprecatedIUMCredKey"]/*' />
    DeprecatedIUMCredKey,

    /// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE.DomainUserCredKey"]/*' />
    DomainUserCredKey,

    /// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE.LocalUserCredKey"]/*' />
    LocalUserCredKey,

    /// <include file='MSV1_0_CREDENTIAL_KEY_TYPE.xml' path='doc/member[@name="MSV1_0_CREDENTIAL_KEY_TYPE.ExternallySuppliedCredKey"]/*' />
    ExternallySuppliedCredKey,
}
