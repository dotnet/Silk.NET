// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsUNCEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathIsUNCEx([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR *")] ushort** ppszServer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchIsRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern BOOL PathCchIsRoot([NativeTypeName("PCWSTR")] ushort* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddBackslashEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslashEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] ushort** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddBackslash"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddBackslash([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveBackslashEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslashEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] ushort** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveBackslash"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveBackslash([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchSkipRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchSkipRoot([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR *")] ushort** ppszRootEnd);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchStripToRoot"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripToRoot([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveFileSpec"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveFileSpec([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchFindExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchFindExtension([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR *")] ushort** ppszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAddExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAddExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRenameExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRenameExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszExt);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchRemoveExtension"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchRemoveExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCanonicalizeEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalizeEx([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCanonicalize"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCanonicalize([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCombineEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombineEx([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchCombine"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchCombine([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAppendEx"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppendEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchAppend"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchAppend([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszMore);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathCchStripPrefix"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathCchStripPrefix([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAllocCombine"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCombine([NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppszPathOut);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathAllocCanonicalize"]/*' />
    [DllImport("kernelbase", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PathAllocCanonicalize([NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppszPathOut);

    [NativeTypeName("#define VOLUME_PREFIX L\"\\\\\\\\?\\\\Volume\"")]
    public const string VOLUME_PREFIX = "\\\\?\\Volume";

    [NativeTypeName("#define VOLUME_PREFIX_LEN (ARRAYSIZE(VOLUME_PREFIX) - 1)")]
    public const uint VOLUME_PREFIX_LEN = ((11) - 1);

    [NativeTypeName("#define PATHCCH_MAX_CCH 0x8000")]
    public const int PATHCCH_MAX_CCH = 0x8000;
}
