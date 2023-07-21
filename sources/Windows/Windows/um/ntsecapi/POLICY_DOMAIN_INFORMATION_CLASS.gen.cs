// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_DOMAIN_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_DOMAIN_INFORMATION_CLASS"]/*' />
public enum POLICY_DOMAIN_INFORMATION_CLASS
{
    /// <include file='POLICY_DOMAIN_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_DOMAIN_INFORMATION_CLASS.PolicyDomainEfsInformation"]/*' />
    PolicyDomainEfsInformation = 2,

    /// <include file='POLICY_DOMAIN_INFORMATION_CLASS.xml' path='doc/member[@name="POLICY_DOMAIN_INFORMATION_CLASS.PolicyDomainKerberosTicketInformation"]/*' />
    PolicyDomainKerberosTicketInformation,
}
