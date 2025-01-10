// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateDocfile(
        [NativeTypeName("const WCHAR *")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint reserved,
        IStorage* ppstgOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateDocfileOnILockBytes(
        ILockBytes plkbyt,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint reserved,
        IStorage* ppstgOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorage(
        [NativeTypeName("const WCHAR *")] ushort* pwcsName,
        IStorage pstgPriority,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("SNB")] ushort** snbExclude,
        [NativeTypeName("DWORD")] uint reserved,
        IStorage* ppstgOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorageOnILockBytes(
        ILockBytes plkbyt,
        IStorage pstgPriority,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("SNB")] ushort** snbExclude,
        [NativeTypeName("DWORD")] uint reserved,
        IStorage* ppstgOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgIsStorageFile(
        [NativeTypeName("const WCHAR *")] ushort* pwcsName
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgIsStorageILockBytes(ILockBytes plkbyt);

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgSetTimes(
        [NativeTypeName("const WCHAR *")] ushort* lpszName,
        [NativeTypeName("const FILETIME *")] FILETIME* pctime,
        [NativeTypeName("const FILETIME *")] FILETIME* patime,
        [NativeTypeName("const FILETIME *")] FILETIME* pmtime
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateStorageEx(
        [NativeTypeName("const WCHAR *")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint stgfmt,
        [NativeTypeName("DWORD")] uint grfAttrs,
        STGOPTIONS* pStgOptions,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppObjectOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorageEx(
        [NativeTypeName("const WCHAR *")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint stgfmt,
        [NativeTypeName("DWORD")] uint grfAttrs,
        STGOPTIONS* pStgOptions,
        [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppObjectOpen
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreatePropStg(
        IUnknown pUnk,
        [NativeTypeName("const IID &")] Guid* fmtid,
        [NativeTypeName("const CLSID *")] Guid* pclsid,
        [NativeTypeName("DWORD")] uint grfFlags,
        [NativeTypeName("DWORD")] uint dwReserved,
        IPropertyStorage* ppPropStg
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenPropStg(
        IUnknown pUnk,
        [NativeTypeName("const IID &")] Guid* fmtid,
        [NativeTypeName("DWORD")] uint grfFlags,
        [NativeTypeName("DWORD")] uint dwReserved,
        IPropertyStorage* ppPropStg
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreatePropSetStg(
        IStorage pStorage,
        [NativeTypeName("DWORD")] uint dwReserved,
        IPropertySetStorage* ppPropSetStg
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT FmtIdToPropStgName(
        [NativeTypeName("const FMTID *")] Guid* pfmtid,
        [NativeTypeName("LPOLESTR")] ushort* oszName
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropStgNameToFmtId(
        [NativeTypeName("const LPOLESTR")] ushort* oszName,
        [NativeTypeName("FMTID *")] Guid* pfmtid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ReadClassStg(
        [NativeTypeName("LPSTORAGE")] IStorage pStg,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT WriteClassStg(
        [NativeTypeName("LPSTORAGE")] IStorage pStg,
        [NativeTypeName("const IID &")] Guid* rclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ReadClassStm(
        [NativeTypeName("LPSTREAM")] IStream pStm,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT WriteClassStm(
        [NativeTypeName("LPSTREAM")] IStream pStm,
        [NativeTypeName("const IID &")] Guid* rclsid
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetHGlobalFromILockBytes(
        [NativeTypeName("LPLOCKBYTES")] ILockBytes plkbyt,
        HGLOBAL* phglobal
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateILockBytesOnHGlobal(
        HGLOBAL hGlobal,
        BOOL fDeleteOnRelease,
        [NativeTypeName("LPLOCKBYTES *")] ILockBytes* pplkbyt
    );

    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetConvertStg([NativeTypeName("LPSTORAGE")] IStorage pStg);

    [NativeTypeName("#define CWCSTORAGENAME 32")]
    public const int CWCSTORAGENAME = 32;

    [NativeTypeName("#define STGOPTIONS_VERSION 2")]
    public const int STGOPTIONS_VERSION = 2;

    [NativeTypeName("#define CCH_MAX_PROPSTG_NAME 31")]
    public const int CCH_MAX_PROPSTG_NAME = 31;
}
