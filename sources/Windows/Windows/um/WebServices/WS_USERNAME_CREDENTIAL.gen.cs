// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_USERNAME_CREDENTIAL"]/*' />
public partial struct WS_USERNAME_CREDENTIAL
{
    /// <include file='WS_USERNAME_CREDENTIAL.xml' path='doc/member[@name="WS_USERNAME_CREDENTIAL.credentialType"]/*' />
    public WS_USERNAME_CREDENTIAL_TYPE credentialType;
}
