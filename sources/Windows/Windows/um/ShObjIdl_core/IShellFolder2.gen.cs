// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2"]/*'/>
[Guid("93F2F68C-1D1B-11D3-A30E-00C04F79ABD1")]
[NativeTypeName("struct IShellFolder2 : IShellFolder")]
[NativeInheritance("IShellFolder")]
public unsafe partial struct IShellFolder2 : IShellFolder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellFolder2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellFolder2*, Guid*, void**, int> )(lpVtbl[0]))((IShellFolder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellFolder2*, uint> )(lpVtbl[1]))((IShellFolder2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellFolder2*, uint> )(lpVtbl[2]))((IShellFolder2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IShellFolder.ParseDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ParseDisplayName(HWND hwnd, IBindCtx* pbc, [NativeTypeName("LPWSTR")] ushort* pszDisplayName, [NativeTypeName("ULONG *")] uint* pchEaten, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("ULONG *")] uint* pdwAttributes)
    {
        return ((delegate* unmanaged<IShellFolder2*, HWND, IBindCtx*, ushort*, uint*, ITEMIDLIST**, uint*, int> )(lpVtbl[3]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, pbc, pszDisplayName, pchEaten, ppidl, pdwAttributes);
    }

    /// <inheritdoc cref = "IShellFolder.EnumObjects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects(HWND hwnd, [NativeTypeName("SHCONTF")] uint grfFlags, IEnumIDList** ppenumIDList)
    {
        return ((delegate* unmanaged<IShellFolder2*, HWND, uint, IEnumIDList**, int> )(lpVtbl[4]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, grfFlags, ppenumIDList);
    }

    /// <inheritdoc cref = "IShellFolder.BindToObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BindToObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int> )(lpVtbl[5]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
    }

    /// <inheritdoc cref = "IShellFolder.BindToStorage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT BindToStorage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, IBindCtx*, Guid*, void**, int> )(lpVtbl[6]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pbc, riid, ppv);
    }

    /// <inheritdoc cref = "IShellFolder.CompareIDs"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CompareIDs(LPARAM lParam, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
    {
        return ((delegate* unmanaged<IShellFolder2*, LPARAM, ITEMIDLIST*, ITEMIDLIST*, int> )(lpVtbl[7]))((IShellFolder2*)Unsafe.AsPointer(ref this), lParam, pidl1, pidl2);
    }

    /// <inheritdoc cref = "IShellFolder.CreateViewObject"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateViewObject(HWND hwndOwner, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder2*, HWND, Guid*, void**, int> )(lpVtbl[8]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwndOwner, riid, ppv);
    }

    /// <inheritdoc cref = "IShellFolder.GetAttributesOf"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAttributesOf(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("SFGAOF *")] uint* rgfInOut)
    {
        return ((delegate* unmanaged<IShellFolder2*, uint, ITEMIDLIST**, uint*, int> )(lpVtbl[9]))((IShellFolder2*)Unsafe.AsPointer(ref this), cidl, apidl, rgfInOut);
    }

    /// <inheritdoc cref = "IShellFolder.GetUIObjectOf"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetUIObjectOf(HWND hwndOwner, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("const IID &")] Guid* riid, uint* rgfReserved, void** ppv)
    {
        return ((delegate* unmanaged<IShellFolder2*, HWND, uint, ITEMIDLIST**, Guid*, uint*, void**, int> )(lpVtbl[10]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwndOwner, cidl, apidl, riid, rgfReserved, ppv);
    }

    /// <inheritdoc cref = "IShellFolder.GetDisplayNameOf"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDisplayNameOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("SHGDNF")] uint uFlags, STRRET* pName)
    {
        return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, uint, STRRET*, int> )(lpVtbl[11]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, uFlags, pName);
    }

    /// <inheritdoc cref = "IShellFolder.SetNameOf"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetNameOf(HWND hwnd, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("SHGDNF")] uint uFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
    {
        return ((delegate* unmanaged<IShellFolder2*, HWND, ITEMIDLIST*, ushort*, uint, ITEMIDLIST**, int> )(lpVtbl[12]))((IShellFolder2*)Unsafe.AsPointer(ref this), hwnd, pidl, pszName, uFlags, ppidlOut);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.GetDefaultSearchGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDefaultSearchGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<IShellFolder2*, Guid*, int> )(lpVtbl[13]))((IShellFolder2*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.EnumSearches"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnumSearches(IEnumExtraSearch** ppenum)
    {
        return ((delegate* unmanaged<IShellFolder2*, IEnumExtraSearch**, int> )(lpVtbl[14]))((IShellFolder2*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.GetDefaultColumn"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDefaultColumn([NativeTypeName("DWORD")] uint dwRes, [NativeTypeName("ULONG *")] uint* pSort, [NativeTypeName("ULONG *")] uint* pDisplay)
    {
        return ((delegate* unmanaged<IShellFolder2*, uint, uint*, uint*, int> )(lpVtbl[15]))((IShellFolder2*)Unsafe.AsPointer(ref this), dwRes, pSort, pDisplay);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.GetDefaultColumnState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDefaultColumnState(uint iColumn, [NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags)
    {
        return ((delegate* unmanaged<IShellFolder2*, uint, uint*, int> )(lpVtbl[16]))((IShellFolder2*)Unsafe.AsPointer(ref this), iColumn, pcsFlags);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.GetDetailsEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetDetailsEx([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, VARIANT* pv)
    {
        return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, PROPERTYKEY*, VARIANT*, int> )(lpVtbl[17]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, pscid, pv);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.GetDetailsOf"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* psd)
    {
        return ((delegate* unmanaged<IShellFolder2*, ITEMIDLIST*, uint, SHELLDETAILS*, int> )(lpVtbl[18]))((IShellFolder2*)Unsafe.AsPointer(ref this), pidl, iColumn, psd);
    }

    /// <include file='IShellFolder2.xml' path='doc/member[@name="IShellFolder2.MapColumnToSCID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MapColumnToSCID(uint iColumn, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid)
    {
        return ((delegate* unmanaged<IShellFolder2*, uint, PROPERTYKEY*, int> )(lpVtbl[19]))((IShellFolder2*)Unsafe.AsPointer(ref this), iColumn, pscid);
    }

    public interface Interface : IShellFolder.Interface
    {
        [VtblIndex(13)]
        HRESULT GetDefaultSearchGUID(Guid* pguid);
        [VtblIndex(14)]
        HRESULT EnumSearches(IEnumExtraSearch** ppenum);
        [VtblIndex(15)]
        HRESULT GetDefaultColumn([NativeTypeName("DWORD")] uint dwRes, [NativeTypeName("ULONG *")] uint* pSort, [NativeTypeName("ULONG *")] uint* pDisplay);
        [VtblIndex(16)]
        HRESULT GetDefaultColumnState(uint iColumn, [NativeTypeName("SHCOLSTATEF *")] uint* pcsFlags);
        [VtblIndex(17)]
        HRESULT GetDetailsEx([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, VARIANT* pv);
        [VtblIndex(18)]
        HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* psd);
        [VtblIndex(19)]
        HRESULT MapColumnToSCID(uint iColumn, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid);
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
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDefaultSearchGUID;
        [NativeTypeName("HRESULT (IEnumExtraSearch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumExtraSearch**, int> EnumSearches;
        [NativeTypeName("HRESULT (DWORD, ULONG *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetDefaultColumn;
        [NativeTypeName("HRESULT (UINT, SHCOLSTATEF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetDefaultColumnState;
        [NativeTypeName("HRESULT (LPCITEMIDLIST, const SHCOLUMNID *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, PROPERTYKEY*, VARIANT*, int> GetDetailsEx;
        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT, SHELLDETAILS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, SHELLDETAILS*, int> GetDetailsOf;
        [NativeTypeName("HRESULT (UINT, SHCOLUMNID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPERTYKEY*, int> MapColumnToSCID;
    }
}