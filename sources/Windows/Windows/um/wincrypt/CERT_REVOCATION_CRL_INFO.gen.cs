// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO"]/*'/>
public unsafe partial struct CERT_REVOCATION_CRL_INFO
{
    /// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO.pBaseCrlContext"]/*'/>
    [NativeTypeName("PCCRL_CONTEXT")]
    public CRL_CONTEXT* pBaseCrlContext;
    /// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO.pDeltaCrlContext"]/*'/>
    [NativeTypeName("PCCRL_CONTEXT")]
    public CRL_CONTEXT* pDeltaCrlContext;
    /// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO.pCrlEntry"]/*'/>
    [NativeTypeName("PCRL_ENTRY")]
    public CRL_ENTRY* pCrlEntry;
    /// <include file='CERT_REVOCATION_CRL_INFO.xml' path='doc/member[@name="CERT_REVOCATION_CRL_INFO.fDeltaCrlEntry"]/*'/>
    public BOOL fDeltaCrlEntry;
}