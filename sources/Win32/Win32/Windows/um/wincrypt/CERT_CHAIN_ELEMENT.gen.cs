// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_CHAIN_ELEMENT
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("PCCERT_CONTEXT")]
    public CERT_CONTEXT* pCertContext;
    public CERT_TRUST_STATUS TrustStatus;

    [NativeTypeName("PCERT_REVOCATION_INFO")]
    public CERT_REVOCATION_INFO* pRevocationInfo;

    [NativeTypeName("PCERT_ENHKEY_USAGE")]
    public CTL_USAGE* pIssuanceUsage;

    [NativeTypeName("PCERT_ENHKEY_USAGE")]
    public CTL_USAGE* pApplicationUsage;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszExtendedErrorInfo;
}
