// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL"]/*' />
public partial struct WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL
{
    /// <include file='WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.credential"]/*' />
    public WS_WINDOWS_INTEGRATED_AUTH_CREDENTIAL credential;

    /// <include file='WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.username"]/*' />
    public WS_STRING username;

    /// <include file='WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.password"]/*' />
    public WS_STRING password;

    /// <include file='WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.xml' path='doc/member[@name="WS_STRING_WINDOWS_INTEGRATED_AUTH_CREDENTIAL.domain"]/*' />
    public WS_STRING domain;
}
