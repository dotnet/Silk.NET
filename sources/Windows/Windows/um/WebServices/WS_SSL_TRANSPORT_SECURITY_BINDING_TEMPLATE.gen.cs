// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE"]/*' />
public unsafe partial struct WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE
{
    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE.securityBindingProperties"]/*' />
    public WS_SECURITY_BINDING_PROPERTIES securityBindingProperties;

    /// <include file='WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE.localCertCredential"]/*' />
    public WS_CERT_CREDENTIAL* localCertCredential;
}
