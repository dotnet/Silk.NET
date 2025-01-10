// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRL_REVOCATION_INFO
{
    [NativeTypeName("PCRL_ENTRY")]
    public CRL_ENTRY* pCrlEntry;

    [NativeTypeName("PCCRL_CONTEXT")]
    public CRL_CONTEXT* pCrlContext;

    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pCrlIssuerChain;
}
