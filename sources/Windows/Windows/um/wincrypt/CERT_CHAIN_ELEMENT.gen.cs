// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT"]/*'/>
public unsafe partial struct CERT_CHAIN_ELEMENT
{
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.pCertContext"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pCertContext;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.TrustStatus"]/*'/>
    public CERT_TRUST_STATUS TrustStatus;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.pRevocationInfo"]/*'/>
    [NativeTypeName("PCERT_REVOCATION_INFO")]
    public CERT_REVOCATION_INFO* pRevocationInfo;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.pIssuanceUsage"]/*'/>
    [NativeTypeName("PCERT_ENHKEY_USAGE")]
    public CTL_USAGE* pIssuanceUsage;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.pApplicationUsage"]/*'/>
    [NativeTypeName("PCERT_ENHKEY_USAGE")]
    public CTL_USAGE* pApplicationUsage;
    /// <include file='CERT_CHAIN_ELEMENT.xml' path='doc/member[@name="CERT_CHAIN_ELEMENT.pwszExtendedErrorInfo"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszExtendedErrorInfo;
}