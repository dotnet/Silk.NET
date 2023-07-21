// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo"]/*' />
public unsafe partial struct SecPkgContext_CertInfo
{
    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.cbSubjectName"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSubjectName;

    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.pwszSubjectName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszSubjectName;

    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.cbIssuerName"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbIssuerName;

    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.pwszIssuerName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszIssuerName;

    /// <include file='SecPkgContext_CertInfo.xml' path='doc/member[@name="SecPkgContext_CertInfo.dwKeySize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwKeySize;
}
