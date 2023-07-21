// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu"]/*' />
[Guid("EE1F7637-E138-11D1-8379-00C04FD918D0")]
[NativeTypeName("struct IShellMenu : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellMenu : IShellMenu.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellMenu));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellMenu*, Guid*, void**, int>)(lpVtbl[0]))((IShellMenu*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellMenu*, uint>)(lpVtbl[1]))((IShellMenu*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellMenu*, uint>)(lpVtbl[2]))((IShellMenu*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IShellMenuCallback* psmc, uint uId, uint uIdAncestor, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, IShellMenuCallback*, uint, uint, uint, int>)(lpVtbl[3]))((IShellMenu*)Unsafe.AsPointer(ref this), psmc, uId, uIdAncestor, dwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.GetMenuInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMenuInfo(IShellMenuCallback** ppsmc, uint* puId, uint* puIdAncestor, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, IShellMenuCallback**, uint*, uint*, uint*, int>)(lpVtbl[4]))((IShellMenu*)Unsafe.AsPointer(ref this), ppsmc, puId, puIdAncestor, pdwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.SetShellFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetShellFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HKEY hKey, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, IShellFolder*, ITEMIDLIST*, HKEY, uint, int>)(lpVtbl[5]))((IShellMenu*)Unsafe.AsPointer(ref this), psf, pidlFolder, hKey, dwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.GetShellFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetShellFolder([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellMenu*, uint*, ITEMIDLIST**, Guid*, void**, int>)(lpVtbl[6]))((IShellMenu*)Unsafe.AsPointer(ref this), pdwFlags, ppidl, riid, ppv);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.SetMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, HMENU, HWND, uint, int>)(lpVtbl[7]))((IShellMenu*)Unsafe.AsPointer(ref this), hmenu, hwnd, dwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.GetMenu"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, HMENU*, HWND*, uint*, int>)(lpVtbl[8]))((IShellMenu*)Unsafe.AsPointer(ref this), phmenu, phwnd, pdwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.InvalidateItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InvalidateItem([NativeTypeName("LPSMDATA")] SMDATA* psmd, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, SMDATA*, uint, int>)(lpVtbl[9]))((IShellMenu*)Unsafe.AsPointer(ref this), psmd, dwFlags);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.GetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd)
    {
        return ((delegate* unmanaged<IShellMenu*, SMDATA*, int>)(lpVtbl[10]))((IShellMenu*)Unsafe.AsPointer(ref this), psmd);
    }

    /// <include file='IShellMenu.xml' path='doc/member[@name="IShellMenu.SetMenuToolbar"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMenuToolbar(IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellMenu*, IUnknown*, uint, int>)(lpVtbl[11]))((IShellMenu*)Unsafe.AsPointer(ref this), punk, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IShellMenuCallback* psmc, uint uId, uint uIdAncestor, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT GetMenuInfo(IShellMenuCallback** ppsmc, uint* puId, uint* puIdAncestor, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(5)]
        HRESULT SetShellFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HKEY hKey, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT GetShellFolder([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(7)]
        HRESULT SetMenu(HMENU hmenu, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(8)]
        HRESULT GetMenu(HMENU* phmenu, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(9)]
        HRESULT InvalidateItem([NativeTypeName("LPSMDATA")] SMDATA* psmd, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(10)]
        HRESULT GetState([NativeTypeName("LPSMDATA")] SMDATA* psmd);

        [VtblIndex(11)]
        HRESULT SetMenuToolbar(IUnknown* punk, [NativeTypeName("DWORD")] uint dwFlags);
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

        [NativeTypeName("HRESULT (IShellMenuCallback *, UINT, UINT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellMenuCallback*, uint, uint, uint, int> Initialize;

        [NativeTypeName("HRESULT (IShellMenuCallback **, UINT *, UINT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellMenuCallback**, uint*, uint*, uint*, int> GetMenuInfo;

        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST, HKEY, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, HKEY, uint, int> SetShellFolder;

        [NativeTypeName("HRESULT (DWORD *, LPITEMIDLIST *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ITEMIDLIST**, Guid*, void**, int> GetShellFolder;

        [NativeTypeName("HRESULT (HMENU, HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, HWND, uint, int> SetMenu;

        [NativeTypeName("HRESULT (HMENU *, HWND *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU*, HWND*, uint*, int> GetMenu;

        [NativeTypeName("HRESULT (LPSMDATA, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SMDATA*, uint, int> InvalidateItem;

        [NativeTypeName("HRESULT (LPSMDATA) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SMDATA*, int> GetState;

        [NativeTypeName("HRESULT (IUnknown *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int> SetMenuToolbar;
    }
}
