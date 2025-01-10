// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_CHAIN_CONTEXT
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public CERT_TRUST_STATUS TrustStatus;

    [NativeTypeName("DWORD")]
    public uint cChain;

    [NativeTypeName("PCERT_SIMPLE_CHAIN *")]
    public CERT_SIMPLE_CHAIN** rgpChain;

    [NativeTypeName("DWORD")]
    public uint cLowerQualityChainContext;

    [NativeTypeName("PCCERT_CHAIN_CONTEXT *")]
    public CERT_CHAIN_CONTEXT** rgpLowerQualityChainContext;
    public BOOL fHasRevocationFreshnessTime;

    [NativeTypeName("DWORD")]
    public uint dwRevocationFreshnessTime;

    [NativeTypeName("DWORD")]
    public uint dwCreateFlags;
    public Guid ChainId;
}
