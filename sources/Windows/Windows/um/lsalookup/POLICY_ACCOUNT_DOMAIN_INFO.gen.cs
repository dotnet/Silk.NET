// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POLICY_ACCOUNT_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_ACCOUNT_DOMAIN_INFO"]/*'/>
public unsafe partial struct POLICY_ACCOUNT_DOMAIN_INFO
{
    /// <include file='POLICY_ACCOUNT_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_ACCOUNT_DOMAIN_INFO.DomainName"]/*'/>
    public LSA_UNICODE_STRING DomainName;
    /// <include file='POLICY_ACCOUNT_DOMAIN_INFO.xml' path='doc/member[@name="POLICY_ACCOUNT_DOMAIN_INFO.DomainSid"]/*'/>
    [NativeTypeName("PSID")]
    public void* DomainSid;
}