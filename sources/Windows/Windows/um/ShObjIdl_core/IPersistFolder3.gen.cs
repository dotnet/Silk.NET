// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IPersistFolder3.xml' path='doc/member[@name="IPersistFolder3"]/*' />
[Guid("CEF04FDF-FE72-11D2-87A5-00C04F6837CF")]
[NativeTypeName("struct IPersistFolder3 : IPersistFolder2")]
[NativeInheritance("IPersistFolder2")]
public unsafe partial struct IPersistFolder3 : IPersistFolder3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistFolder3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistFolder3*, Guid*, void**, int>)(lpVtbl[0]))((IPersistFolder3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistFolder3*, uint>)(lpVtbl[1]))((IPersistFolder3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistFolder3*, uint>)(lpVtbl[2]))((IPersistFolder3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistFolder3*, Guid*, int>)(lpVtbl[3]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <inheritdoc cref="IPersistFolder.Initialize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IPersistFolder3*, ITEMIDLIST*, int>)(lpVtbl[4]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pidl);
    }

    /// <inheritdoc cref="IPersistFolder2.GetCurFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurFolder([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IPersistFolder3*, ITEMIDLIST**, int>)(lpVtbl[5]))((IPersistFolder3*)Unsafe.AsPointer(ref this), ppidl);
    }

    /// <include file='IPersistFolder3.xml' path='doc/member[@name="IPersistFolder3.InitializeEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeEx(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlRoot, [NativeTypeName("const PERSIST_FOLDER_TARGET_INFO *")] PERSIST_FOLDER_TARGET_INFO* ppfti)
    {
        return ((delegate* unmanaged<IPersistFolder3*, IBindCtx*, ITEMIDLIST*, PERSIST_FOLDER_TARGET_INFO*, int>)(lpVtbl[6]))((IPersistFolder3*)Unsafe.AsPointer(ref this), pbc, pidlRoot, ppfti);
    }

    /// <include file='IPersistFolder3.xml' path='doc/member[@name="IPersistFolder3.GetFolderTargetInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFolderTargetInfo(PERSIST_FOLDER_TARGET_INFO* ppfti)
    {
        return ((delegate* unmanaged<IPersistFolder3*, PERSIST_FOLDER_TARGET_INFO*, int>)(lpVtbl[7]))((IPersistFolder3*)Unsafe.AsPointer(ref this), ppfti);
    }

    public interface Interface : IPersistFolder2.Interface
    {
        [VtblIndex(6)]
        HRESULT InitializeEx(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlRoot, [NativeTypeName("const PERSIST_FOLDER_TARGET_INFO *")] PERSIST_FOLDER_TARGET_INFO* ppfti);

        [VtblIndex(7)]
        HRESULT GetFolderTargetInfo(PERSIST_FOLDER_TARGET_INFO* ppfti);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> Initialize;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetCurFolder;

        [NativeTypeName("HRESULT (IBindCtx *, LPCITEMIDLIST, const PERSIST_FOLDER_TARGET_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, ITEMIDLIST*, PERSIST_FOLDER_TARGET_INFO*, int> InitializeEx;

        [NativeTypeName("HRESULT (PERSIST_FOLDER_TARGET_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PERSIST_FOLDER_TARGET_INFO*, int> GetFolderTargetInfo;
    }
}
