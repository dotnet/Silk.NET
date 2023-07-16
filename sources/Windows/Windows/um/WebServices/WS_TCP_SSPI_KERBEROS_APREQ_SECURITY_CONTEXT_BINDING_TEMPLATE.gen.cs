// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE"]/*'/>
public partial struct WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE
{
    /// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.channelProperties"]/*'/>
    public WS_CHANNEL_PROPERTIES channelProperties;
    /// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.securityProperties"]/*'/>
    public WS_SECURITY_PROPERTIES securityProperties;
    /// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.sspiTransportSecurityBinding"]/*'/>
    public WS_TCP_SSPI_TRANSPORT_SECURITY_BINDING_TEMPLATE sspiTransportSecurityBinding;
    /// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.kerberosApreqMessageSecurityBinding"]/*'/>
    public WS_KERBEROS_APREQ_MESSAGE_SECURITY_BINDING_TEMPLATE kerberosApreqMessageSecurityBinding;
    /// <include file='WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.xml' path='doc/member[@name="WS_TCP_SSPI_KERBEROS_APREQ_SECURITY_CONTEXT_BINDING_TEMPLATE.securityContextSecurityBinding"]/*'/>
    public WS_SECURITY_CONTEXT_SECURITY_BINDING_TEMPLATE securityContextSecurityBinding;
}