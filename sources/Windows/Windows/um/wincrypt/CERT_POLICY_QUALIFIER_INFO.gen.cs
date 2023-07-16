// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_POLICY_QUALIFIER_INFO.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_INFO"]/*'/>
public unsafe partial struct CERT_POLICY_QUALIFIER_INFO
{
    /// <include file='CERT_POLICY_QUALIFIER_INFO.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_INFO.pszPolicyQualifierId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszPolicyQualifierId;
    /// <include file='CERT_POLICY_QUALIFIER_INFO.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_INFO.Qualifier"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Qualifier;
}