// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO"]/*'/>
public partial struct POLICY_DOMAIN_KERBEROS_TICKET_INFO
{
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.AuthenticationOptions"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AuthenticationOptions;
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.MaxServiceTicketAge"]/*'/>
    public LARGE_INTEGER MaxServiceTicketAge;
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.MaxTicketAge"]/*'/>
    public LARGE_INTEGER MaxTicketAge;
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.MaxRenewAge"]/*'/>
    public LARGE_INTEGER MaxRenewAge;
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.MaxClockSkew"]/*'/>
    public LARGE_INTEGER MaxClockSkew;
    /// <include file='POLICY_DOMAIN_KERBEROS_TICKET_INFO.xml' path='doc/member[@name="POLICY_DOMAIN_KERBEROS_TICKET_INFO.Reserved"]/*'/>
    public LARGE_INTEGER Reserved;
}