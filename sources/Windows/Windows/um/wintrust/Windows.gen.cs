// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinVerifyTrust"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int WinVerifyTrust(HWND hwnd, Guid* pgActionID, [NativeTypeName("LPVOID")] void* pWVTData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinVerifyTrustEx"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    [return: NativeTypeName("long")]
    public static extern int WinVerifyTrustEx(HWND hwnd, Guid* pgActionID, WINTRUST_DATA* pWinTrustData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustGetRegPolicyFlags"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern void WintrustGetRegPolicyFlags([NativeTypeName("DWORD *")] uint* pdwPolicyFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustSetRegPolicyFlags"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustSetRegPolicyFlags([NativeTypeName("DWORD")] uint dwPolicyFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustAddActionID"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustAddActionID(Guid* pgActionID, [NativeTypeName("DWORD")] uint fdwFlags, CRYPT_REGISTER_ACTIONID* psProvInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustRemoveActionID"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustRemoveActionID(Guid* pgActionID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustLoadFunctionPointers"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WintrustLoadFunctionPointers(Guid* pgActionID, CRYPT_PROVIDER_FUNCTIONS* pPfns);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustAddDefaultForUsage"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustAddDefaultForUsage([NativeTypeName("const char *")] sbyte* pszUsageOID, CRYPT_PROVIDER_REGDEFUSAGE* psDefUsage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustGetDefaultForUsage"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL WintrustGetDefaultForUsage([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("const char *")] sbyte* pszUsageOID, CRYPT_PROVIDER_DEFUSAGE* psUsage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperGetProvSignerFromChain"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_SGNR* WTHelperGetProvSignerFromChain(CRYPT_PROVIDER_DATA* pProvData, [NativeTypeName("DWORD")] uint idxSigner, BOOL fCounterSigner, [NativeTypeName("DWORD")] uint idxCounterSigner);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperGetProvCertFromChain"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_CERT* WTHelperGetProvCertFromChain(CRYPT_PROVIDER_SGNR* pSgnr, [NativeTypeName("DWORD")] uint idxCert);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperProvDataFromStateData"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_DATA* WTHelperProvDataFromStateData(HANDLE hStateData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperGetProvPrivateDataFromChain"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern CRYPT_PROVIDER_PRIVDATA* WTHelperGetProvPrivateDataFromChain(CRYPT_PROVIDER_DATA* pProvData, Guid* pgProviderID);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperCertIsSelfSigned"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL WTHelperCertIsSelfSigned([NativeTypeName("DWORD")] uint dwEncoding, CERT_INFO* pCert);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WTHelperCertCheckValidSignature"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern HRESULT WTHelperCertCheckValidSignature(CRYPT_PROVIDER_DATA* pProvData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenPersonalTrustDBDialogEx"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL OpenPersonalTrustDBDialogEx(HWND hwndParent, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID *")] void** pvReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.OpenPersonalTrustDBDialog"]/*'/>
    [DllImport("wintrust", ExactSpelling = true)]
    public static extern BOOL OpenPersonalTrustDBDialog(HWND hwndParent);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WintrustSetDefaultIncludePEPageHashes"]/*'/>
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