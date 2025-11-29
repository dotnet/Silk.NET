// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

/// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS"]/*'/>
public unsafe partial struct SignerSignEx2Params
{
    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.dwFlags"]/*'/>

    [NativeTypeName("DWORD")]
    public uint DwFlags;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSubjectInfo"]/*'/>

    [NativeTypeName("PSIGNER_SUBJECT_INFO")]
    public SignerSubjectInfo* PSubjectInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSigningCert"]/*'/>

    [NativeTypeName("PSIGNER_CERT")]
    public SignerCert* PSigningCert;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSignatureInfo"]/*'/>

    [NativeTypeName("PSIGNER_SIGNATURE_INFO")]
    public SignerSignatureInfo* PSignatureInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pProviderInfo"]/*'/>

    [NativeTypeName("PSIGNER_PROVIDER_INFO")]
    public SignerProviderInfo* PProviderInfo;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.dwTimestampFlags"]/*'/>

    [NativeTypeName("DWORD")]
    public uint DwTimestampFlags;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pszAlgorithmOid"]/*'/>

    [NativeTypeName("PCSTR")]
    public sbyte* PszAlgorithmOid;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pwszTimestampURL"]/*'/>

    [NativeTypeName("PCWSTR")]
    public ushort* PwszTimestampURL;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pCryptAttrs"]/*'/>

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CryptAttributes* PCryptAttrs;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSipData"]/*'/>

    [NativeTypeName("PVOID")]
    public void* PSipData;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pSignerContext"]/*'/>

    [NativeTypeName("PSIGNER_CONTEXT *")]
    public SignerContext** PSignerContext;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pCryptoPolicy"]/*'/>

    [NativeTypeName("PVOID")]
    public void* PCryptoPolicy;

    /// <include file='SIGNER_SIGN_EX2_PARAMS.xml' path='doc/member[@name="SIGNER_SIGN_EX2_PARAMS.pReserved"]/*'/>

    [NativeTypeName("PVOID")]
    public void* PReserved;
}
