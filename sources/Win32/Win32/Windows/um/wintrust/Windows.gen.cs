// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("wintrust", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int WinVerifyTrust(
        HWND hwnd,
        Guid* pgActionID,
        [NativeTypeName("LPVOID")] void* pWVTData
    );

    [DllImport("wintrust", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int WinVerifyTrustEx(
        HWND hwnd,
        Guid* pgActionID,
        WINTRUST_DATA* pWinTrustData
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern void WintrustGetRegPolicyFlags(
        [NativeTypeName("DWORD *")] uint* pdwPolicyFlags
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustSetRegPolicyFlags(
        [NativeTypeName("DWORD")] uint dwPolicyFlags
    );

    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustAddActionID(
        Guid* pgActionID,
        [NativeTypeName("DWORD")] uint fdwFlags,
        CRYPT_REGISTER_ACTIONID* psProvInfo
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustRemoveActionID(Guid* pgActionID);

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustLoadFunctionPointers(
        Guid* pgActionID,
        CRYPT_PROVIDER_FUNCTIONS* pPfns
    );

    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustAddDefaultForUsage(
        [NativeTypeName("const char *")] sbyte* pszUsageOID,
        CRYPT_PROVIDER_REGDEFUSAGE* psDefUsage
    );

    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustGetDefaultForUsage(
        [NativeTypeName("DWORD")] uint dwAction,
        [NativeTypeName("const char *")] sbyte* pszUsageOID,
        CRYPT_PROVIDER_DEFUSAGE* psUsage
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_SGNR* WTHelperGetProvSignerFromChain(
        CRYPT_PROVIDER_DATA* pProvData,
        [NativeTypeName("DWORD")] uint idxSigner,
        BOOL fCounterSigner,
        [NativeTypeName("DWORD")] uint idxCounterSigner
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_CERT* WTHelperGetProvCertFromChain(
        CRYPT_PROVIDER_SGNR* pSgnr,
        [NativeTypeName("DWORD")] uint idxCert
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_DATA* WTHelperProvDataFromStateData(HANDLE hStateData);

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_PRIVDATA* WTHelperGetProvPrivateDataFromChain(
        CRYPT_PROVIDER_DATA* pProvData,
        Guid* pgProviderID
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WTHelperCertIsSelfSigned(
        [NativeTypeName("DWORD")] uint dwEncoding,
        CERT_INFO* pCert
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern HRESULT WTHelperCertCheckValidSignature(CRYPT_PROVIDER_DATA* pProvData);

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL OpenPersonalTrustDBDialogEx(
        HWND hwndParent,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("PVOID *")] void** pvReserved
    );

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL OpenPersonalTrustDBDialog(HWND hwndParent);

    [DllImport("wintrust", ExactSpelling = true)]
    public static extern void WintrustSetDefaultIncludePEPageHashes(BOOL fIncludePEPageHashes);

    [NativeTypeName("#define WTCI_DONT_OPEN_STORES 0x00000001")]
    public const int WTCI_DONT_OPEN_STORES = 0x00000001;

    [NativeTypeName("#define WTCI_OPEN_ONLY_ROOT 0x00000002")]
    public const int WTCI_OPEN_ONLY_ROOT = 0x00000002;

    [NativeTypeName("#define WTCI_USE_LOCAL_MACHINE 0x00000004")]
    public const int WTCI_USE_LOCAL_MACHINE = 0x00000004;

    [NativeTypeName("#define SGNR_TYPE_TIMESTAMP 0x00000010")]
    public const int SGNR_TYPE_TIMESTAMP = 0x00000010;

    [NativeTypeName("#define DWACTION_ALLOCANDFILL 1")]
    public const int DWACTION_ALLOCANDFILL = 1;

    [NativeTypeName("#define DWACTION_FREE 2")]
    public const int DWACTION_FREE = 2;

    [NativeTypeName("#define INTENT_TO_SEAL_ATTRIBUTE_STRUCT ((LPCSTR) 2010)")]
    public static sbyte* INTENT_TO_SEAL_ATTRIBUTE_STRUCT => ((sbyte*)(2010));

    [NativeTypeName("#define SEALING_SIGNATURE_ATTRIBUTE_STRUCT ((LPCSTR) 2011)")]
    public static sbyte* SEALING_SIGNATURE_ATTRIBUTE_STRUCT => ((sbyte*)(2011));

    [NativeTypeName("#define SEALING_TIMESTAMP_ATTRIBUTE_STRUCT ((LPCSTR) 2012)")]
    public static sbyte* SEALING_TIMESTAMP_ATTRIBUTE_STRUCT => ((sbyte*)(2012));
}
