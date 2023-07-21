// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder"]/*' />
[Guid("000214E6-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellFolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellFolder : IShellFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFolder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFolder*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellFolder*, uint>)(lpVtbl[1]))((IShellFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFolder*, uint>)(lpVtbl[2]))((IShellFolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.ParseDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseDisplayName(HWND hwnd, IBindCtx* pbc, [NativeTypeName("LPWSTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("ULONG *")] uint* pdwAttributes)
    {
        return ((delegate* unmanaged<IShellFolder*, HWND, IBindCtx*, ushort*, uint*, ITEMIDLIST**, uint*, int>)(lpVtbl[3]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, pbc, pszDisplayName, pchEaten, ppidl, pdwAttributes);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.EnumObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects(HWND hwnd, [NativeTypeName("SHCONTF")] uint grfFlags, IEnumIDList** ppenumIDList)
    {
        return ((delegate* unmanaged<IShellFolder*, HWND, uint, IEnumIDList**, int>)(lpVtbl[4]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, grfFlags, ppenumIDList);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.BindToObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BindToObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[5]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.BindToStorage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindToStorage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int>)(lpVtbl[6]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.CompareIDs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CompareIDs(LPARAM lParam, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
    {
        return ((delegate* unmanaged<IShellFolder*, LPARAM, ITEMIDLIST*, ITEMIDLIST*, int>)(lpVtbl[7]))((IShellFolder*)Unsafe.AsPointer(ref this), lParam, pidl1, pidl2);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.CreateViewObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateViewObject(HWND hwndOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder*, HWND, Guid*, void**, int>)(lpVtbl[8]))((IShellFolder*)Unsafe.AsPointer(ref this), hwndOwner, riid, ppv);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.GetAttributesOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAttributesOf(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("SFGAOF *")] uint* rgfInOut)
    {
        return ((delegate* unmanaged<IShellFolder*, uint, ITEMIDLIST**, uint*, int>)(lpVtbl[9]))((IShellFolder*)Unsafe.AsPointer(ref this), cidl, apidl, rgfInOut);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.GetUIObjectOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetUIObjectOf(HWND hwndOwner, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("const IID &")] Guid* riid, uint* rgfReserved, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder*, HWND, uint, ITEMIDLIST**, Guid*, uint*, void**, int>)(lpVtbl[10]))((IShellFolder*)Unsafe.AsPointer(ref this), hwndOwner, cidl, apidl, riid, rgfReserved, ppv);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.GetDisplayNameOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayNameOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("SHGDNF")] uint uFlags, STRRET* pName)
    {
        return ((delegate* unmanaged<IShellFolder*, ITEMIDLIST*, uint, STRRET*, int>)(lpVtbl[11]))((IShellFolder*)Unsafe.AsPointer(ref this), pidl, uFlags, pName);
    }

    /// <include file='IShellFolder.xml' path='doc/member[@name="IShellFolder.SetNameOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetNameOf(HWND hwnd, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("SHGDNF")] uint uFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
    {
        return ((delegate* unmanaged<IShellFolder*, HWND, ITEMIDLIST*, ushort*, uint, ITEMIDLIST**, int>)(lpVtbl[12]))((IShellFolder*)Unsafe.AsPointer(ref this), hwnd, pidl, pszName, uFlags, ppidlOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ParseDisplayName(HWND hwnd, IBindCtx* pbc, [NativeTypeName("LPWSTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("ULONG *")] uint* pdwAttributes);

        [VtblIndex(4)]
        HRESULT EnumObjects(HWND hwnd, [NativeTypeName("SHCONTF")] uint grfFlags, IEnumIDList** ppenumIDList);

        [VtblIndex(5)]
        HRESULT BindToObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(6)]
        HRESULT BindToStorage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(7)]
        HRESULT CompareIDs(LPARAM lParam, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);

        [VtblIndex(8)]
        HRESULT CreateViewObject(HWND hwndOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(9)]
        HRESULT GetAttributesOf(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("SFGAOF *")] uint* rgfInOut);

        [VtblIndex(10)]
        HRESULT GetUIObjectOf(HWND hwndOwner, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("const IID &")] Guid* riid, uint* rgfReserved, void** ppv);

        [VtblIndex(11)]
        HRESULT GetDisplayNameOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("SHGDNF")] uint uFlags, STRRET* pName);

        [VtblIndex(12)]
        HRESULT SetNameOf(HWND hwnd, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("SHGDNF")] uint uFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut);
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

        [NativeTypeName("HRESULT (HWND, IBindCtx *, LPWSTR, ULONG *, LPITEMIDLIST *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IBindCtx*, ushort*, uint*, ITEMIDLIST**, uint*, int> ParseDisplayName;

        [NativeTypeName("HRESULT (HWND, SHCONTF, IEnumIDList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, IEnumIDList**, int> EnumObjects;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int> BindToObject;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, IBindCtx *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int> BindToStorage;

        [NativeTypeName("HRESULT (LPARAM, LPCITEMIDLIST, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LPARAM, ITEMIDLIST*, ITEMIDLIST*, int> CompareIDs;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> CreateViewObject;

        [NativeTypeName("HRESULT (UINT, LPCITEMIDLIST *, SFGAOF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITEMIDLIST**, uint*, int> GetAttributesOf;

        [NativeTypeName("HRESULT (HWND, UINT, LPCITEMIDLIST *, const IID &, UINT *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, ITEMIDLIST**, Guid*, uint*, void**, int> GetUIObjectOf;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, SHGDNF, STRRET *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, STRRET*, int> GetDisplayNameOf;

        [NativeTypeName("HRESULT (HWND, LPCITEMIDLIST, LPCWSTR, SHGDNF, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ITEMIDLIST*, ushort*, uint, ITEMIDLIST**, int> SetNameOf;
    }
}
