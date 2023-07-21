// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO"]/*' />
public unsafe partial struct POLICY_DNS_DOMAIN_INFO
{
    /// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO.Name"]/*' />
    public LSA_UNICODE_STRING Name;

    /// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO.DnsDomainName"]/*' />
    public LSA_UNICODE_STRING DnsDomainName;

    /// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO.DnsForestName"]/*' />
    public LSA_UNICODE_STRING DnsForestName;

    /// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO.DomainGuid"]/*' />
    public Guid DomainGuid;

    /// <include file='POLICY_DNS_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_DNS_DOMAIN_INFO.Sid"]/*' />
    [NativeTypeName("PSID")]
    public void* Sid;
}
