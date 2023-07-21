// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LSA_LOOKUP_DOMAIN_INFO_CLASS.xml' path='doc/member[@name="LSA_LOOKUP_DOMAIN_INFO_CLASS"]/*' />
public enum LSA_LOOKUP_DOMAIN_INFO_CLASS
{
    /// <include file='LSA_LOOKUP_DOMAIN_INFO_CLASS.xml' path='doc/member[@name="LSA_LOOKUP_DOMAIN_INFO_CLASS.AccountDomainInformation"]/*' />
    AccountDomainInformation = 5,

    /// <include file='LSA_LOOKUP_DOMAIN_INFO_CLASS.xml' path='doc/member[@name="LSA_LOOKUP_DOMAIN_INFO_CLASS.DnsDomainInformation"]/*' />
    DnsDomainInformation = 12,
}
