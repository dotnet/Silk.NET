// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG"]/*' />
public unsafe partial struct CERT_CHAIN_ENGINE_CONFIG
{
    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.hRestrictedRoot"]/*' />
    public HCERTSTORE hRestrictedRoot;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.hRestrictedTrust"]/*' />
    public HCERTSTORE hRestrictedTrust;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.hRestrictedOther"]/*' />
    public HCERTSTORE hRestrictedOther;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.cAdditionalStore"]/*' />
    [NativeTypeName("DWORD")]
    public uint cAdditionalStore;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.rghAdditionalStore"]/*' />
    public HCERTSTORE* rghAdditionalStore;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.dwUrlRetrievalTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUrlRetrievalTimeout;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.MaximumCachedCertificates"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaximumCachedCertificates;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.CycleDetectionModulus"]/*' />
    [NativeTypeName("DWORD")]
    public uint CycleDetectionModulus;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.hExclusiveRoot"]/*' />
    public HCERTSTORE hExclusiveRoot;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.hExclusiveTrustedPeople"]/*' />
    public HCERTSTORE hExclusiveTrustedPeople;

    /// <include file='CERT_CHAIN_ENGINE_CONFIG.xml' path='doc/member[@name="CERT_CHAIN_ENGINE_CONFIG.dwExclusiveFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwExclusiveFlags;
}
