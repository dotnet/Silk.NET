// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING"]/*' />
public unsafe partial struct WS_SSL_TRANSPORT_SECURITY_BINDING
{
    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING.binding"]/*' />
    public WS_SECURITY_BINDING binding;

    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING.localCertCredential"]/*' />
    public WS_CERT_CREDENTIAL* localCertCredential;
}
