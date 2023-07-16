// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SecPkgContext_CertificateValidationResult.xml' path='doc/member[@name="SecPkgContext_CertificateValidationResult"]/*'/>
public partial struct SecPkgContext_CertificateValidationResult
{
    /// <include file='SecPkgContext_CertificateValidationResult.xml' path='doc/member[@name="SecPkgContext_CertificateValidationResult.dwChainErrorStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwChainErrorStatus;
    /// <include file='SecPkgContext_CertificateValidationResult.xml' path='doc/member[@name="SecPkgContext_CertificateValidationResult.hrVerifyChainStatus"]/*'/>
    public HRESULT hrVerifyChainStatus;
}