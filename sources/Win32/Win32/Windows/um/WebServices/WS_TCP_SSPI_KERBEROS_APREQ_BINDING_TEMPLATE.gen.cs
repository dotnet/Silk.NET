// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct WS_TCP_SSPI_KERBEROS_APREQ_BINDING_TEMPLATE
{
    public WS_CHANNEL_PROPERTIES channelProperties;
    public WS_SECURITY_PROPERTIES securityProperties;
    public WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_TEMPLATE sspiTransportSecurityBinding;
    public WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_TEMPLATE kerberosApreqMessageSecurityBinding;
}
