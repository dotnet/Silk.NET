// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA"]/*'/>
public unsafe partial struct CERT_REVOCATION_PARA
{
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.pIssuerCert"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pIssuerCert;
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.cCertStore"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCertStore;
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.rgCertStore"]/*'/>
    public HCERTSTORE* rgCertStore;
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.hCrlStore"]/*'/>
    public HCERTSTORE hCrlStore;
    /// <include file='CERT_REVOCATION_PARA.xml' path='doc/member[@name="CERT_REVOCATION_PARA.pftTimeToUse"]/*'/>
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftTimeToUse;
}