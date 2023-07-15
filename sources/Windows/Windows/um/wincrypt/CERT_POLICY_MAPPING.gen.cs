// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_POLICY_MAPPING.xml' path='doc/member[@name="CERT_POLICY_MAPPING"]/*'/>
public unsafe partial struct CERT_POLICY_MAPPING
{
    /// <include file='CERT_POLICY_MAPPING.xml' path='doc/member[@name="CERT_POLICY_MAPPING.pszIssuerDomainPolicy"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszIssuerDomainPolicy;
    /// <include file='CERT_POLICY_MAPPING.xml' path='doc/member[@name="CERT_POLICY_MAPPING.pszSubjectDomainPolicy"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszSubjectDomainPolicy;
}