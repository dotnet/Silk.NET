// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_SECURITY_BINDING_TYPE
{
    WS_SSL_TRANSPORT_SECURITY_BINDING_TYPE = 1,
    WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_TYPE = 2,
    WS_HTTP_HEADER_AUTH_SECURITY_BINDING_TYPE = 3,
    WS_USERNAME_MESSAGE_SECURITY_BINDING_TYPE = 4,
    WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_TYPE = 5,
    WS_XML_TOKEN_MESSAGE_SECURITY_BINDING_TYPE = 6,
    WS_SAML_MESSAGE_SECURITY_BINDING_TYPE = 7,
    WS_SECURITY_CONTEXT_MESSAGE_SECURITY_BINDING_TYPE = 8,
    WS_NAMEDPIPE_SSPI_TRANSPORT_SECURITY_BINDING_TYPE = 9,
}
