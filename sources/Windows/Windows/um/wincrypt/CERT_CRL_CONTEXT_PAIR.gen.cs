// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_CRL_CONTEXT_PAIR.xml' path='doc/member[@name="CERT_CRL_CONTEXT_PAIR"]/*'/>
public unsafe partial struct CERT_CRL_CONTEXT_PAIR
{
    /// <include file='CERT_CRL_CONTEXT_PAIR.xml' path='doc/member[@name="CERT_CRL_CONTEXT_PAIR.pCertContext"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pCertContext;
    /// <include file='CERT_CRL_CONTEXT_PAIR.xml' path='doc/member[@name="CERT_CRL_CONTEXT_PAIR.pCrlContext"]/*'/>
    [NativeTypeName("PCCRL_CONTEXT")]
    public CRL_CONTEXT* pCrlContext;
}