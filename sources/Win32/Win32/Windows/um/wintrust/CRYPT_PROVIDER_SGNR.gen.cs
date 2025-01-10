// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_PROVIDER_SGNR
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    public FILETIME sftVerifyAsOf;

    [NativeTypeName("DWORD")]
    public uint csCertChain;

    [NativeTypeName("struct _CRYPT_PROVIDER_CERT *")]
    public CRYPT_PROVIDER_CERT* pasCertChain;

    [NativeTypeName("DWORD")]
    public uint dwSignerType;
    public CMSG_SIGNER_INFO* psSigner;

    [NativeTypeName("DWORD")]
    public uint dwError;

    [NativeTypeName("DWORD")]
    public uint csCounterSigners;

    [NativeTypeName("struct _CRYPT_PROVIDER_SGNR *")]
    public CRYPT_PROVIDER_SGNR* pasCounterSigners;

    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pChainContext;
}
