// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_KEY_USAGE_RESTRICTION_INFO.xml' path='doc/member[@name="CERT_KEY_USAGE_RESTRICTION_INFO"]/*'/>
public unsafe partial struct CERT_KEY_USAGE_RESTRICTION_INFO
{
    /// <include file='CERT_KEY_USAGE_RESTRICTION_INFO.xml' path='doc/member[@name="CERT_KEY_USAGE_RESTRICTION_INFO.cCertPolicyId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCertPolicyId;
    /// <include file='CERT_KEY_USAGE_RESTRICTION_INFO.xml' path='doc/member[@name="CERT_KEY_USAGE_RESTRICTION_INFO.rgCertPolicyId"]/*'/>
    [NativeTypeName("PCERT_POLICY_ID")]
    public CERT_POLICY_ID* rgCertPolicyId;
    /// <include file='CERT_KEY_USAGE_RESTRICTION_INFO.xml' path='doc/member[@name="CERT_KEY_USAGE_RESTRICTION_INFO.RestrictedKeyUsage"]/*'/>
    public CRYPT_BIT_BLOB RestrictedKeyUsage;
}