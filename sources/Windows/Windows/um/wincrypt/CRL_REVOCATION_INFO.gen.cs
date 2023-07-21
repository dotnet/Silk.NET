// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRL_REVOCATION_INFO.xml' path='doc/member[@name="CRL_REVOCATION_INFO"]/*' />
public unsafe partial struct CRL_REVOCATION_INFO
{
    /// <include file='CRL_REVOCATION_INFO.xml' path='doc/member[@name="CRL_REVOCATION_INFO.pCrlEntry"]/*' />
    [NativeTypeName("PCRL_ENTRY")]
    public CRL_ENTRY* pCrlEntry;

    /// <include file='CRL_REVOCATION_INFO.xml' path='doc/member[@name="CRL_REVOCATION_INFO.pCrlContext"]/*' />
    [NativeTypeName("PCCRL_CONTEXT")]
    public CRL_CONTEXT* pCrlContext;

    /// <include file='CRL_REVOCATION_INFO.xml' path='doc/member[@name="CRL_REVOCATION_INFO.pCrlIssuerChain"]/*' />
    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pCrlIssuerChain;
}
