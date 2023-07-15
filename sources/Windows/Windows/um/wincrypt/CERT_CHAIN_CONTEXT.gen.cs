// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT"]/*'/>
public unsafe partial struct CERT_CHAIN_CONTEXT
{
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.TrustStatus"]/*'/>
    public CERT_TRUST_STATUS TrustStatus;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.cChain"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cChain;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.rgpChain"]/*'/>
    [NativeTypeName("PCERT_SIMPLE_CHAIN *")]
    public CERT_SIMPLE_CHAIN** rgpChain;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.cLowerQualityChainContext"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cLowerQualityChainContext;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.rgpLowerQualityChainContext"]/*'/>
    [NativeTypeName("PCCERT_CHAIN_CONTEXT *")]
    public CERT_CHAIN_CONTEXT** rgpLowerQualityChainContext;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.fHasRevocationFreshnessTime"]/*'/>
    public BOOL fHasRevocationFreshnessTime;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.dwRevocationFreshnessTime"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevocationFreshnessTime;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.dwCreateFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCreateFlags;
    /// <include file='CERT_CHAIN_CONTEXT.xml' path='doc/member[@name="CERT_CHAIN_CONTEXT.ChainId"]/*'/>
    public Guid ChainId;
}