// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SecPkgContext_Certificates.xml' path='doc/member[@name="SecPkgContext_Certificates"]/*'/>
public unsafe partial struct SecPkgContext_Certificates
{
    /// <include file='SecPkgContext_Certificates.xml' path='doc/member[@name="SecPkgContext_Certificates.cCertificates"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCertificates;
    /// <include file='SecPkgContext_Certificates.xml' path='doc/member[@name="SecPkgContext_Certificates.cbCertificateChain"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCertificateChain;
    /// <include file='SecPkgContext_Certificates.xml' path='doc/member[@name="SecPkgContext_Certificates.pbCertificateChain"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pbCertificateChain;
}