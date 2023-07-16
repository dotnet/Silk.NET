// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFolderView.xml' path='doc/member[@name="IFolderView"]/*'/>
[Guid("CDE725B0-CCC9-4519-917E-325D72FAB4CE")]
[NativeTypeName("struct IFolderView : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderView : IFolderView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderView));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderView*, Guid*, void**, int> )(lpVtbl[0]))((IFolderView*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFolderView*, uint> )(lpVtbl[1]))((IFolderView*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderView*, uint> )(lpVtbl[2]))((IFolderView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetCurrentViewMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCurrentViewMode(uint* pViewMode)
    {
        return ((delegate* unmanaged<IFolderView*, uint*, int> )(lpVtbl[3]))((IFolderView*)Unsafe.AsPointer(ref this), pViewMode);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.SetCurrentViewMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCurrentViewMode(uint ViewMode)
    {
        return ((delegate* unmanaged<IFolderView*, uint, int> )(lpVtbl[4]))((IFolderView*)Unsafe.AsPointer(ref this), ViewMode);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView*, Guid*, void**, int> )(lpVtbl[5]))((IFolderView*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.Item"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IFolderView*, int, ITEMIDLIST**, int> )(lpVtbl[6]))((IFolderView*)Unsafe.AsPointer(ref this), iItemIndex, ppidl);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.ItemCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ItemCount(uint uFlags, int* pcItems)
    {
        return ((delegate* unmanaged<IFolderView*, uint, int*, int> )(lpVtbl[7]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, pcItems);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.Items"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Items(uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IFolderView*, uint, Guid*, void**, int> )(lpVtbl[8]))((IFolderView*)Unsafe.AsPointer(ref this), uFlags, riid, ppv);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetSelectionMarkedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSelectionMarkedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView*, int*, int> )(lpVtbl[9]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetFocusedItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFocusedItem(int* piItem)
    {
        return ((delegate* unmanaged<IFolderView*, int*, int> )(lpVtbl[10]))((IFolderView*)Unsafe.AsPointer(ref this), piItem);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetItemPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView*, ITEMIDLIST*, POINT*, int> )(lpVtbl[11]))((IFolderView*)Unsafe.AsPointer(ref this), pidl, ppt);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView*, POINT*, int> )(lpVtbl[12]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetDefaultSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefaultSpacing(POINT* ppt)
    {
        return ((delegate* unmanaged<IFolderView*, POINT*, int> )(lpVtbl[13]))((IFolderView*)Unsafe.AsPointer(ref this), ppt);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.GetAutoArrange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetAutoArrange()
    {
        return ((delegate* unmanaged<IFolderView*, int> )(lpVtbl[14]))((IFolderView*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.SelectItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView*, int, uint, int> )(lpVtbl[15]))((IFolderView*)Unsafe.AsPointer(ref this), iItem, dwFlags);
    }

    /// <include file='IFolderView.xml' path='doc/member[@name="IFolderView.SelectAndPositionItems"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SelectAndPositionItems(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFolderView*, uint, ITEMIDLIST**, POINT*, uint, int> )(lpVtbl[16]))((IFolderView*)Unsafe.AsPointer(ref this), cidl, apidl, apt, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCurrentViewMode(uint* pViewMode);
        [VtblIndex(4)]
        HRESULT SetCurrentViewMode(uint ViewMode);
        [VtblIndex(5)]
        HRESULT GetFolder([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(6)]
        HRESULT Item(int iItemIndex, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
        [VtblIndex(7)]
        HRESULT ItemCount(uint uFlags, int* pcItems);
        [VtblIndex(8)]
        HRESULT Items(uint uFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(9)]
        HRESULT GetSelectionMarkedItem(int* piItem);
        [VtblIndex(10)]
        HRESULT GetFocusedItem(int* piItem);
        [VtblIndex(11)]
        HRESULT GetItemPosition([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, POINT* ppt);
        [VtblIndex(12)]
        HRESULT GetSpacing(POINT* ppt);
        [VtblIndex(13)]
        HRESULT GetDefaultSpacing(POINT* ppt);
        [VtblIndex(14)]
        HRESULT GetAutoArrange();
        [VtblIndex(15)]
        HRESULT SelectItem(int iItem, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(16)]
        HRESULT SelectAndPositionItems(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, POINT* apt, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentViewMode;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentViewMode;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetFolder;
        [NativeTypeName("HRESULT (int, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ITEMIDLIST**, int> Item;
        [NativeTypeName("HRESULT (UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> ItemCount;
        [NativeTypeName("HRESULT (UINT, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, void**, int> Items;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetSelectionMarkedItem;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetFocusedItem;
        [NativeTypeName("HRESULT (LPCITEMIDLIST, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, POINT*, int> GetItemPosition;
        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> GetSpacing;
        [NativeTypeName("HRESULT (POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, int> GetDefaultSpacing;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetAutoArrange;
        [NativeTypeName("HRESULT (int, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, int> SelectItem;
        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, POINT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITEMIDLIST**, POINT*, uint, int> SelectAndPositionItems;
    }
}