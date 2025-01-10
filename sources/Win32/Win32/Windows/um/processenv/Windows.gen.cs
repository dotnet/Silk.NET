// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processenv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernel32", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SetEnvironmentStringsW(
        [NativeTypeName("LPWCH")] ushort* NewEnvironment
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [SuppressGCTransition]
    public static extern HANDLE GetStdHandle([NativeTypeName("DWORD")] uint nStdHandle);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetStdHandle(
        [NativeTypeName("DWORD")] uint nStdHandle,
        HANDLE hHandle
    );

    [DllImport("api-ms-win-core-processenvironment-l1-1-0", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL SetStdHandleEx(
        [NativeTypeName("DWORD")] uint nStdHandle,
        HANDLE hHandle,
        [NativeTypeName("PHANDLE")] HANDLE* phPrevValue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPSTR")]
    public static extern sbyte* GetCommandLineA();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWSTR")]
    public static extern ushort* GetCommandLineW();

    [DllImport("kernel32", EntryPoint = "GetEnvironmentStrings", ExactSpelling = true)]
    [return: NativeTypeName("LPCH")]
    public static extern sbyte* GetEnvironmentStringsA();

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("LPWCH")]
    public static extern ushort* GetEnvironmentStringsW();

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeEnvironmentStringsA([NativeTypeName("LPCH")] sbyte* penv);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL FreeEnvironmentStringsW([NativeTypeName("LPWCH")] ushort* penv);

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEnvironmentVariableA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetEnvironmentVariableW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEnvironmentVariableA(
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        [NativeTypeName("LPCSTR")] sbyte* lpValue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern BOOL SetEnvironmentVariableW(
        [NativeTypeName("LPCWSTR")] ushort* lpName,
        [NativeTypeName("LPCWSTR")] ushort* lpValue
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ExpandEnvironmentStringsA(
        [NativeTypeName("LPCSTR")] sbyte* lpSrc,
        [NativeTypeName("LPSTR")] sbyte* lpDst,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint ExpandEnvironmentStringsW(
        [NativeTypeName("LPCWSTR")] ushort* lpSrc,
        [NativeTypeName("LPWSTR")] ushort* lpDst,
        [NativeTypeName("DWORD")] uint nSize
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetCurrentDirectoryA([NativeTypeName("LPCSTR")] sbyte* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL SetCurrentDirectoryW([NativeTypeName("LPCWSTR")] ushort* lpPathName);

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentDirectoryA(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint GetCurrentDirectoryW(
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SearchPathW(
        [NativeTypeName("LPCWSTR")] ushort* lpPath,
        [NativeTypeName("LPCWSTR")] ushort* lpFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpExtension,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPWSTR")] ushort* lpBuffer,
        [NativeTypeName("LPWSTR *")] ushort** lpFilePart
    );

    [DllImport("kernel32", ExactSpelling = true)]
    [SetsLastSystemError]
    [return: NativeTypeName("DWORD")]
    public static extern uint SearchPathA(
        [NativeTypeName("LPCSTR")] sbyte* lpPath,
        [NativeTypeName("LPCSTR")] sbyte* lpFileName,
        [NativeTypeName("LPCSTR")] sbyte* lpExtension,
        [NativeTypeName("DWORD")] uint nBufferLength,
        [NativeTypeName("LPSTR")] sbyte* lpBuffer,
        [NativeTypeName("LPSTR *")] sbyte** lpFilePart
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL NeedCurrentDirectoryForExePathA(
        [NativeTypeName("LPCSTR")] sbyte* ExeName
    );

    [DllImport("kernel32", ExactSpelling = true)]
    public static extern BOOL NeedCurrentDirectoryForExePathW(
        [NativeTypeName("LPCWSTR")] ushort* ExeName
    );

    [NativeTypeName("#define SetEnvironmentStrings SetEnvironmentStringsW")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static delegate* <ushort*, BOOL> SetEnvironmentStrings => &SetEnvironmentStringsW;

    [NativeTypeName("#define GetCommandLine GetCommandLineW")]
    public static delegate* <ushort*> GetCommandLine => &GetCommandLineW;

    [NativeTypeName("#define GetEnvironmentStrings GetEnvironmentStringsW")]
    public static delegate* <ushort*> GetEnvironmentStrings => &GetEnvironmentStringsW;

    [NativeTypeName("#define FreeEnvironmentStrings FreeEnvironmentStringsW")]
    public static delegate* <ushort*, BOOL> FreeEnvironmentStrings => &FreeEnvironmentStringsW;

    [NativeTypeName("#define GetEnvironmentVariable GetEnvironmentVariableW")]
    public static delegate* <ushort*, ushort*, uint, uint> GetEnvironmentVariable =>
        &GetEnvironmentVariableW;

    [NativeTypeName("#define SetEnvironmentVariable SetEnvironmentVariableW")]
    public static delegate* <ushort*, ushort*, BOOL> SetEnvironmentVariable =>
        &SetEnvironmentVariableW;

    [NativeTypeName("#define ExpandEnvironmentStrings ExpandEnvironmentStringsW")]
    public static delegate* <ushort*, ushort*, uint, uint> ExpandEnvironmentStrings =>
        &ExpandEnvironmentStringsW;

    [NativeTypeName("#define SetCurrentDirectory SetCurrentDirectoryW")]
    public static delegate* <ushort*, BOOL> SetCurrentDirectory => &SetCurrentDirectoryW;

    [NativeTypeName("#define GetCurrentDirectory GetCurrentDirectoryW")]
    public static delegate* <uint, ushort*, uint> GetCurrentDirectory => &GetCurrentDirectoryW;

    [NativeTypeName("#define SearchPath SearchPathW")]
    public static delegate* <ushort*, ushort*, ushort*, uint, ushort*, ushort**, uint> SearchPath =>
        &SearchPathW;

    [NativeTypeName("#define NeedCurrentDirectoryForExePath NeedCurrentDirectoryForExePathW")]
    public static delegate* <ushort*, BOOL> NeedCurrentDirectoryForExePath =>
        &NeedCurrentDirectoryForExePathW;
}
