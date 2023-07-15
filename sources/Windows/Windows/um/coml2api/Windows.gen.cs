// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/coml2api.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgCreateDocfile"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateDocfile([NativeTypeName("const WCHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstgOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgCreateDocfileOnILockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateDocfileOnILockBytes(ILockBytes* plkbyt, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstgOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgOpenStorage"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorage([NativeTypeName("const WCHAR *")] ushort* pwcsName, IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstgOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgOpenStorageOnILockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorageOnILockBytes(ILockBytes* plkbyt, IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstgOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgIsStorageFile"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgIsStorageFile([NativeTypeName("const WCHAR *")] ushort* pwcsName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgIsStorageILockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgIsStorageILockBytes(ILockBytes* plkbyt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgSetTimes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgSetTimes([NativeTypeName("const WCHAR *")] ushort* lpszName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgCreateStorageEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreateStorageEx([NativeTypeName("const WCHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, STGOPTIONS* pStgOptions, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("const IID &")] Guid* riid, void** ppObjectOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgOpenStorageEx"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenStorageEx([NativeTypeName("const WCHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, STGOPTIONS* pStgOptions, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecurityDescriptor, [NativeTypeName("const IID &")] Guid* riid, void** ppObjectOpen);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgCreatePropStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreatePropStg(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint dwReserved, IPropertyStorage** ppPropStg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgOpenPropStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgOpenPropStg(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint dwReserved, IPropertyStorage** ppPropStg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.StgCreatePropSetStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT StgCreatePropSetStg(IStorage* pStorage, [NativeTypeName("DWORD")] uint dwReserved, IPropertySetStorage** ppPropSetStg);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.FmtIdToPropStgName"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT FmtIdToPropStgName([NativeTypeName("const FMTID *")] Guid* pfmtid, [NativeTypeName("LPOLESTR")] ushort* oszName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropStgNameToFmtId"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT PropStgNameToFmtId([NativeTypeName("const LPOLESTR")] ushort* oszName, [NativeTypeName("FMTID *")] Guid* pfmtid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadClassStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ReadClassStg([NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("CLSID *")] Guid* pclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteClassStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT WriteClassStg([NativeTypeName("LPSTORAGE")] IStorage* pStg, [NativeTypeName("const IID &")] Guid* rclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.ReadClassStm"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT ReadClassStm([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("CLSID *")] Guid* pclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WriteClassStm"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT WriteClassStm([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* rclsid);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetHGlobalFromILockBytes"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetHGlobalFromILockBytes([NativeTypeName("LPLOCKBYTES")] ILockBytes* plkbyt, HGLOBAL* phglobal);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateILockBytesOnHGlobal"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT CreateILockBytesOnHGlobal(HGLOBAL hGlobal, BOOL fDeleteOnRelease, [NativeTypeName("LPLOCKBYTES *")] ILockBytes** pplkbyt);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetConvertStg"]/*'/>
    [DllImport("ole32", ExactSpelling = true)]
    public static extern HRESULT GetConvertStg([NativeTypeName("LPSTORAGE")] IStorage* pStg);
    [NativeTypeName("#define CWCSTORAGENAME 32")]
    public const int CWCSTORAGENAME = 32;
    [NativeTypeName("#define STGOPTIONS_VERSION 2")]
    public const int STGOPTIONS_VERSION = 2;
    [NativeTypeName("#define CCH_MAX_PROPSTG_NAME 31")]
    public const int CCH_MAX_PROPSTG_NAME = 31;
}