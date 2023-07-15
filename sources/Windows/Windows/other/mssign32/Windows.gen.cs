// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SignerSignEx2"]/*'/>
    [DllImport("mssign32", ExactSpelling = true)]
    public static extern HRESULT SignerSignEx2([NativeTypeName("DWORD")] uint dwFlags, SIGNER_SUBJECT_INFO* pSubjectInfo, SIGNER_CERT* pSignerCert, SIGNER_SIGNATURE_INFO* pSignatureInfo, SIGNER_PROVIDER_INFO* pProviderInfo, [NativeTypeName("DWORD")] uint dwTimestampFlags, [NativeTypeName("PCSTR")] sbyte* pszTimestampAlgorithmOid, [NativeTypeName("PCWSTR")] ushort* pwszHttpTimeStamp, [NativeTypeName("PCRYPT_ATTRIBUTES")] CRYPT_ATTRIBUTES* psRequest, [NativeTypeName("PVOID")] void* pSipData, SIGNER_CONTEXT** ppSignerContext, [NativeTypeName("PCERT_STRONG_SIGN_PARA")] CERT_STRONG_SIGN_PARA* pCryptoPolicy, [NativeTypeName("PVOID")] void* pReserved);
    [NativeTypeName("#define PVK_TYPE_FILE_NAME 0x01")]
    public const int PVK_TYPE_FILE_NAME = 0x01;
    [NativeTypeName("#define PVK_TYPE_KEYCONTAINER 0x02")]
    public const int PVK_TYPE_KEYCONTAINER = 0x02;
}