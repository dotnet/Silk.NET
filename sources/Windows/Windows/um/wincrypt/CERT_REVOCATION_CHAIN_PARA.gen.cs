// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA"]/*' />
public unsafe partial struct CERT_REVOCATION_CHAIN_PARA
{
    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.hChainEngine"]/*' />
    public HCERTCHAINENGINE hChainEngine;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.hAdditionalStore"]/*' />
    public HCERTSTORE hAdditionalStore;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.dwChainFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwChainFlags;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.dwUrlRetrievalTimeout"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUrlRetrievalTimeout;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.pftCurrentTime"]/*' />
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftCurrentTime;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.pftCacheResync"]/*' />
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftCacheResync;

    /// <include file='CERT_REVOCATION_CHAIN_PARA.xml' path='doc/member[@name="CERT_REVOCATION_CHAIN_PARA.cbMaxUrlRetrievalByteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbMaxUrlRetrievalByteCount;
}
