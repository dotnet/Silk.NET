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

public static unsafe partial class Windows
{
    [NativeTypeName("#define PVK_TYPE_FILE_NAME 0x01")]
    public const int PvkTypeFileName = 0x01;

    [NativeTypeName("#define PVK_TYPE_KEYCONTAINER 0x02")]
    public const int PvkTypeKeycontainer = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SignerSignEx2"]/*'/>

    [DllImport("mssign32", ExactSpelling = true, EntryPoint = "SignerSignEx2")]
    public static extern HResult SignerSignEx2(
        [NativeTypeName("DWORD")] uint dwFlags,
        SignerSubjectInfo* pSubjectInfo,
        SignerCert* pSignerCert,
        SignerSignatureInfo* pSignatureInfo,
        SignerProviderInfo* pProviderInfo,
        [NativeTypeName("DWORD")] uint dwTimestampFlags,
        [NativeTypeName("PCSTR")] sbyte* pszTimestampAlgorithmOid,
        [NativeTypeName("PCWSTR")] ushort* pwszHttpTimeStamp,
        [NativeTypeName("PCRYPT_ATTRIBUTES")] CryptAttributes* psRequest,
        [NativeTypeName("PVOID")] void* pSipData,
        SignerContext** ppSignerContext,
        [NativeTypeName("PCERT_STRONG_SIGN_PARA")] CertStrongSignPara* pCryptoPolicy,
        [NativeTypeName("PVOID")] void* pReserved
    );

    [Transformed]
    [NativeFunction("mssign32", EntryPoint = "SignerSignEx2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult SignerSignEx2(
        [NativeTypeName("DWORD")] uint dwFlags,
        Ref<SignerSubjectInfo> pSubjectInfo,
        Ref<SignerCert> pSignerCert,
        Ref<SignerSignatureInfo> pSignatureInfo,
        Ref<SignerProviderInfo> pProviderInfo,
        [NativeTypeName("DWORD")] uint dwTimestampFlags,
        [NativeTypeName("PCSTR")] Ref<sbyte> pszTimestampAlgorithmOid,
        [NativeTypeName("PCWSTR")] Ref<ushort> pwszHttpTimeStamp,
        [NativeTypeName("PCRYPT_ATTRIBUTES")] Ref<CryptAttributes> psRequest,
        [NativeTypeName("PVOID")] Ref pSipData,
        Ref2D<SignerContext> ppSignerContext,
        [NativeTypeName("PCERT_STRONG_SIGN_PARA")] Ref<CertStrongSignPara> pCryptoPolicy,
        [NativeTypeName("PVOID")] Ref pReserved
    )
    {
        fixed (void* __dsl_pReserved = pReserved)
        fixed (CertStrongSignPara* __dsl_pCryptoPolicy = pCryptoPolicy)
        fixed (SignerContext** __dsl_ppSignerContext = ppSignerContext)
        fixed (void* __dsl_pSipData = pSipData)
        fixed (CryptAttributes* __dsl_psRequest = psRequest)
        fixed (ushort* __dsl_pwszHttpTimeStamp = pwszHttpTimeStamp)
        fixed (sbyte* __dsl_pszTimestampAlgorithmOid = pszTimestampAlgorithmOid)
        fixed (SignerProviderInfo* __dsl_pProviderInfo = pProviderInfo)
        fixed (SignerSignatureInfo* __dsl_pSignatureInfo = pSignatureInfo)
        fixed (SignerCert* __dsl_pSignerCert = pSignerCert)
        fixed (SignerSubjectInfo* __dsl_pSubjectInfo = pSubjectInfo)
        {
            return (HResult)SignerSignEx2(
                dwFlags,
                __dsl_pSubjectInfo,
                __dsl_pSignerCert,
                __dsl_pSignatureInfo,
                __dsl_pProviderInfo,
                dwTimestampFlags,
                __dsl_pszTimestampAlgorithmOid,
                __dsl_pwszHttpTimeStamp,
                __dsl_psRequest,
                __dsl_pSipData,
                __dsl_ppSignerContext,
                __dsl_pCryptoPolicy,
                __dsl_pReserved
            );
        }
    }
}
