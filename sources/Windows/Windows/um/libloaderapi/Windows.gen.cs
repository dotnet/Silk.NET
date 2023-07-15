// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.DisableThreadLibraryCalls"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DisableThreadLibraryCalls(HMODULE hLibModule);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindResourceExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceExW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindStringOrdinal"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int FindStringOrdinal([NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags, [NativeTypeName("LPCWSTR")] ushort* lpStringSource, int cchSource, [NativeTypeName("LPCWSTR")] ushort* lpStringValue, int cchValue, BOOL bIgnoreCase);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeLibrary"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeLibrary(HMODULE hLibModule);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeLibraryAndExitThread"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FreeLibraryAndExitThread(HMODULE hLibModule, [NativeTypeName("DWORD")] uint dwExitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeResource"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL FreeResource(HGLOBAL hResData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleFileNameA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetModuleFileNameA(HMODULE hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleFileNameW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetModuleFileNameW(HMODULE hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleHandleA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleHandleW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleHandleExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetModuleHandleExA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, HMODULE* phModule);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetModuleHandleExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetModuleHandleExW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpModuleName, HMODULE* phModule);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcAddress"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("FARPROC")]
    public static extern IntPtr GetProcAddress(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpProcName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadLibraryExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryExA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName, HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadLibraryExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryExW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName, HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadResource"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL LoadResource(HMODULE hModule, HRSRC hResInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LockResource"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* LockResource(HGLOBAL hResData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SizeofResource"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SizeofResource(HMODULE hModule, HRSRC hResInfo);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.AddDllDirectory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
    public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RemoveDllDirectory"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDllDirectory([NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetDefaultDllDirectories"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultDllDirectories([NativeTypeName("DWORD")] uint DirectoryFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceLanguagesExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesExA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<HMODULE, sbyte*, sbyte*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceLanguagesExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesExW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceNamesExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesExA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<HMODULE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceNamesExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesExW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceTypesExA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesExA(HMODULE hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<HMODULE, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceTypesExW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesExW(HMODULE hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<HMODULE, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FindResourceW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadLibraryA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LoadLibraryW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceNamesW"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesW(HMODULE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.EnumResourceNamesA"]/*'/>
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesA(HMODULE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<HMODULE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);
    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_TYPES (0x0100)")]
    public const int FIND_RESOURCE_DIRECTORY_TYPES = (0x0100);
    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_NAMES (0x0200)")]
    public const int FIND_RESOURCE_DIRECTORY_NAMES = (0x0200);
    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_LANGUAGES (0x0400)")]
    public const int FIND_RESOURCE_DIRECTORY_LANGUAGES = (0x0400);
    [NativeTypeName("#define SUPPORT_LANG_NUMBER 32")]
    public const int SUPPORT_LANG_NUMBER = 32;
    [NativeTypeName("#define FindResourceEx FindResourceExW")]
    public static delegate*<HMODULE, ushort*, ushort*, ushort, HRSRC> FindResourceEx => &FindResourceExW;

    [NativeTypeName("#define GetModuleFileName GetModuleFileNameW")]
    public static delegate*<HMODULE, ushort*, uint, uint> GetModuleFileName => &GetModuleFileNameW;

    [NativeTypeName("#define GetModuleHandle GetModuleHandleW")]
    public static delegate*<ushort*, HMODULE> GetModuleHandle => &GetModuleHandleW;

    [NativeTypeName("#define GetModuleHandleEx GetModuleHandleExW")]
    public static delegate*<uint, ushort*, HMODULE*, BOOL> GetModuleHandleEx => &GetModuleHandleExW;

    [NativeTypeName("#define CURRENT_IMPORT_REDIRECTION_VERSION 1")]
    public const int CURRENT_IMPORT_REDIRECTION_VERSION = 1;
    [NativeTypeName("#define LoadLibraryEx LoadLibraryExW")]
    public static delegate*<ushort*, HANDLE, uint, HMODULE> LoadLibraryEx => &LoadLibraryExW;

    [NativeTypeName("#define DONT_RESOLVE_DLL_REFERENCES 0x00000001")]
    public const int DONT_RESOLVE_DLL_REFERENCES = 0x00000001;
    [NativeTypeName("#define EnumResourceLanguagesEx EnumResourceLanguagesExW")]
    public static delegate*<HMODULE, ushort*, ushort*, delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL> , nint, uint, ushort, BOOL> EnumResourceLanguagesEx => &EnumResourceLanguagesExW;

    [NativeTypeName("#define EnumResourceNamesEx EnumResourceNamesExW")]
    public static delegate*<HMODULE, ushort*, delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> , nint, uint, ushort, BOOL> EnumResourceNamesEx => &EnumResourceNamesExW;

    [NativeTypeName("#define EnumResourceTypesEx EnumResourceTypesExW")]
    public static delegate*<HMODULE, delegate* unmanaged<HMODULE, ushort*, nint, BOOL> , nint, uint, ushort, BOOL> EnumResourceTypesEx => &EnumResourceTypesExW;

    [NativeTypeName("#define FindResource FindResourceW")]
    public static delegate*<HMODULE, ushort*, ushort*, HRSRC> FindResource => &FindResourceW;

    [NativeTypeName("#define LoadLibrary LoadLibraryW")]
    public static delegate*<ushort*, HMODULE> LoadLibrary => &LoadLibraryW;

    [NativeTypeName("#define EnumResourceNames EnumResourceNamesW")]
    public static delegate*<HMODULE, ushort*, delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> , nint, BOOL> EnumResourceNames => &EnumResourceNamesW;
}