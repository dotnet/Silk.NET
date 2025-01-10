// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PROVIDER_CERT
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pCert;
    public BOOL fCommercial;
    public BOOL fTrustedRoot;
    public BOOL fSelfSigned;
    public BOOL fTestCert;

    [NativeTypeName("DWORD")]
    public uint dwRevokedReason;

    [NativeTypeName("DWORD")]
    public uint dwConfidence;

    [NativeTypeName("DWORD")]
    public uint dwError;
    public CTL_CONTEXT* pTrustListContext;
    public BOOL fTrustListSignerCert;

    [NativeTypeName("PCCTL_CONTEXT")]
    public CTL_CONTEXT* pCtlContext;

    [NativeTypeName("DWORD")]
    public uint dwCtlError;
    public BOOL fIsCyclic;

    [NativeTypeName("PCERT_CHAIN_ELEMENT")]
    public CERT_CHAIN_ELEMENT* pChainElement;
}
