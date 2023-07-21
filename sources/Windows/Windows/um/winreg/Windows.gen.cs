// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCloseKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCloseKey(HKEY hKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOverridePredefKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOverridePredefKey(HKEY hKey, HKEY hNewHKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenUserClassesRoot"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenUserClassesRoot(HANDLE hToken, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenCurrentUser"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenCurrentUser([NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDisablePredefinedCache"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDisablePredefinedCache();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDisablePredefinedCacheEx"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDisablePredefinedCacheEx();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegConnectRegistryA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryA([NativeTypeName("LPCSTR")] sbyte* lpMachineName, HKEY hKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegConnectRegistryW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryW([NativeTypeName("LPCWSTR")] ushort* lpMachineName, HKEY hKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegConnectRegistryExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryExA([NativeTypeName("LPCSTR")] sbyte* lpMachineName, HKEY hKey, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegConnectRegistryExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegConnectRegistryExW([NativeTypeName("LPCWSTR")] ushort* lpMachineName, HKEY hKey, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyTransactedA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyTransactedA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCreateKeyTransactedW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCreateKeyTransactedW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("LPDWORD")] uint* lpdwDisposition, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyTransactedA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyTransactedA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyTransactedW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyTransactedW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint Reserved, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParameter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDisableReflectionKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegDisableReflectionKey(HKEY hBase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnableReflectionKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegEnableReflectionKey(HKEY hBase);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryReflectionKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int RegQueryReflectionKey(HKEY hBase, BOOL* bIsReflectionDisabled);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteValueA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteValueW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyA(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("DWORD")] uint cchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyW(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("DWORD")] uint cchName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumKeyExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyExA(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpName, [NativeTypeName("LPDWORD")] uint* lpcchName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumKeyExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumKeyExW(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpName, [NativeTypeName("LPDWORD")] uint* lpcchName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumValueA(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPSTR")] sbyte* lpValueName, [NativeTypeName("LPDWORD")] uint* lpcchValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegEnumValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegEnumValueW(HKEY hKey, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("LPWSTR")] ushort* lpValueName, [NativeTypeName("LPDWORD")] uint* lpcchValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegFlushKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegFlushKey(HKEY hKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegGetKeySecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetKeySecurity(HKEY hKey, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegNotifyChangeKeyValue"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegNotifyChangeKeyValue(HKEY hKey, BOOL bWatchSubtree, [NativeTypeName("DWORD")] uint dwNotifyFilter, HANDLE hEvent, BOOL fAsynchronous);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyTransactedA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyTransactedA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegOpenKeyTransactedW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegOpenKeyTransactedW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint ulOptions, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("PHKEY")] HKEY* phkResult, HANDLE hTransaction, [NativeTypeName("PVOID")] void* pExtendedParemeter);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryInfoKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryInfoKeyA(HKEY hKey, [NativeTypeName("LPSTR")] sbyte* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpcSubKeys, [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen, [NativeTypeName("LPDWORD")] uint* lpcValues, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryInfoKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryInfoKeyW(HKEY hKey, [NativeTypeName("LPWSTR")] ushort* lpClass, [NativeTypeName("LPDWORD")] uint* lpcchClass, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpcSubKeys, [NativeTypeName("LPDWORD")] uint* lpcbMaxSubKeyLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxClassLen, [NativeTypeName("LPDWORD")] uint* lpcValues, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueNameLen, [NativeTypeName("LPDWORD")] uint* lpcbMaxValueLen, [NativeTypeName("LPDWORD")] uint* lpcbSecurityDescriptor, [NativeTypeName("PFILETIME")] FILETIME* lpftLastWriteTime);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPSTR")] sbyte* lpData, [NativeTypeName("PLONG")] int* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPWSTR")] ushort* lpData, [NativeTypeName("PLONG")] int* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryMultipleValuesA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryMultipleValuesA(HKEY hKey, [NativeTypeName("PVALENTA")] VALENTA* val_list, [NativeTypeName("DWORD")] uint num_vals, [NativeTypeName("LPSTR")] sbyte* lpValueBuf, [NativeTypeName("LPDWORD")] uint* ldwTotsize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryMultipleValuesW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryMultipleValuesW(HKEY hKey, [NativeTypeName("PVALENTW")] VALENTW* val_list, [NativeTypeName("DWORD")] uint num_vals, [NativeTypeName("LPWSTR")] ushort* lpValueBuf, [NativeTypeName("LPDWORD")] uint* ldwTotsize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryValueExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegQueryValueExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegQueryValueExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("LPDWORD")] uint* lpReserved, [NativeTypeName("LPDWORD")] uint* lpType, [NativeTypeName("LPBYTE")] byte* lpData, [NativeTypeName("LPDWORD")] uint* lpcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegReplaceKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegReplaceKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpNewFile, [NativeTypeName("LPCSTR")] sbyte* lpOldFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegReplaceKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegReplaceKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpNewFile, [NativeTypeName("LPCWSTR")] ushort* lpOldFile);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegRestoreKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRestoreKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegRestoreKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRestoreKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegRenameKey"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegRenameKey(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKeyName, [NativeTypeName("LPCWSTR")] ushort* lpNewKeyName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSaveKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSaveKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetKeySecurity"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeySecurity(HKEY hKey, [NativeTypeName("SECURITY_INFORMATION")] uint SecurityInformation, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCSTR")] sbyte* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCWSTR")] ushort* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetValueExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const BYTE *")] byte* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetValueExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetValueExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("DWORD")] uint Reserved, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const BYTE *")] byte* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegUnLoadKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegUnLoadKeyA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegUnLoadKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegUnLoadKeyW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyValueA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteKeyValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteKeyValueW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetKeyValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeyValueA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValueName, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSetKeyValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSetKeyValueW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValueName, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("LPCVOID")] void* lpData, [NativeTypeName("DWORD")] uint cbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteTreeA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteTreeA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegDeleteTreeW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegDeleteTreeW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCopyTreeA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCopyTreeA(HKEY hKeySrc, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, HKEY hKeyDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegGetValueA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetValueA(HKEY hkey, [NativeTypeName("LPCSTR")] sbyte* lpSubKey, [NativeTypeName("LPCSTR")] sbyte* lpValue, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* pdwType, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegGetValueW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegGetValueW(HKEY hkey, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, [NativeTypeName("LPCWSTR")] ushort* lpValue, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDWORD")] uint* pdwType, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPDWORD")] uint* pcbData);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegCopyTreeW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegCopyTreeW(HKEY hKeySrc, [NativeTypeName("LPCWSTR")] ushort* lpSubKey, HKEY hKeyDest);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadMUIStringA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadMUIStringA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* pszValue, [NativeTypeName("LPSTR")] sbyte* pszOutBuf, [NativeTypeName("DWORD")] uint cbOutBuf, [NativeTypeName("LPDWORD")] uint* pcbData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCSTR")] sbyte* pszDirectory);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadMUIStringW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadMUIStringW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* pszValue, [NativeTypeName("LPWSTR")] ushort* pszOutBuf, [NativeTypeName("DWORD")] uint cbOutBuf, [NativeTypeName("LPDWORD")] uint* pcbData, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("LPCWSTR")] ushort* pszDirectory);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadAppKeyA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadAppKeyA([NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegLoadAppKeyW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegLoadAppKeyW([NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("PHKEY")] HKEY* phkResult, [NativeTypeName("REGSAM")] uint samDesired, [NativeTypeName("DWORD")] uint dwOptions, [NativeTypeName("DWORD")] uint Reserved);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateSystemShutdownA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateSystemShutdownW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AbortSystemShutdownA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AbortSystemShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.AbortSystemShutdownW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL AbortSystemShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateSystemShutdownExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownExA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown, [NativeTypeName("DWORD")] uint dwReason);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateSystemShutdownExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL InitiateSystemShutdownExW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwTimeout, BOOL bForceAppsClosed, BOOL bRebootAfterShutdown, [NativeTypeName("DWORD")] uint dwReason);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateShutdownA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InitiateShutdownA([NativeTypeName("LPSTR")] sbyte* lpMachineName, [NativeTypeName("LPSTR")] sbyte* lpMessage, [NativeTypeName("DWORD")] uint dwGracePeriod, [NativeTypeName("DWORD")] uint dwShutdownFlags, [NativeTypeName("DWORD")] uint dwReason);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitiateShutdownW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint InitiateShutdownW([NativeTypeName("LPWSTR")] ushort* lpMachineName, [NativeTypeName("LPWSTR")] ushort* lpMessage, [NativeTypeName("DWORD")] uint dwGracePeriod, [NativeTypeName("DWORD")] uint dwShutdownFlags, [NativeTypeName("DWORD")] uint dwReason);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CheckForHiberboot"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint CheckForHiberboot([NativeTypeName("PBOOLEAN")] byte* pHiberboot, [NativeTypeName("BOOLEAN")] byte bClearFlag);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSaveKeyExA"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyExA(HKEY hKey, [NativeTypeName("LPCSTR")] sbyte* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint Flags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegSaveKeyExW"]/*' />
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("LSTATUS")]
    public static extern int RegSaveKeyExW(HKEY hKey, [NativeTypeName("LPCWSTR")] ushort* lpFile, [NativeTypeName("const LPSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint Flags);

    [NativeTypeName("#define PROVIDER_KEEPS_VALUE_LENGTH 0x1")]
    public const int PROVIDER_KEEPS_VALUE_LENGTH = 0x1;

    [NativeTypeName("#define WIN31_CLASS NULL")]
    public const int WIN31_CLASS = 0;

    [NativeTypeName("#define RegConnectRegistry RegConnectRegistryW")]
    public static delegate*<ushort*, HKEY, HKEY*, int> RegConnectRegistry => &RegConnectRegistryW;

    [NativeTypeName("#define RegConnectRegistryEx RegConnectRegistryExW")]
    public static delegate*<ushort*, HKEY, uint, HKEY*, int> RegConnectRegistryEx => &RegConnectRegistryExW;

    [NativeTypeName("#define RegCreateKey RegCreateKeyW")]
    public static delegate*<HKEY, ushort*, HKEY*, int> RegCreateKey => &RegCreateKeyW;

    [NativeTypeName("#define RegCreateKeyEx RegCreateKeyExW")]
    public static delegate*<HKEY, ushort*, uint, ushort*, uint, uint, SECURITY_ATTRIBUTES*, HKEY*, uint*, int> RegCreateKeyEx => &RegCreateKeyExW;

    [NativeTypeName("#define RegCreateKeyTransacted RegCreateKeyTransactedW")]
    public static delegate*<HKEY, ushort*, uint, ushort*, uint, uint, SECURITY_ATTRIBUTES*, HKEY*, uint*, HANDLE, void*, int> RegCreateKeyTransacted => &RegCreateKeyTransactedW;

    [NativeTypeName("#define RegDeleteKey RegDeleteKeyW")]
    public static delegate*<HKEY, ushort*, int> RegDeleteKey => &RegDeleteKeyW;

    [NativeTypeName("#define RegDeleteKeyEx RegDeleteKeyExW")]
    public static delegate*<HKEY, ushort*, uint, uint, int> RegDeleteKeyEx => &RegDeleteKeyExW;

    [NativeTypeName("#define RegDeleteKeyTransacted RegDeleteKeyTransactedW")]
    public static delegate*<HKEY, ushort*, uint, uint, HANDLE, void*, int> RegDeleteKeyTransacted => &RegDeleteKeyTransactedW;

    [NativeTypeName("#define RegDeleteValue RegDeleteValueW")]
    public static delegate*<HKEY, ushort*, int> RegDeleteValue => &RegDeleteValueW;

    [NativeTypeName("#define RegEnumKey RegEnumKeyW")]
    public static delegate*<HKEY, uint, ushort*, uint, int> RegEnumKey => &RegEnumKeyW;

    [NativeTypeName("#define RegEnumKeyEx RegEnumKeyExW")]
    public static delegate*<HKEY, uint, ushort*, uint*, uint*, ushort*, uint*, FILETIME*, int> RegEnumKeyEx => &RegEnumKeyExW;

    [NativeTypeName("#define RegEnumValue RegEnumValueW")]
    public static delegate*<HKEY, uint, ushort*, uint*, uint*, uint*, byte*, uint*, int> RegEnumValue => &RegEnumValueW;

    [NativeTypeName("#define RegLoadKey RegLoadKeyW")]
    public static delegate*<HKEY, ushort*, ushort*, int> RegLoadKey => &RegLoadKeyW;

    [NativeTypeName("#define RegOpenKey RegOpenKeyW")]
    public static delegate*<HKEY, ushort*, HKEY*, int> RegOpenKey => &RegOpenKeyW;

    [NativeTypeName("#define RegOpenKeyEx RegOpenKeyExW")]
    public static delegate*<HKEY, ushort*, uint, uint, HKEY*, int> RegOpenKeyEx => &RegOpenKeyExW;

    [NativeTypeName("#define RegOpenKeyTransacted RegOpenKeyTransactedW")]
    public static delegate*<HKEY, ushort*, uint, uint, HKEY*, HANDLE, void*, int> RegOpenKeyTransacted => &RegOpenKeyTransactedW;

    [NativeTypeName("#define RegQueryInfoKey RegQueryInfoKeyW")]
    public static delegate*<HKEY, ushort*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, uint*, FILETIME*, int> RegQueryInfoKey => &RegQueryInfoKeyW;

    [NativeTypeName("#define RegQueryValue RegQueryValueW")]
    public static delegate*<HKEY, ushort*, ushort*, int*, int> RegQueryValue => &RegQueryValueW;

    [NativeTypeName("#define RegQueryMultipleValues RegQueryMultipleValuesW")]
    public static delegate*<HKEY, VALENTW*, uint, ushort*, uint*, int> RegQueryMultipleValues => &RegQueryMultipleValuesW;

    [NativeTypeName("#define RegQueryValueEx RegQueryValueExW")]
    public static delegate*<HKEY, ushort*, uint*, uint*, byte*, uint*, int> RegQueryValueEx => &RegQueryValueExW;

    [NativeTypeName("#define RegReplaceKey RegReplaceKeyW")]
    public static delegate*<HKEY, ushort*, ushort*, ushort*, int> RegReplaceKey => &RegReplaceKeyW;

    [NativeTypeName("#define RegRestoreKey RegRestoreKeyW")]
    public static delegate*<HKEY, ushort*, uint, int> RegRestoreKey => &RegRestoreKeyW;

    [NativeTypeName("#define RegSaveKey RegSaveKeyW")]
    public static delegate*<HKEY, ushort*, SECURITY_ATTRIBUTES*, int> RegSaveKey => &RegSaveKeyW;

    [NativeTypeName("#define RegSetValue RegSetValueW")]
    public static delegate*<HKEY, ushort*, uint, ushort*, uint, int> RegSetValue => &RegSetValueW;

    [NativeTypeName("#define RegSetValueEx RegSetValueExW")]
    public static delegate*<HKEY, ushort*, uint, uint, byte*, uint, int> RegSetValueEx => &RegSetValueExW;

    [NativeTypeName("#define RegUnLoadKey RegUnLoadKeyW")]
    public static delegate*<HKEY, ushort*, int> RegUnLoadKey => &RegUnLoadKeyW;

    [NativeTypeName("#define RegDeleteKeyValue RegDeleteKeyValueW")]
    public static delegate*<HKEY, ushort*, ushort*, int> RegDeleteKeyValue => &RegDeleteKeyValueW;

    [NativeTypeName("#define RegSetKeyValue RegSetKeyValueW")]
    public static delegate*<HKEY, ushort*, ushort*, uint, void*, uint, int> RegSetKeyValue => &RegSetKeyValueW;

    [NativeTypeName("#define RegDeleteTree RegDeleteTreeW")]
    public static delegate*<HKEY, ushort*, int> RegDeleteTree => &RegDeleteTreeW;

    [NativeTypeName("#define RegGetValue RegGetValueW")]
    public static delegate*<HKEY, ushort*, ushort*, uint, uint*, void*, uint*, int> RegGetValue => &RegGetValueW;

    [NativeTypeName("#define RegCopyTree RegCopyTreeW")]
    public static delegate*<HKEY, ushort*, HKEY, int> RegCopyTree => &RegCopyTreeW;

    [NativeTypeName("#define RegLoadMUIString RegLoadMUIStringW")]
    public static delegate*<HKEY, ushort*, ushort*, uint, uint*, uint, ushort*, int> RegLoadMUIString => &RegLoadMUIStringW;

    [NativeTypeName("#define RegLoadAppKey RegLoadAppKeyW")]
    public static delegate*<ushort*, HKEY*, uint, uint, uint, int> RegLoadAppKey => &RegLoadAppKeyW;

    [NativeTypeName("#define InitiateSystemShutdown InitiateSystemShutdownW")]
    public static delegate*<ushort*, ushort*, uint, BOOL, BOOL, BOOL> InitiateSystemShutdown => &InitiateSystemShutdownW;

    [NativeTypeName("#define AbortSystemShutdown AbortSystemShutdownW")]
    public static delegate*<ushort*, BOOL> AbortSystemShutdown => &AbortSystemShutdownW;

    [NativeTypeName("#define REASON_SWINSTALL (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_INSTALLATION)")]
    public const int REASON_SWINSTALL = (0x00030000 | 0x00000002);

    [NativeTypeName("#define REASON_HWINSTALL (SHTDN_REASON_MAJOR_HARDWARE|SHTDN_REASON_MINOR_INSTALLATION)")]
    public const int REASON_HWINSTALL = (0x00010000 | 0x00000002);

    [NativeTypeName("#define REASON_SERVICEHANG (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_HUNG)")]
    public const int REASON_SERVICEHANG = (0x00030000 | 0x00000005);

    [NativeTypeName("#define REASON_UNSTABLE (SHTDN_REASON_MAJOR_SYSTEM|SHTDN_REASON_MINOR_UNSTABLE)")]
    public const int REASON_UNSTABLE = (0x00050000 | 0x00000006);

    [NativeTypeName("#define REASON_SWHWRECONF (SHTDN_REASON_MAJOR_SOFTWARE|SHTDN_REASON_MINOR_RECONFIG)")]
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
    public static delegate*<ushort*, ushort*, uint, BOOL, BOOL, uint, BOOL> InitiateSystemShutdownEx => &InitiateSystemShutdownExW;

    [NativeTypeName("#define InitiateShutdown InitiateShutdownW")]
    public static delegate*<ushort*, ushort*, uint, uint, uint, uint> InitiateShutdown => &InitiateShutdownW;

    [NativeTypeName("#define RegSaveKeyEx RegSaveKeyExW")]
    public static delegate*<HKEY, ushort*, SECURITY_ATTRIBUTES*, uint, int> RegSaveKeyEx => &RegSaveKeyExW;
}
