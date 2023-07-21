// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN"]/*' />
public unsafe partial struct CERT_SIMPLE_CHAIN
{
    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.TrustStatus"]/*' />
    public CERT_TRUST_STATUS TrustStatus;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.cElement"]/*' />
    [NativeTypeName("DWORD")]
    public uint cElement;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.rgpElement"]/*' />
    [NativeTypeName("PCERT_CHAIN_ELEMENT *")]
    public CERT_CHAIN_ELEMENT** rgpElement;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.pTrustListInfo"]/*' />
    [NativeTypeName("PCERT_TRUST_LIST_INFO")]
    public CERT_TRUST_LIST_INFO* pTrustListInfo;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.fHasRevocationFreshnessTime"]/*' />
    public BOOL fHasRevocationFreshnessTime;

    /// <include file='CERT_SIMPLE_CHAIN.xml' path='doc/member[@name="CERT_SIMPLE_CHAIN.dwRevocationFreshnessTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRevocationFreshnessTime;
}
