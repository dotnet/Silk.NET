// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POLICY_PRIMARY_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_PRIMARY_DOMAIN_INFO"]/*' />
public unsafe partial struct POLICY_PRIMARY_DOMAIN_INFO
{
    /// <include file='POLICY_PRIMARY_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_PRIMARY_DOMAIN_INFO.Name"]/*' />
    public LSA_UNICODE_STRING Name;

    /// <include file='POLICY_PRIMARY_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_PRIMARY_DOMAIN_INFO.Sid"]/*' />
    [NativeTypeName("PSID")]
    public void* Sid;
}
