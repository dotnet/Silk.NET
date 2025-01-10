// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathIsUNCEx(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PCWSTR *")] ushort** ppszServer
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathCchIsRoot([NativeTypeName("PCWSTR")] ushort* pszPath);

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslashEx(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PWSTR *")] ushort** ppszEnd,
        [NativeTypeName("size_t *")] nuint* pcchRemaining
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslash(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslashEx(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PWSTR *")] ushort** ppszEnd,
        [NativeTypeName("size_t *")] nuint* pcchRemaining
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslash(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchSkipRoot(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("PCWSTR *")] ushort** ppszRootEnd
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripToRoot(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveFileSpec(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchFindExtension(
        [NativeTypeName("PCWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PCWSTR *")] ushort** ppszExt
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddExtension(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PCWSTR")] ushort* pszExt
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRenameExtension(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PCWSTR")] ushort* pszExt
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveExtension(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalizeEx(
        [NativeTypeName("PWSTR")] ushort* pszPathOut,
        [NativeTypeName("size_t")] nuint cchPathOut,
        [NativeTypeName("PCWSTR")] ushort* pszPathIn,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalize(
        [NativeTypeName("PWSTR")] ushort* pszPathOut,
        [NativeTypeName("size_t")] nuint cchPathOut,
        [NativeTypeName("PCWSTR")] ushort* pszPathIn
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombineEx(
        [NativeTypeName("PWSTR")] ushort* pszPathOut,
        [NativeTypeName("size_t")] nuint cchPathOut,
        [NativeTypeName("PCWSTR")] ushort* pszPathIn,
        [NativeTypeName("PCWSTR")] ushort* pszMore,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombine(
        [NativeTypeName("PWSTR")] ushort* pszPathOut,
        [NativeTypeName("size_t")] nuint cchPathOut,
        [NativeTypeName("PCWSTR")] ushort* pszPathIn,
        [NativeTypeName("PCWSTR")] ushort* pszMore
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppendEx(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PCWSTR")] ushort* pszMore,
        [NativeTypeName("ULONG")] uint dwFlags
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppend(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath,
        [NativeTypeName("PCWSTR")] ushort* pszMore
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripPrefix(
        [NativeTypeName("PWSTR")] ushort* pszPath,
        [NativeTypeName("size_t")] nuint cchPath
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCombine(
        [NativeTypeName("PCWSTR")] ushort* pszPathIn,
        [NativeTypeName("PCWSTR")] ushort* pszMore,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("PWSTR *")] ushort** ppszPathOut
    );

    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCanonicalize(
        [NativeTypeName("PCWSTR")] ushort* pszPathIn,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("PWSTR *")] ushort** ppszPathOut
    );

    [NativeTypeName("#define VOLUME_PREFIX L\"\\\\?\\Volume\"")]
    public const string VOLUME_PREFIX = "\\\\?\\Volume";

    [NativeTypeName("#define VOLUME_PREFIX_LEN (ARRAYSIZE(VOLUME_PREFIX) - 1)")]
    public const uint VOLUME_PREFIX_LEN = ((11) - 1);

    [NativeTypeName("#define PATHCCH_MAX_CCH 0x8000")]
    public const int PATHCCH_MAX_CCH = 0x8000;
}
