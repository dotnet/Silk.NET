// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT"]/*'/>
public unsafe partial struct CRYPT_PROVIDER_CERT
{
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.pCert"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pCert;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fCommercial"]/*'/>
    public BOOL fCommercial;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fTrustedRoot"]/*'/>
    public BOOL fTrustedRoot;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fSelfSigned"]/*'/>
    public BOOL fSelfSigned;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fTestCert"]/*'/>
    public BOOL fTestCert;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.dwRevokedReason"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevokedReason;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.dwConfidence"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwConfidence;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.dwError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwError;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.pTrustListContext"]/*'/>
    public CTL_CONTEXT* pTrustListContext;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fTrustListSignerCert"]/*'/>
    public BOOL fTrustListSignerCert;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.pCtlContext"]/*'/>
    [NativeTypeName("PCCTL_CONTEXT")]
    public CTL_CONTEXT* pCtlContext;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.dwCtlError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCtlError;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.fIsCyclic"]/*'/>
    public BOOL fIsCyclic;
    /// <include file='CRYPT_PROVIDER_CERT.xml' path='doc/member[@name="CRYPT_PROVIDER_CERT.pChainElement"]/*'/>
    [NativeTypeName("PCERT_CHAIN_ELEMENT")]
    public CERT_CHAIN_ELEMENT* pChainElement;
}