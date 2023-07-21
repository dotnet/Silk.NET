// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_PACKAGE"]/*' />
public enum WS_WINDOWS_INTEGRATED_AUTH_PACKAGE
{
    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_KERBEROS"]/*' />
    WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_KERBEROS = 1,

    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_NTLM"]/*' />
    WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_NTLM = 2,

    /// <include file='WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.xml' path='doc/member[@name="WS_WINDOWS_INTEGRATED_AUTH_PACKAGE.WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_SPNEGO"]/*' />
    WS_WINDOWS_INTEGRATED_AUTH_PACKAGE_SPNEGO = 3,
}
