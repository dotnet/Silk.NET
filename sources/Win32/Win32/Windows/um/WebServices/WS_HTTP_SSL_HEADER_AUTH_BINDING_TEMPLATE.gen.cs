// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WS_HTTP_SSL_HEADER_AUTH_BINDING_TEMPLATE
{
    public WS_CHANNEL_PROPERTIES channelProperties;
    public WS_SECURITY_PROPERTIES securityProperties;
    public WS_SSL_TRANSPORT_SECURITY_BINDING_TEMPLATE sslTransportSecurityBinding;
    public WS_HTTP_HEADER_AUTH_SECURITY_BINDING_TEMPLATE httpHeaderAuthSecurityBinding;
}
