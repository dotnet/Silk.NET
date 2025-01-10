// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL DisableThreadLibraryCalls(HMODULE hLibModule);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceExW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("WORD")] ushort wLanguage
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int FindStringOrdinal(
        [NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags,
        [NativeTypeName("LPCWSTR")] ushort* lpStringSource,
        int cchSource,
        [NativeTypeName("LPCWSTR")] ushort* lpStringValue,
        int cchValue,
        BOOL bIgnoreCase
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeLibrary(HMODULE hLibModule);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern void FreeLibraryAndExitThread(
        HMODULE hLibModule,
        [NativeTypeName("DWORD")] uint dwExitCode
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL FreeResource(HGLOBAL hResData);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetModuleFileNameA(
        HMODULE hModule,
        [NativeTypeName("LPSTR")] sbyte* lpFilename,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetModuleFileNameW(
        HMODULE hModule,
        [NativeTypeName("LPWSTR")] ushort* lpFilename,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetModuleHandleExA(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCSTR")] sbyte* lpModuleName,
        HMODULE* phModule
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL GetModuleHandleExW(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LPCWSTR")] ushort* lpModuleName,
        HMODULE* phModule
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("FARPROC")]
    public static extern void* GetProcAddress(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpProcName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryExA(
        [NativeTypeName("LPCSTR")] sbyte* lpLibFileName,
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryExW(
        [NativeTypeName("LPCWSTR")] ushort* lpLibFileName,
        HANDLE hFile,
        [NativeTypeName("DWORD")] uint dwFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HGLOBAL LoadResource(HMODULE hModule, HRSRC hResInfo);

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern int LoadStringA(
        HINSTANCE hInstance,
        uint uID,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        int cchBufferMax
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    public static extern int LoadStringW(
        HINSTANCE hInstance,
        uint uID,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        int cchBufferMax
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPVOID")]
    public static extern void* LockResource(HGLOBAL hResData);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SizeofResource(HMODULE hModule, HRSRC hResInfo);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
    public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL RemoveDllDirectory(
        [NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetDefaultDllDirectories(
        [NativeTypeName("DWORD")] uint DirectoryFlags
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesExA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("ENUMRESLANGPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, sbyte*, ushort, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceLanguagesExW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("ENUMRESLANGPROCW")]
            delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesExA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("ENUMRESNAMEPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesExW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("ENUMRESNAMEPROCW")]
            delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesExA(
        HMODULE hModule,
        [NativeTypeName("ENUMRESTYPEPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceTypesExW(
        HMODULE hModule,
        [NativeTypeName("ENUMRESTYPEPROCW")]
            delegate* unmanaged<HMODULE, ushort*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LANGID")] ushort LangId
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HRSRC FindResourceW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpType
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern HMODULE LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL EnumResourceNamesW(
        HMODULE hModule,
        [NativeTypeName("LPCWSTR")] ushort* lpType,
        [NativeTypeName("ENUMRESNAMEPROCW")]
            delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL EnumResourceNamesA(
        HMODULE hModule,
        [NativeTypeName("LPCSTR")] sbyte* lpType,
        [NativeTypeName("ENUMRESNAMEPROCA")]
            delegate* unmanaged<HMODULE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc,
        [NativeTypeName("LONG_PTR")] nint lParam
    );

    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_TYPES (0x0100)")]
    public const int FIND_RESOURCE_DIRECTORY_TYPES = (0x0100);

    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_NAMES (0x0200)")]
    public const int FIND_RESOURCE_DIRECTORY_NAMES = (0x0200);

    [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_LANGUAGES (0x0400)")]
    public const int FIND_RESOURCE_DIRECTORY_LANGUAGES = (0x0400);

    [NativeTypeName("#define SUPPORT_LANG_NUMBER 32")]
    public const int SUPPORT_LANG_NUMBER = 32;

    [NativeTypeName("#define FindResourceEx FindResourceExW")]
    public static delegate* <HMODULE, ushort*, ushort*, ushort, HRSRC> FindResourceEx =>
        &FindResourceExW;

    [NativeTypeName("#define GetModuleFileName GetModuleFileNameW")]
    public static delegate* <HMODULE, ushort*, uint, uint> GetModuleFileName => &GetModuleFileNameW;

    [NativeTypeName("#define GetModuleHandle GetModuleHandleW")]
    public static delegate* <ushort*, HMODULE> GetModuleHandle => &GetModuleHandleW;

    [NativeTypeName("#define GetModuleHandleEx GetModuleHandleExW")]
    public static delegate* <uint, ushort*, HMODULE*, BOOL> GetModuleHandleEx =>
        &GetModuleHandleExW;

    [NativeTypeName("#define CURRENT_IMPORT_REDIRECTION_VERSION 1")]
    public const int CURRENT_IMPORT_REDIRECTION_VERSION = 1;

    [NativeTypeName("#define LoadLibraryEx LoadLibraryExW")]
    public static delegate* <ushort*, HANDLE, uint, HMODULE> LoadLibraryEx => &LoadLibraryExW;

    [NativeTypeName("#define DONT_RESOLVE_DLL_REFERENCES 0x00000001")]
    public const int DONT_RESOLVE_DLL_REFERENCES = 0x00000001;

    [NativeTypeName("#define LoadString LoadStringW")]
    public static delegate* <HINSTANCE, uint, ushort*, int, int> LoadString => &LoadStringW;

    [NativeTypeName("#define EnumResourceLanguagesEx EnumResourceLanguagesExW")]
    public static delegate* <
        HMODULE,
        ushort*,
        ushort*,
        delegate* unmanaged<HMODULE, ushort*, ushort*, ushort, nint, BOOL>,
        nint,
        uint,
        ushort,
        BOOL> EnumResourceLanguagesEx => &EnumResourceLanguagesExW;

    [NativeTypeName("#define EnumResourceNamesEx EnumResourceNamesExW")]
    public static delegate* <
        HMODULE,
        ushort*,
        delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL>,
        nint,
        uint,
        ushort,
        BOOL> EnumResourceNamesEx => &EnumResourceNamesExW;

    [NativeTypeName("#define EnumResourceTypesEx EnumResourceTypesExW")]
    public static delegate* <
        HMODULE,
        delegate* unmanaged<HMODULE, ushort*, nint, BOOL>,
        nint,
        uint,
        ushort,
        BOOL> EnumResourceTypesEx => &EnumResourceTypesExW;

    [NativeTypeName("#define FindResource FindResourceW")]
    public static delegate* <HMODULE, ushort*, ushort*, HRSRC> FindResource => &FindResourceW;

    [NativeTypeName("#define LoadLibrary LoadLibraryW")]
    public static delegate* <ushort*, HMODULE> LoadLibrary => &LoadLibraryW;

    [NativeTypeName("#define EnumResourceNames EnumResourceNamesW")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate* <
        HMODULE,
        ushort*,
        delegate* unmanaged<HMODULE, ushort*, ushort*, nint, BOOL>,
        nint,
        BOOL> EnumResourceNames => &EnumResourceNamesW;
}
