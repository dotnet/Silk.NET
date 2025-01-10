// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCloseKey(HKEY hKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOverridePredefKey(HKEY hKey, HKEY hNewHKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenUserClassesRoot(
        HANDLE hToken,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenCurrentUser(
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDisablePredefinedCache();

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDisablePredefinedCacheEx();

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryA(
        [NativeTypeName("LPCSTR")] sbyte* lpMachineName,
        HKEY hKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryW(
        [NativeTypeName("LPCWSTR")] ushort* lpMachineName,
        HKEY hKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryExA(
        [NativeTypeName("LPCSTR")] sbyte* lpMachineName,
        HKEY hKey,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryExW(
        [NativeTypeName("LPCWSTR")] ushort* lpMachineName,
        HKEY hKey,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("LPSTR")] sbyte* lpClass,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("LPDWORD")] uint* lpdwDisposition
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("LPWSTR")] ushort* lpClass,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("LPDWORD")] uint* lpdwDisposition
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyTransactedA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("LPSTR")] sbyte* lpClass,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("LPDWORD")] uint* lpdwDisposition,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParemeter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyTransactedW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("LPWSTR")] ushort* lpClass,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("LPDWORD")] uint* lpdwDisposition,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParemeter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint Reserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint Reserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyTransactedA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint Reserved,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParameter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyTransactedW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint Reserved,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParameter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegDisableReflectionKey(HKEY hBase);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegEnableReflectionKey(HKEY hBase);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegQueryReflectionKey(HKEY hBase, BOOL* bIsReflectionDisabled);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteValueA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValueName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteValueW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValueName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyA(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* lpName,
        [NativeTypeName("DWORD")] uint cchName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyW(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* lpName,
        [NativeTypeName("DWORD")] uint cchName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyExA(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* lpName,
        [NativeTypeName("LPDWORD")] uint* lpcchName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPSTR")] sbyte* lpClass,
        [NativeTypeName("LPDWORD")] uint* lpcchClass,
        [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyExW(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* lpName,
        [NativeTypeName("LPDWORD")] uint* lpcchName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPWSTR")] ushort* lpClass,
        [NativeTypeName("LPDWORD")] uint* lpcchClass,
        [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumValueA(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPSTR")] sbyte* lpValueName,
        [NativeTypeName("LPDWORD")] uint* lpcchValueName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpType,
        [NativeTypeName("LPBYTE")] byte* lpData,
        [NativeTypeName("LPDWORD")] uint* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumValueW(
        HKEY hKey,
        [NativeTypeName("DWORD")] uint dwIndex,
        [NativeTypeName("LPWSTR")] ushort* lpValueName,
        [NativeTypeName("LPDWORD")] uint* lpcchValueName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpType,
        [NativeTypeName("LPBYTE")] byte* lpData,
        [NativeTypeName("LPDWORD")] uint* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegFlushKey(HKEY hKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetKeySecurity(
        HKEY hKey,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPCSTR")] sbyte* lpFile
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPCWSTR")] ushort* lpFile
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegNotifyChangeKeyValue(
        HKEY hKey,
        BOOL bWatchSubtree,
        [NativeTypeName("DWORD")] uint dwNotifyFilter,
        HANDLE hEvent,
        BOOL fAsynchronous
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("DWORD")] uint ulOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("DWORD")] uint ulOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyTransactedA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("DWORD")] uint ulOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParemeter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyTransactedW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("DWORD")] uint ulOptions,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        HANDLE hTransaction,
        [NativeTypeName("PVOID")] void* pExtendedParemeter
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryInfoKeyA(
        HKEY hKey,
        [NativeTypeName("LPSTR")] sbyte* lpClass,
        [NativeTypeName("LPDWORD")] uint* lpcchClass,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpcSubKeys,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen,
        [NativeTypeName("LPDWORD")] uint* lpcValues,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen,
        [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor,
        [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryInfoKeyW(
        HKEY hKey,
        [NativeTypeName("LPWSTR")] ushort* lpClass,
        [NativeTypeName("LPDWORD")] uint* lpcchClass,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpcSubKeys,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen,
        [NativeTypeName("LPDWORD")] uint* lpcValues,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen,
        [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen,
        [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor,
        [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPSTR")] sbyte* lpData,
        [NativeTypeName("PLONG")] int* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPWSTR")] ushort* lpData,
        [NativeTypeName("PLONG")] int* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryMultipleValuesA(
        HKEY hKey,
        [NativeTypeName("PVALENTA")] VALENTA* val_list,
        [NativeTypeName("DWORD")] uint num_vals,
        [NativeTypeName("LPSTR")] sbyte* lpValueBuf,
        [NativeTypeName("LPDWORD")] uint* ldwTotsize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryMultipleValuesW(
        HKEY hKey,
        [NativeTypeName("PVALENTW")] VALENTW* val_list,
        [NativeTypeName("DWORD")] uint num_vals,
        [NativeTypeName("LPWSTR")] ushort* lpValueBuf,
        [NativeTypeName("LPDWORD")] uint* ldwTotsize
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValueName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpType,
        [NativeTypeName("LPBYTE")] byte* lpData,
        [NativeTypeName("LPDWORD")] uint* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValueName,
        [NativeTypeName("LPDWORD")] uint* lpReserved,
        [NativeTypeName("LPDWORD")] uint* lpType,
        [NativeTypeName("LPBYTE")] byte* lpData,
        [NativeTypeName("LPDWORD")] uint* lpcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegReplaceKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPCSTR")] sbyte* lpNewFile,
        [NativeTypeName("LPCSTR")] sbyte* lpOldFile
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegReplaceKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPCWSTR")] ushort* lpNewFile,
        [NativeTypeName("LPCWSTR")] ushort* lpOldFile
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRestoreKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRestoreKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRenameKey(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKeyName,
        [NativeTypeName("LPCWSTR")] ushort* lpNewKeyName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeySecurity(
        HKEY hKey,
        [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCSTR")] sbyte* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCWSTR")] ushort* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValueName,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const BYTE *")] byte* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValueName,
        [NativeTypeName("DWORD")] uint Reserved,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("const BYTE *")] byte* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegUnLoadKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegUnLoadKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyValueA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValueName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyValueW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValueName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeyValueA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValueName,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeyValueW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValueName,
        [NativeTypeName("DWORD")] uint dwType,
        [NativeTypeName("LPCVOID")] void* lpData,
        [NativeTypeName("DWORD")] uint cbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteTreeA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteTreeW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCopyTreeA(
        HKEY hKeySrc,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        HKEY hKeyDest
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetValueA(
        HKEY hkey,
        [NativeTypeName("LPCSTR")] sbyte* lpSubKey,
        [NativeTypeName("LPCSTR")] sbyte* lpValue,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetValueW(
        HKEY hkey,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        [NativeTypeName("LPCWSTR")] ushort* lpValue,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPDWORD")] uint* pdwType,
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPDWORD")] uint* pcbData
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCopyTreeW(
        HKEY hKeySrc,
        [NativeTypeName("LPCWSTR")] ushort* lpSubKey,
        HKEY hKeyDest
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadMUIStringA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* pszValue,
        [NativeTypeName("LPSTR")] sbyte* pszOutBuf,
        [NativeTypeName("DWORD")] uint cbOutBuf,
        [NativeTypeName("LPDWORD")] uint* pcbData,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("LPCSTR")] sbyte* pszDirectory
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadMUIStringW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* pszValue,
        [NativeTypeName("LPWSTR")] ushort* pszOutBuf,
        [NativeTypeName("DWORD")] uint cbOutBuf,
        [NativeTypeName("LPDWORD")] uint* pcbData,
        [NativeTypeName("DWORD")] uint Flags,
        [NativeTypeName("LPCWSTR")] ushort* pszDirectory
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadAppKeyA(
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("DWORD")] uint Reserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadAppKeyW(
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("PHKEY")] HKEY* phkResult,
        [NativeTypeName("REGSAM")] uint samDesired,
        [NativeTypeName("DWORD")] uint dwOptions,
        [NativeTypeName("DWORD")] uint Reserved
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownA(
        [NativeTypeName("LPSTR")] sbyte* lpMachineName,
        [NativeTypeName("LPSTR")] sbyte* lpMessage,
        [NativeTypeName("DWORD")] uint dwTimeout,
        BOOL bForceAppsClosed,
        BOOL bRebootAfterShutdown
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownW(
        [NativeTypeName("LPWSTR")] ushort* lpMachineName,
        [NativeTypeName("LPWSTR")] ushort* lpMessage,
        [NativeTypeName("DWORD")] uint dwTimeout,
        BOOL bForceAppsClosed,
        BOOL bRebootAfterShutdown
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AbortSystemShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName);

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AbortSystemShutdownW(
        [NativeTypeName("LPWSTR")] ushort* lpMachineName
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownExA(
        [NativeTypeName("LPSTR")] sbyte* lpMachineName,
        [NativeTypeName("LPSTR")] sbyte* lpMessage,
        [NativeTypeName("DWORD")] uint dwTimeout,
        BOOL bForceAppsClosed,
        BOOL bRebootAfterShutdown,
        [NativeTypeName("DWORD")] uint dwReason
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownExW(
        [NativeTypeName("LPWSTR")] ushort* lpMachineName,
        [NativeTypeName("LPWSTR")] ushort* lpMessage,
        [NativeTypeName("DWORD")] uint dwTimeout,
        BOOL bForceAppsClosed,
        BOOL bRebootAfterShutdown,
        [NativeTypeName("DWORD")] uint dwReason
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InitiateShutdownA(
        [NativeTypeName("LPSTR")] sbyte* lpMachineName,
        [NativeTypeName("LPSTR")] sbyte* lpMessage,
        [NativeTypeName("DWORD")] uint dwGracePeriod,
        [NativeTypeName("DWORD")] uint dwShutdownFlags,
        [NativeTypeName("DWORD")] uint dwReason
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InitiateShutdownW(
        [NativeTypeName("LPWSTR")] ushort* lpMachineName,
        [NativeTypeName("LPWSTR")] ushort* lpMessage,
        [NativeTypeName("DWORD")] uint dwGracePeriod,
        [NativeTypeName("DWORD")] uint dwShutdownFlags,
        [NativeTypeName("DWORD")] uint dwReason
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CheckForHiberboot(
        [NativeTypeName("PBOOLEAN")] byte* pHiberboot,
        [NativeTypeName("BOOLEAN")] byte bClearFlag
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyExA(
        HKEY hKey,
        [NativeTypeName("LPCSTR")] sbyte* lpFile,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint Flags
    );

    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyExW(
        HKEY hKey,
        [NativeTypeName("LPCWSTR")] ushort* lpFile,
        [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes,
        [NativeTypeName("DWORD")] uint Flags
    );

    [NativeTypeName("#define PROVIDER_KEEPS_VALUE_LENGTH 0x1")]
    public const int PROVIDER_KEEPS_VALUE_LENGTH = 0x1;

    [NativeTypeName("#define WIN31_CLASS NULL")]
    public const int WIN31_CLASS = 0;

    [NativeTypeName("#define RegConnectRegistry RegConnectRegistryW")]
    public static delegate* <ushort*, HKEY, HKEY*, int> RegConnectRegistry => &RegConnectRegistryW;

    [NativeTypeName("#define RegConnectRegistryEx RegConnectRegistryExW")]
    public static delegate* <ushort*, HKEY, uint, HKEY*, int> RegConnectRegistryEx =>
        &RegConnectRegistryExW;

    [NativeTypeName("#define RegCreateKey RegCreateKeyW")]
    public static delegate* <HKEY, ushort*, HKEY*, int> RegCreateKey => &RegCreateKeyW;

    [NativeTypeName("#define RegCreateKeyEx RegCreateKeyExW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint,
        ushort*,
        uint,
        uint,
        SECURITY_ATTRIBUTES*,
        HKEY*,
        uint*,
        int> RegCreateKeyEx => &RegCreateKeyExW;

    [NativeTypeName("#define RegCreateKeyTransacted RegCreateKeyTransactedW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint,
        ushort*,
        uint,
        uint,
        SECURITY_ATTRIBUTES*,
        HKEY*,
        uint*,
        HANDLE,
        void*,
        int> RegCreateKeyTransacted => &RegCreateKeyTransactedW;

    [NativeTypeName("#define RegDeleteKey RegDeleteKeyW")]
    public static delegate* <HKEY, ushort*, int> RegDeleteKey => &RegDeleteKeyW;

    [NativeTypeName("#define RegDeleteKeyEx RegDeleteKeyExW")]
    public static delegate* <HKEY, ushort*, uint, uint, int> RegDeleteKeyEx => &RegDeleteKeyExW;

    [NativeTypeName("#define RegDeleteKeyTransacted RegDeleteKeyTransactedW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint,
        uint,
        HANDLE,
        void*,
        int> RegDeleteKeyTransacted => &RegDeleteKeyTransactedW;

    [NativeTypeName("#define RegDeleteValue RegDeleteValueW")]
    public static delegate* <HKEY, ushort*, int> RegDeleteValue => &RegDeleteValueW;

    [NativeTypeName("#define RegEnumKey RegEnumKeyW")]
    public static delegate* <HKEY, uint, ushort*, uint, int> RegEnumKey => &RegEnumKeyW;

    [NativeTypeName("#define RegEnumKeyEx RegEnumKeyExW")]
    public static delegate* <
        HKEY,
        uint,
        ushort*,
        uint*,
        uint*,
        ushort*,
        uint*,
        FILETIME*,
        int> RegEnumKeyEx => &RegEnumKeyExW;

    [NativeTypeName("#define RegEnumValue RegEnumValueW")]
    public static delegate* <
        HKEY,
        uint,
        ushort*,
        uint*,
        uint*,
        uint*,
        byte*,
        uint*,
        int> RegEnumValue => &RegEnumValueW;

    [NativeTypeName("#define RegLoadKey RegLoadKeyW")]
    public static delegate* <HKEY, ushort*, ushort*, int> RegLoadKey => &RegLoadKeyW;

    [NativeTypeName("#define RegOpenKey RegOpenKeyW")]
    public static delegate* <HKEY, ushort*, HKEY*, int> RegOpenKey => &RegOpenKeyW;

    [NativeTypeName("#define RegOpenKeyEx RegOpenKeyExW")]
    public static delegate* <HKEY, ushort*, uint, uint, HKEY*, int> RegOpenKeyEx => &RegOpenKeyExW;

    [NativeTypeName("#define RegOpenKeyTransacted RegOpenKeyTransactedW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint,
        uint,
        HKEY*,
        HANDLE,
        void*,
        int> RegOpenKeyTransacted => &RegOpenKeyTransactedW;

    [NativeTypeName("#define RegQueryInfoKey RegQueryInfoKeyW")]
    public static delegate* <
        HKEY,
        ushort*,
        uint*,
        uint*,
        uint*,
        uint*,
        uint*,
        uint*,
        uint*,
        uint*,
        uint*,
        FILETIME*,
        int> RegQueryInfoKey => &RegQueryInfoKeyW;

    [NativeTypeName("#define RegQueryValue RegQueryValueW")]
    public static delegate* <HKEY, ushort*, ushort*, int*, int> RegQueryValue => &RegQueryValueW;

    [NativeTypeName("#define RegQueryMultipleValues RegQueryMultipleValuesW")]
    public static delegate* <HKEY, VALENTW*, uint, ushort*, uint*, int> RegQueryMultipleValues =>
        &RegQueryMultipleValuesW;

    [NativeTypeName("#define RegQueryValueEx RegQueryValueExW")]
    public static delegate* <HKEY, ushort*, uint*, uint*, byte*, uint*, int> RegQueryValueEx =>
        &RegQueryValueExW;

    [NativeTypeName("#define RegReplaceKey RegReplaceKeyW")]
    public static delegate* <HKEY, ushort*, ushort*, ushort*, int> RegReplaceKey => &RegReplaceKeyW;

    [NativeTypeName("#define RegRestoreKey RegRestoreKeyW")]
    public static delegate* <HKEY, ushort*, uint, int> RegRestoreKey => &RegRestoreKeyW;

    [NativeTypeName("#define RegSaveKey RegSaveKeyW")]
    public static delegate* <HKEY, ushort*, SECURITY_ATTRIBUTES*, int> RegSaveKey => &RegSaveKeyW;

    [NativeTypeName("#define RegSetValue RegSetValueW")]
    public static delegate* <HKEY, ushort*, uint, ushort*, uint, int> RegSetValue => &RegSetValueW;

    [NativeTypeName("#define RegSetValueEx RegSetValueExW")]
    public static delegate* <HKEY, ushort*, uint, uint, byte*, uint, int> RegSetValueEx =>
        &RegSetValueExW;

    [NativeTypeName("#define RegUnLoadKey RegUnLoadKeyW")]
    public static delegate* <HKEY, ushort*, int> RegUnLoadKey => &RegUnLoadKeyW;

    [NativeTypeName("#define RegDeleteKeyValue RegDeleteKeyValueW")]
    public static delegate* <HKEY, ushort*, ushort*, int> RegDeleteKeyValue => &RegDeleteKeyValueW;

    [NativeTypeName("#define RegSetKeyValue RegSetKeyValueW")]
    public static delegate* <HKEY, ushort*, ushort*, uint, void*, uint, int> RegSetKeyValue =>
        &RegSetKeyValueW;

    [NativeTypeName("#define RegDeleteTree RegDeleteTreeW")]
    public static delegate* <HKEY, ushort*, int> RegDeleteTree => &RegDeleteTreeW;

    [NativeTypeName("#define RegGetValue RegGetValueW")]
    public static delegate* <HKEY, ushort*, ushort*, uint, uint*, void*, uint*, int> RegGetValue =>
        &RegGetValueW;

    [NativeTypeName("#define RegCopyTree RegCopyTreeW")]
    public static delegate* <HKEY, ushort*, HKEY, int> RegCopyTree => &RegCopyTreeW;

    [NativeTypeName("#define RegLoadMUIString RegLoadMUIStringW")]
    public static delegate* <
        HKEY,
        ushort*,
        ushort*,
        uint,
        uint*,
        uint,
        ushort*,
        int> RegLoadMUIString => &RegLoadMUIStringW;

    [NativeTypeName("#define RegLoadAppKey RegLoadAppKeyW")]
    public static delegate* <ushort*, HKEY*, uint, uint, uint, int> RegLoadAppKey =>
        &RegLoadAppKeyW;

    [NativeTypeName("#define InitiateSystemShutdown InitiateSystemShutdownW")]
    public static delegate* <ushort*, ushort*, uint, BOOL, BOOL, BOOL> InitiateSystemShutdown =>
        &InitiateSystemShutdownW;

    [NativeTypeName("#define AbortSystemShutdown AbortSystemShutdownW")]
    public static delegate* <ushort*, BOOL> AbortSystemShutdown => &AbortSystemShutdownW;

    [NativeTypeName(
        "#define REASON_SWINSTALL (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_INSTALLATION)"
    )]
    public const int REASON_SWINSTALL = (0x00030000 | 0x00000002);

    [NativeTypeName(
        "#define REASON_HWINSTALL (SHTDN_REASON_MAJOR_HARDWARE|SHTDN_REASON_MINOR_INSTALLATION)"
    )]
    public const int REASON_HWINSTALL = (0x00010000 | 0x00000002);

    [NativeTypeName(
        "#define REASON_SERVICEHANG (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_HUNG)"
    )]
    public const int REASON_SERVICEHANG = (0x00030000 | 0x00000005);

    [NativeTypeName(
        "#define REASON_UNSTABLE (SHTDN_REASON_MAJOR_SYSTEM|SHTDN_REASON_MINOR_UNSTABLE)"
    )]
    public const int REASON_UNSTABLE = (0x00050000 | 0x00000006);

    [NativeTypeName(
        "#define REASON_SWHWRECONF (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_RECONFIG)"
    )]
    public const int REASON_SWHWRECONF = (0x00030000 | 0x00000004);

    [NativeTypeName("#define REASON_OTHER (SHTDN_REASON_MAJOR_OTHER|SHTDN_REASON_MINOR_OTHER)")]
    public const int REASON_OTHER = (0x00000000 | 0x00000000);

    [NativeTypeName("#define REASON_UNKNOWN SHTDN_REASON_UNKNOWN")]
    public const int REASON_UNKNOWN = 0x000000ff;

    [NativeTypeName("#define REASON_LEGACY_API SHTDN_REASON_LEGACY_API")]
    public const uint REASON_LEGACY_API = (0x00070000 | 0x80000000);

    [NativeTypeName("#define REASON_PLANNED_FLAG SHTDN_REASON_FLAG_PLANNED")]
    public const uint REASON_PLANNED_FLAG = 0x80000000;

    [NativeTypeName("#define InitiateSystemShutdownEx InitiateSystemShutdownExW")]
    public static delegate* <
        ushort*,
        ushort*,
        uint,
        BOOL,
        BOOL,
        uint,
        BOOL> InitiateSystemShutdownEx => &InitiateSystemShutdownExW;

    [NativeTypeName("#define InitiateShutdown InitiateShutdownW")]
    public static delegate* <ushort*, ushort*, uint, uint, uint, uint> InitiateShutdown =>
        &InitiateShutdownW;

    [NativeTypeName("#define RegSaveKeyEx RegSaveKeyExW")]
    public static delegate* <HKEY, ushort*, SECURITY_ATTRIBUTES*, uint, int> RegSaveKeyEx =>
        &RegSaveKeyExW;
}
