// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SIGNER_SIGN_EX2_PARAMS
{
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("PSIGNER_SUBJECT_INFO")]
    public SIGNER_SUBJECT_INFO* pSubjectInfo;

    [NativeTypeName("PSIGNER_CERT")]
    public SIGNER_CERT* pSigningCert;

    [NativeTypeName("PSIGNER_SIGNATURE_INFO")]
    public SIGNER_SIGNATURE_INFO* pSignatureInfo;

    [NativeTypeName("PSIGNER_PROVIDER_INFO")]
    public SIGNER_PROVIDER_INFO* pProviderInfo;

    [NativeTypeName("DWORD")]
    public uint dwTimestampFlags;

    [NativeTypeName("PCSTR")]
    public sbyte* pszAlgorithmOid;

    [NativeTypeName("PCWSTR")]
    public ushort* pwszTimestampURL;

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* pCryptAttrs;

    [NativeTypeName("PVOID")]
    public void* pSipData;

    [NativeTypeName("PSIGNER_CONTEXT *")]
    public SIGNER_CONTEXT** pSignerContext;

    [NativeTypeName("PVOID")]
    public void* pCryptoPolicy;

    [NativeTypeName("PVOID")]
    public void* pReserved;
}
