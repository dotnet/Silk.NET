// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo"]/*' />
public unsafe partial struct SecPkgContext_RemoteCredentialInfo
{
    /// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo.cbCertificateChain"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbCertificateChain;

    /// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo.pbCertificateChain"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* pbCertificateChain;

    /// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo.cCertificates"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCertificates;

    /// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo.fFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint fFlags;

    /// <include file='SecPkgContext_RemoteCredentialInfo.xml' path='doc/member[@name="SecPkgContext_RemoteCredentialInfo.dwBits"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBits;
}
