// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder"]/*'/>
[Guid("96E5AE6D-6AE1-4B1C-900C-C6480EAA8828")]
[NativeTypeName("struct IResultsFolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IResultsFolder : IResultsFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IResultsFolder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IResultsFolder*, Guid*, void**, int> )(lpVtbl[0]))((IResultsFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IResultsFolder*, uint> )(lpVtbl[1]))((IResultsFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IResultsFolder*, uint> )(lpVtbl[2]))((IResultsFolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder.AddItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddItem(IShellItem* psi)
    {
        return ((delegate* unmanaged<IResultsFolder*, IShellItem*, int> )(lpVtbl[3]))((IResultsFolder*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder.AddIDList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlAdded)
    {
        return ((delegate* unmanaged<IResultsFolder*, ITEMIDLIST*, ITEMIDLIST**, int> )(lpVtbl[4]))((IResultsFolder*)Unsafe.AsPointer(ref this), pidl, ppidlAdded);
    }

    /// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder.RemoveItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveItem(IShellItem* psi)
    {
        return ((delegate* unmanaged<IResultsFolder*, IShellItem*, int> )(lpVtbl[5]))((IResultsFolder*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder.RemoveIDList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IResultsFolder*, ITEMIDLIST*, int> )(lpVtbl[6]))((IResultsFolder*)Unsafe.AsPointer(ref this), pidl);
    }

    /// <include file='IResultsFolder.xml' path='doc/member[@name="IResultsFolder.RemoveAll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAll()
    {
        return ((delegate* unmanaged<IResultsFolder*, int> )(lpVtbl[7]))((IResultsFolder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddItem(IShellItem* psi);
        [VtblIndex(4)]
        HRESULT AddIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlAdded);
        [VtblIndex(5)]
        HRESULT RemoveItem(IShellItem* psi);
        [VtblIndex(6)]
        HRESULT RemoveIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
        [VtblIndex(7)]
        HRESULT RemoveAll();
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
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> AddItem;
        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, ITEMIDLIST**, int> AddIDList;
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> RemoveItem;
        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> RemoveIDList;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAll;
    }
}